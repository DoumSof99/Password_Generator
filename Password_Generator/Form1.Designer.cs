
namespace Password_Generator
{
    partial class Password_Generator_Form
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
            this.loPassLength = new System.Windows.Forms.Label();
            this.loIncludeSymbols = new System.Windows.Forms.Label();
            this.loIncludeNumbers = new System.Windows.Forms.Label();
            this.loIncludeLowercase = new System.Windows.Forms.Label();
            this.loIncludeUppercase = new System.Windows.Forms.Label();
            this.loGeneratedPassword = new System.Windows.Forms.Label();
            this.ctrlPassLength = new System.Windows.Forms.NumericUpDown();
            this.ctrlIncludeSymbols = new System.Windows.Forms.CheckBox();
            this.ctrlIncludeNumbers = new System.Windows.Forms.CheckBox();
            this.ctrlIncludeLowercase = new System.Windows.Forms.CheckBox();
            this.ctrlIncludeUppercase = new System.Windows.Forms.CheckBox();
            this.ctrlGeneratePassword = new System.Windows.Forms.Button();
            this.ctrlWriteToText = new System.Windows.Forms.Button();
            this.ctrlPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassLength)).BeginInit();
            this.SuspendLayout();
            // 
            // loPassLength
            // 
            this.loPassLength.AutoSize = true;
            this.loPassLength.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loPassLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loPassLength.Location = new System.Drawing.Point(44, 28);
            this.loPassLength.Name = "loPassLength";
            this.loPassLength.Size = new System.Drawing.Size(123, 19);
            this.loPassLength.TabIndex = 0;
            this.loPassLength.Text = "Password Length:";
            // 
            // loIncludeSymbols
            // 
            this.loIncludeSymbols.AutoSize = true;
            this.loIncludeSymbols.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loIncludeSymbols.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loIncludeSymbols.Location = new System.Drawing.Point(44, 65);
            this.loIncludeSymbols.Name = "loIncludeSymbols";
            this.loIncludeSymbols.Size = new System.Drawing.Size(117, 19);
            this.loIncludeSymbols.TabIndex = 1;
            this.loIncludeSymbols.Text = "Include Symbols:";
            // 
            // loIncludeNumbers
            // 
            this.loIncludeNumbers.AutoSize = true;
            this.loIncludeNumbers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loIncludeNumbers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loIncludeNumbers.Location = new System.Drawing.Point(43, 108);
            this.loIncludeNumbers.Name = "loIncludeNumbers";
            this.loIncludeNumbers.Size = new System.Drawing.Size(122, 19);
            this.loIncludeNumbers.TabIndex = 2;
            this.loIncludeNumbers.Text = "Include Numbers:";
            // 
            // loIncludeLowercase
            // 
            this.loIncludeLowercase.AutoSize = true;
            this.loIncludeLowercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loIncludeLowercase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loIncludeLowercase.Location = new System.Drawing.Point(44, 147);
            this.loIncludeLowercase.Name = "loIncludeLowercase";
            this.loIncludeLowercase.Size = new System.Drawing.Size(207, 19);
            this.loIncludeLowercase.TabIndex = 3;
            this.loIncludeLowercase.Text = "Include Lowercase Characters:";
            // 
            // loIncludeUppercase
            // 
            this.loIncludeUppercase.AutoSize = true;
            this.loIncludeUppercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loIncludeUppercase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loIncludeUppercase.Location = new System.Drawing.Point(44, 193);
            this.loIncludeUppercase.Name = "loIncludeUppercase";
            this.loIncludeUppercase.Size = new System.Drawing.Size(215, 19);
            this.loIncludeUppercase.TabIndex = 4;
            this.loIncludeUppercase.Text = "Include Upppercase Characters:";
            // 
            // loGeneratedPassword
            // 
            this.loGeneratedPassword.AutoSize = true;
            this.loGeneratedPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loGeneratedPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loGeneratedPassword.Location = new System.Drawing.Point(44, 326);
            this.loGeneratedPassword.Name = "loGeneratedPassword";
            this.loGeneratedPassword.Size = new System.Drawing.Size(179, 19);
            this.loGeneratedPassword.TabIndex = 6;
            this.loGeneratedPassword.Text = "Your Generated Password:";
            // 
            // ctrlPassLength
            // 
            this.ctrlPassLength.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPassLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlPassLength.Location = new System.Drawing.Point(277, 20);
            this.ctrlPassLength.Name = "ctrlPassLength";
            this.ctrlPassLength.Size = new System.Drawing.Size(296, 27);
            this.ctrlPassLength.TabIndex = 7;
            // 
            // ctrlIncludeSymbols
            // 
            this.ctrlIncludeSymbols.AutoSize = true;
            this.ctrlIncludeSymbols.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlIncludeSymbols.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlIncludeSymbols.Location = new System.Drawing.Point(277, 61);
            this.ctrlIncludeSymbols.Name = "ctrlIncludeSymbols";
            this.ctrlIncludeSymbols.Size = new System.Drawing.Size(107, 23);
            this.ctrlIncludeSymbols.TabIndex = 8;
            this.ctrlIncludeSymbols.Text = "(e.g. @#$%)";
            this.ctrlIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // ctrlIncludeNumbers
            // 
            this.ctrlIncludeNumbers.AutoSize = true;
            this.ctrlIncludeNumbers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlIncludeNumbers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlIncludeNumbers.Location = new System.Drawing.Point(277, 104);
            this.ctrlIncludeNumbers.Name = "ctrlIncludeNumbers";
            this.ctrlIncludeNumbers.Size = new System.Drawing.Size(106, 23);
            this.ctrlIncludeNumbers.TabIndex = 9;
            this.ctrlIncludeNumbers.Text = "(e.g. 12345)";
            this.ctrlIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // ctrlIncludeLowercase
            // 
            this.ctrlIncludeLowercase.AutoSize = true;
            this.ctrlIncludeLowercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlIncludeLowercase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlIncludeLowercase.Location = new System.Drawing.Point(277, 143);
            this.ctrlIncludeLowercase.Name = "ctrlIncludeLowercase";
            this.ctrlIncludeLowercase.Size = new System.Drawing.Size(118, 23);
            this.ctrlIncludeLowercase.TabIndex = 10;
            this.ctrlIncludeLowercase.Text = "(e.g. abcdefg)";
            this.ctrlIncludeLowercase.UseVisualStyleBackColor = true;
            // 
            // ctrlIncludeUppercase
            // 
            this.ctrlIncludeUppercase.AutoSize = true;
            this.ctrlIncludeUppercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlIncludeUppercase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlIncludeUppercase.Location = new System.Drawing.Point(277, 189);
            this.ctrlIncludeUppercase.Name = "ctrlIncludeUppercase";
            this.ctrlIncludeUppercase.Size = new System.Drawing.Size(128, 23);
            this.ctrlIncludeUppercase.TabIndex = 11;
            this.ctrlIncludeUppercase.Text = "(e.g. ABCDEFG)";
            this.ctrlIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // ctrlGeneratePassword
            // 
            this.ctrlGeneratePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlGeneratePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlGeneratePassword.Location = new System.Drawing.Point(277, 251);
            this.ctrlGeneratePassword.Name = "ctrlGeneratePassword";
            this.ctrlGeneratePassword.Size = new System.Drawing.Size(119, 31);
            this.ctrlGeneratePassword.TabIndex = 13;
            this.ctrlGeneratePassword.Text = "Generate Password";
            this.ctrlGeneratePassword.UseVisualStyleBackColor = true;
            this.ctrlGeneratePassword.Click += new System.EventHandler(this.ctrlGeneratePassword_Click);
            // 
            // ctrlWriteToText
            // 
            this.ctrlWriteToText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlWriteToText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlWriteToText.Location = new System.Drawing.Point(424, 251);
            this.ctrlWriteToText.Name = "ctrlWriteToText";
            this.ctrlWriteToText.Size = new System.Drawing.Size(119, 31);
            this.ctrlWriteToText.TabIndex = 14;
            this.ctrlWriteToText.Text = "Write To Text Editor";
            this.ctrlWriteToText.UseVisualStyleBackColor = true;
            this.ctrlWriteToText.Click += new System.EventHandler(this.ctrlWriteToText_Click);
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlPassword.Location = new System.Drawing.Point(277, 318);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Size = new System.Drawing.Size(296, 27);
            this.ctrlPassword.TabIndex = 15;
            // 
            // Password_Generator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 411);
            this.Controls.Add(this.ctrlPassword);
            this.Controls.Add(this.ctrlWriteToText);
            this.Controls.Add(this.ctrlGeneratePassword);
            this.Controls.Add(this.ctrlIncludeUppercase);
            this.Controls.Add(this.ctrlIncludeLowercase);
            this.Controls.Add(this.ctrlIncludeNumbers);
            this.Controls.Add(this.ctrlIncludeSymbols);
            this.Controls.Add(this.ctrlPassLength);
            this.Controls.Add(this.loGeneratedPassword);
            this.Controls.Add(this.loIncludeUppercase);
            this.Controls.Add(this.loIncludeLowercase);
            this.Controls.Add(this.loIncludeNumbers);
            this.Controls.Add(this.loIncludeSymbols);
            this.Controls.Add(this.loPassLength);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Password_Generator_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator Form";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loPassLength;
        private System.Windows.Forms.Label loIncludeSymbols;
        private System.Windows.Forms.Label loIncludeNumbers;
        private System.Windows.Forms.Label loIncludeLowercase;
        private System.Windows.Forms.Label loIncludeUppercase;
        private System.Windows.Forms.Label loGeneratedPassword;
        private System.Windows.Forms.NumericUpDown ctrlPassLength;
        private System.Windows.Forms.CheckBox ctrlIncludeSymbols;
        private System.Windows.Forms.CheckBox ctrlIncludeNumbers;
        private System.Windows.Forms.CheckBox ctrlIncludeLowercase;
        private System.Windows.Forms.CheckBox ctrlIncludeUppercase;
        private System.Windows.Forms.Button ctrlGeneratePassword;
        private System.Windows.Forms.Button ctrlWriteToText;
        private System.Windows.Forms.TextBox ctrlPassword;
    }
}

