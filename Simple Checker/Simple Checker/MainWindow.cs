using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Simple_Checker
{
    /*
     * 
     * Program created by Riski Setyo Wibowo
     * 
     */


    public partial class MainWindow : Form
    {
        private string _comPort;

        private string _UUTserialNumber;
        private string _UUTmacAddress;
        private List<string> _UUTInfo;

        private bool _isPass;

        //-----Port Information-----//
        public string ComPort
        {
            get => _comPort;
            set { _comPort = value; }
        }

        public string UUTSerialNumber
        {
            get => _UUTserialNumber;
            set { _UUTserialNumber = value; }
        }

        public string UUTMacAddress
        {
            get => _UUTmacAddress;
            set { _UUTmacAddress = value; }
        }

        public List<string> UUTInfo
        {
            get => _UUTInfo;
            set { _UUTInfo = value; }
        }

        public bool IsPass
        {
            get => _isPass;
            set { _isPass = value; }
        }



        readonly SerialPort port = new SerialPort();

        public MainWindow()
        {
            InitializeComponent();
        }

        //-----Enable/Disable Contents-----//
        private void EnableContent(bool condition)
        {
            buttonGetPort.Enabled = condition;
            comboBoxGetPort.Enabled = condition;
            buttonStart.Enabled = condition;
        }

        private void buttonGetPort_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                comboBoxGetPort.Items.Clear();
                string[] ArrayComPortsNames;

                int index = -1;
                string ComPortName = null;

                ArrayComPortsNames = SerialPort.GetPortNames();
                try
                {
                    do
                    {
                        index += 1;
                        comboBoxGetPort.Items.Add(ArrayComPortsNames[index]);
                    }
                    while (!((ArrayComPortsNames[index] == ComPortName)
                                  || (index == ArrayComPortsNames.GetUpperBound(0))));
                    Array.Sort(ArrayComPortsNames);

                    //want to get first out
                    if (index == ArrayComPortsNames.GetUpperBound(0))
                    {
                        ComPortName = ArrayComPortsNames[0];
                    }
                    comboBoxGetPort.Text = ArrayComPortsNames[0];
                }
                catch
                {
                    MessageBox.Show("Port is not connected.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Port is already ON. \nClick CLOSE button first.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxGetPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                ComPort = (string)comboBoxGetPort.SelectedItem;
            }
            else
            {
                MessageBox.Show("Port is already ON. \nClick CLOSE button first.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //-----Send and Received Data-----//
        private async Task<string> SendReceivedData(SerialPort sPort, string command)
        {
            await Task.Delay(100);
            sPort.WriteLine(command);
            await Task.Delay(100);
            string response = sPort.ReadExisting();
            return response;
        }

        //-----Discard In and Out Buffer COM Ports-----//
        public void DiscardBuffersInOut(SerialPort sPort)
        {
            sPort.DiscardInBuffer();
            sPort.DiscardOutBuffer();
        }

        //-----Reading Unit SN & MAC-----//
        private async Task ReadUUT()
        {
            try
            {
                UUTInfo = new List<string>();
                UUTSerialNumber = "";
                UUTMacAddress = "";
                using (SerialPort serialPort = new SerialPort()
                {
                    PortName = ComPort,
                    BaudRate = 115200,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    ReadTimeout = 2000,
                    WriteTimeout = 2000,
                    Handshake = Handshake.None,
                    DtrEnable = true,
                    NewLine = "\r\n"
                })
                {
                    serialPort.Open();
                    await Task.Delay(100);

                    DiscardBuffersInOut(serialPort);
                    //await Task.Delay(100);

                    string[] snList = new string[3]
                    {
                        "||;1>GET SERIAL.NUMBER",
                        "||;1>GET DEVICE.SERIAL-NUMBER",
                        "||;1>GET HWDATA.SERIAL-NUMBER"
                    };

                    string readData = "";
                    string command = "";
                    string[] SNarray = snList;
                    for (int index = 0; index < SNarray.Length; ++index)
                    {
                        command = SNarray[index];
                        readData = await SendReceivedData(serialPort, command);
                        if (readData.Contains("Invalid command") || readData.Contains("[101]"))
                            command = (string)null;
                        else
                            break;
                    }
                    SNarray = (string[])null;

                    UUTSerialNumber = readData.Replace(command, "").Replace("||", "").Replace("[0]", "").Replace(">", "").Trim();
                    labelUUTSN.Text = UUTSerialNumber;

                    DiscardBuffersInOut(serialPort);
                    string[] macList = new string[3]
                    {
                        "||;1>GET MAC.ADDRESS",
                        "||;1>GET DEVICE.MAC-ADDRESS",
                        "||;1>GET HWDATA.MAC-ADDRESS"
                    };

                    readData = "";
                    command = "";
                    string[] MACarray = macList;
                    for (int index = 0; index < MACarray.Length; ++index)
                    {
                        command = MACarray[index];
                        readData = await SendReceivedData(serialPort, command);
                        if (readData.Contains("Invalid command") || readData.Contains("[101]"))
                            command = (string)null;
                        else
                            break;
                    }
                    MACarray = (string[])null;

                    UUTMacAddress = readData.Replace(command, "").Replace("||", "").Replace("[0]", "").Replace(">", "").Trim();
                    UUTMacAddress = UUTMacAddress.Replace("-", "").Replace(":", "");

                    string tempMac = UUTMacAddress;
                    for (int i = 2; i <= 14;)
                    {
                        tempMac = tempMac.Insert(i, ":");
                        i += 3;
                    }
                    labelUUTMAC.Text = tempMac;

                    serialPort.Close();
                    snList = (string[])null;
                    macList = (string[])null;
                    readData = (string)null;
                }
            }
            catch (Exception)
            {
                SerialPort serialPort = new SerialPort()
                {
                    PortName = ComPort,
                };
                serialPort.Close();
            }
            finally
            {
                UUTInfo.Add(UUTSerialNumber);
                UUTInfo.Add(UUTMacAddress);
            }
        }


        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            EnableContent(false);
            labelUUTSN.Text = "";
            labelUUTMAC.Text = "";
            labelUUTSN.ForeColor = Color.Black;
            labelUUTMAC.ForeColor = Color.Black;

            if (ComPort != null)
            {
                await ReadUUT();
                if (!IsPass)
                {
                    if (UUTSerialNumber == "" || UUTMacAddress == "")
                    {
                        labelUUTSN.ForeColor = Color.Red;
                        labelUUTMAC.ForeColor = Color.Red;
                        labelUUTSN.Text = "No Serial";
                        labelUUTMAC.Text = "No MAC";
                    }
                }
            }
            else
            {
                //ResultLog(false);
            }

            EnableContent(true);
        }
    } 
}
