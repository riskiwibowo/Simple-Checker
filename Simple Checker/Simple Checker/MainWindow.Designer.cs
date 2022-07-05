namespace Simple_Checker
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonGetPort = new System.Windows.Forms.Button();
            this.comboBoxGetPort = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUUTMAC = new System.Windows.Forms.Label();
            this.labelUUTSN = new System.Windows.Forms.Label();
            this.labelSN = new System.Windows.Forms.Label();
            this.labelMAC = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetPort
            // 
            this.buttonGetPort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPort.Location = new System.Drawing.Point(5, 3);
            this.buttonGetPort.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonGetPort.Name = "buttonGetPort";
            this.buttonGetPort.Size = new System.Drawing.Size(128, 32);
            this.buttonGetPort.TabIndex = 0;
            this.buttonGetPort.Text = "Get Serial Port";
            this.buttonGetPort.UseVisualStyleBackColor = true;
            this.buttonGetPort.Click += new System.EventHandler(this.buttonGetPort_Click);
            // 
            // comboBoxGetPort
            // 
            this.comboBoxGetPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGetPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGetPort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGetPort.FormattingEnabled = true;
            this.comboBoxGetPort.Location = new System.Drawing.Point(249, 5);
            this.comboBoxGetPort.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxGetPort.Name = "comboBoxGetPort";
            this.comboBoxGetPort.Size = new System.Drawing.Size(199, 28);
            this.comboBoxGetPort.Sorted = true;
            this.comboBoxGetPort.TabIndex = 33;
            this.comboBoxGetPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxGetPort_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxGetPort);
            this.panel2.Controls.Add(this.buttonGetPort);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Location = new System.Drawing.Point(14, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 96);
            this.panel2.TabIndex = 65;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(5, 41);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(444, 48);
            this.buttonStart.TabIndex = 34;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelUUTMAC);
            this.panel3.Controls.Add(this.labelUUTSN);
            this.panel3.Controls.Add(this.labelSN);
            this.panel3.Controls.Add(this.labelMAC);
            this.panel3.Location = new System.Drawing.Point(14, 114);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 106);
            this.panel3.TabIndex = 72;
            // 
            // labelUUTMAC
            // 
            this.labelUUTMAC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUUTMAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUUTMAC.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelUUTMAC.Location = new System.Drawing.Point(249, 56);
            this.labelUUTMAC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUUTMAC.Name = "labelUUTMAC";
            this.labelUUTMAC.Size = new System.Drawing.Size(199, 40);
            this.labelUUTMAC.TabIndex = 40;
            this.labelUUTMAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUUTSN
            // 
            this.labelUUTSN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUUTSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUUTSN.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelUUTSN.Location = new System.Drawing.Point(249, 8);
            this.labelUUTSN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUUTSN.Name = "labelUUTSN";
            this.labelUUTSN.Size = new System.Drawing.Size(199, 40);
            this.labelUUTSN.TabIndex = 39;
            this.labelUUTSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSN.Location = new System.Drawing.Point(5, 16);
            this.labelSN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(108, 20);
            this.labelSN.TabIndex = 35;
            this.labelSN.Text = "Serial Number";
            // 
            // labelMAC
            // 
            this.labelMAC.AutoSize = true;
            this.labelMAC.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAC.Location = new System.Drawing.Point(5, 68);
            this.labelMAC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(100, 20);
            this.labelMAC.TabIndex = 36;
            this.labelMAC.Text = "MAC Address";
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by.Location = new System.Drawing.Point(297, 229);
            this.by.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(167, 20);
            this.by.TabIndex = 41;
            this.by.Text = "By: Riski Setyo Wibowo";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.by);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Checker";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetPort;
        private System.Windows.Forms.ComboBox comboBoxGetPort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUUTMAC;
        private System.Windows.Forms.Label labelUUTSN;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label labelMAC;
        private System.Windows.Forms.Label by;
    }
}

