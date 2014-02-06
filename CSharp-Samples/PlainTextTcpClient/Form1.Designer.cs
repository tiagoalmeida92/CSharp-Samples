namespace PlainTextTcpClient
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
            this.ip_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.result_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ip_tbox
            // 
            this.ip_tbox.Location = new System.Drawing.Point(17, 223);
            this.ip_tbox.Name = "ip_tbox";
            this.ip_tbox.Size = new System.Drawing.Size(130, 20);
            this.ip_tbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:Port";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(153, 214);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(101, 36);
            this.connect_button.TabIndex = 4;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_click);
            // 
            // result_tbox
            // 
            this.result_tbox.Location = new System.Drawing.Point(17, 12);
            this.result_tbox.Multiline = true;
            this.result_tbox.Name = "result_tbox";
            this.result_tbox.ReadOnly = true;
            this.result_tbox.Size = new System.Drawing.Size(237, 186);
            this.result_tbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 262);
            this.Controls.Add(this.result_tbox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_tbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox ip_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox result_tbox;
    }
}