using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Password_Generator_Form : Form
    {
        private string symbols = "!@#$%^&*()";
        private string numbers = "1234567890";
        private string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string path = @"C:\Users\Sofia\Desktop\File.txt";
        public string pass { get; set; }
        public bool writeToFile { get; set; }

        public Password_Generator_Form()
        {
            InitializeComponent();
        }

        #region Events
        private void ctrlGeneratePassword_Click(object sender, EventArgs e)
        {
            writeToFile = false;
            ControlArgs args = Arguments();
            PasswordValidation(args);
        }

        private void ctrlWriteToText_Click(object sender, EventArgs e)
        {
            writeToFile = true;
            ControlArgs args = Arguments();
            PasswordValidation(args);
        }

        #endregion

        private void PasswordValidation(ControlArgs args)
        {
            if ((!args.includeSymbols && !args.includeNumbers &&
                            !args.includeLowercase && !args.includeUppercase || args.passLength <= 0))
            {
                MessageBox.Show("Please choose at least one case and length");
            }
            else
            {
                pass = GeneratePassword(args);
                if (!writeToFile)
                {
                    ctrlPassword.Text = pass;
                }
            }
        }

        private ControlArgs Arguments()
        {
            bool ctrlSymbols = ctrlIncludeSymbols.Checked ? true : false;
            bool ctrlNumbers = ctrlIncludeNumbers.Checked ? true : false;
            bool ctrLowercase = ctrlIncludeLowercase.Checked ? true : false;
            bool ctrlUppercase = ctrlIncludeUppercase.Checked ? true : false;

            ControlArgs args = new ControlArgs
            {
                passLength = Convert.ToInt16(ctrlPassLength.Text),
                includeSymbols = ctrlSymbols,
                includeNumbers = ctrlNumbers,
                includeLowercase = ctrLowercase,
                includeUppercase = ctrlUppercase
            };
            return args;
        }

        private string GeneratePassword(ControlArgs args)
        {
            Random random = new Random();
            string charSet = string.Empty;
            char[] password = new char[args.passLength];

            if (args.includeUppercase) charSet += uppercase;
            if (args.includeLowercase) charSet += uppercase.ToLower();
            if (args.includeNumbers) charSet += numbers;
            if (args.includeSymbols) charSet += symbols;

            for (int i = 0; i < args.passLength; i++)
            {
                password[i] = charSet[random.Next(charSet.Length - 1)];
            }
            if (writeToFile)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (!File.Exists(path))
                {
                    //File.Create(path);
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    File.WriteAllLines(path, new string[] { string.Join(null, password) });
                }
            }
            return string.Join(null, password);
        }

       
    }
}


