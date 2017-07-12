namespace Print_button
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnectUSB = new System.Windows.Forms.Button();
            this.buttonConnectWIFI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnectUSB
            // 
            this.buttonConnectUSB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnectUSB.Location = new System.Drawing.Point(82, 12);
            this.buttonConnectUSB.Name = "buttonConnectUSB";
            this.buttonConnectUSB.Size = new System.Drawing.Size(118, 23);
            this.buttonConnectUSB.TabIndex = 0;
            this.buttonConnectUSB.Text = "Connect overUSB";
            this.buttonConnectUSB.UseVisualStyleBackColor = true;
            this.buttonConnectUSB.Click += new System.EventHandler(this.buttonConnectUSB_Click);
            // 
            // buttonConnectWIFI
            // 
            this.buttonConnectWIFI.Location = new System.Drawing.Point(82, 78);
            this.buttonConnectWIFI.Name = "buttonConnectWIFI";
            this.buttonConnectWIFI.Size = new System.Drawing.Size(118, 23);
            this.buttonConnectWIFI.TabIndex = 1;
            this.buttonConnectWIFI.Text = "Connect over TCP";
            this.buttonConnectWIFI.UseVisualStyleBackColor = true;
            this.buttonConnectWIFI.Click += new System.EventHandler(this.buttonConnectWIFI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Or enter an IP Address:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(136, 51);
            this.textBoxIP.MaxLength = 15;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(126, 20);
            this.textBoxIP.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnectWIFI);
            this.Controls.Add(this.buttonConnectUSB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Solo Print Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectUSB;
        private System.Windows.Forms.Button buttonConnectWIFI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button button1;
    }
}

