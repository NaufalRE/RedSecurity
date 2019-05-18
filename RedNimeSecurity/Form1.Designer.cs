namespace RedNimeSecurity
{
    partial class SecurityForm
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
            this.L_TitleApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_Input = new System.Windows.Forms.RichTextBox();
            this.B_Convert = new System.Windows.Forms.Button();
            this.RTB_Output = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.R_Encrypt = new System.Windows.Forms.RadioButton();
            this.R_Decrypt = new System.Windows.Forms.RadioButton();
            this.R_Md5 = new System.Windows.Forms.RadioButton();
            this.R_Base64 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_TitleApp
            // 
            this.L_TitleApp.AutoSize = true;
            this.L_TitleApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TitleApp.Location = new System.Drawing.Point(348, 44);
            this.L_TitleApp.Name = "L_TitleApp";
            this.L_TitleApp.Size = new System.Drawing.Size(131, 21);
            this.L_TitleApp.TabIndex = 0;
            this.L_TitleApp.Text = "RedNimeSecurity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input :";
            // 
            // RTB_Input
            // 
            this.RTB_Input.Location = new System.Drawing.Point(147, 125);
            this.RTB_Input.Name = "RTB_Input";
            this.RTB_Input.Size = new System.Drawing.Size(502, 100);
            this.RTB_Input.TabIndex = 2;
            this.RTB_Input.Text = "";
            // 
            // B_Convert
            // 
            this.B_Convert.Location = new System.Drawing.Point(681, 185);
            this.B_Convert.Name = "B_Convert";
            this.B_Convert.Size = new System.Drawing.Size(118, 102);
            this.B_Convert.TabIndex = 5;
            this.B_Convert.Text = "Process";
            this.B_Convert.UseVisualStyleBackColor = true;
            this.B_Convert.Click += new System.EventHandler(this.B_Convert_Click);
            // 
            // RTB_Output
            // 
            this.RTB_Output.Location = new System.Drawing.Point(147, 269);
            this.RTB_Output.Name = "RTB_Output";
            this.RTB_Output.Size = new System.Drawing.Size(502, 100);
            this.RTB_Output.TabIndex = 6;
            this.RTB_Output.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.R_Decrypt);
            this.groupBox1.Controls.Add(this.R_Encrypt);
            this.groupBox1.Location = new System.Drawing.Point(147, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.R_Base64);
            this.groupBox2.Controls.Add(this.R_Md5);
            this.groupBox2.Location = new System.Drawing.Point(271, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 107);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash";
            // 
            // R_Encrypt
            // 
            this.R_Encrypt.AutoSize = true;
            this.R_Encrypt.Location = new System.Drawing.Point(6, 31);
            this.R_Encrypt.Name = "R_Encrypt";
            this.R_Encrypt.Size = new System.Drawing.Size(61, 17);
            this.R_Encrypt.TabIndex = 0;
            this.R_Encrypt.TabStop = true;
            this.R_Encrypt.Text = "Encrypt";
            this.R_Encrypt.UseVisualStyleBackColor = true;
            this.R_Encrypt.Click += new System.EventHandler(this.R_Encrypt_Click);
            // 
            // R_Decrypt
            // 
            this.R_Decrypt.AutoSize = true;
            this.R_Decrypt.Location = new System.Drawing.Point(6, 54);
            this.R_Decrypt.Name = "R_Decrypt";
            this.R_Decrypt.Size = new System.Drawing.Size(62, 17);
            this.R_Decrypt.TabIndex = 1;
            this.R_Decrypt.TabStop = true;
            this.R_Decrypt.Text = "Decrypt";
            this.R_Decrypt.UseVisualStyleBackColor = true;
            this.R_Decrypt.Click += new System.EventHandler(this.R_Decrypt_Click);
            // 
            // R_Md5
            // 
            this.R_Md5.AutoSize = true;
            this.R_Md5.Location = new System.Drawing.Point(6, 31);
            this.R_Md5.Name = "R_Md5";
            this.R_Md5.Size = new System.Drawing.Size(48, 17);
            this.R_Md5.TabIndex = 2;
            this.R_Md5.TabStop = true;
            this.R_Md5.Text = "MD5";
            this.R_Md5.UseVisualStyleBackColor = true;
            // 
            // R_Base64
            // 
            this.R_Base64.AutoSize = true;
            this.R_Base64.Location = new System.Drawing.Point(6, 54);
            this.R_Base64.Name = "R_Base64";
            this.R_Base64.Size = new System.Drawing.Size(64, 17);
            this.R_Base64.TabIndex = 3;
            this.R_Base64.TabStop = true;
            this.R_Base64.Text = "Base 64";
            this.R_Base64.UseVisualStyleBackColor = true;
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTB_Output);
            this.Controls.Add(this.B_Convert);
            this.Controls.Add(this.RTB_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_TitleApp);
            this.MaximizeBox = false;
            this.Name = "SecurityForm";
            this.Text = "My Security";
            this.Load += new System.EventHandler(this.SecurityForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_TitleApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_Input;
        private System.Windows.Forms.Button B_Convert;
        private System.Windows.Forms.RichTextBox RTB_Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton R_Decrypt;
        private System.Windows.Forms.RadioButton R_Encrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton R_Base64;
        private System.Windows.Forms.RadioButton R_Md5;
    }
}

