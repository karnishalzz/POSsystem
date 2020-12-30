using PointOfSale_WinForm.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.Other
{
    public partial class LicesnseForm : Form
    {
        
        private string code = "";
        
        public LicesnseForm()
        {
            InitializeComponent();
            productCodeTextBox.Text = "POS_V1_KPFM";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string generatedCode = productCodeTextBox.Text.Trim() + pcIdTextBox.Text.Trim() + "MARINOFT*";
            var hashCode = CreateMD5(generatedCode);
            if (hashCode != licenseTextBox.Text.Trim())
            {
                MessageBox.Show("Invalid Licesnse Key.Please Try Again", "Invalid", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {
                createFile(hashCode);
                
                LoginForm loginForm = new LoginForm(this);
                this.Hide();
                loginForm.ShowDialog();

            }
        }

        private string CreateMD5(string generatedCode)
        {
           
                using (MD5 mD5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(generatedCode);
                    byte[] hashBytes = mD5.ComputeHash(inputBytes);
                    //converts byte to hexadecimal string
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        stringBuilder.Append(hashBytes[i].ToString("X2"));

                    }
                    var hashCode = Hash(stringBuilder.ToString());
                    return hashCode;
                }

        }
        private string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {

                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private void createFile(string license)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\key\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\key\");
                }
                if (!Directory.Exists(Application.StartupPath + @"\key\" + "License"))
                {
                    using (FileStream fileStream = File.Create(Application.StartupPath + @"\key\" + "License"))
                    {
                        Byte[] title = new UTF8Encoding(true).GetBytes(license);
                        fileStream.Write(title, 0, title.Length);
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void LicesnseForm_Load(object sender, EventArgs e)
        {
            pcIdTextBox.Text = getPcId();
            var licenseCode = GetLicenseFromTempTextFile();
            bool x = MatchLicense(licenseCode);
            if (x != false)
            {
                LoginForm loginForm = new LoginForm(this);
                this.Hide();
                loginForm.ShowDialog();
            }
        }
        private String getPcId()
        {

            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_BIOS");
            foreach (ManagementObject getSerial in managementObjectSearcher.Get())
            {
                code = getSerial["SerialNumber"].ToString();
            }
            return code;
        }
        public string GetLicenseFromTempTextFile()
        {
            string fileName = Application.StartupPath+ @"\Key\License";
            FileInfo fi = new FileInfo(fileName);

            try
            {

                if (fi.Exists)
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            return s;
                        }
                        return s;
                    }
                }
                else
                {
                    return "not found";
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public bool MatchLicense(string license)
        {
            string generatedCode = productCodeTextBox.Text.Trim() + pcIdTextBox.Text.Trim() + "MARINOFT*";
            var hashCode = CreateMD5(generatedCode);
            if (hashCode != license)
            {
                return false;
            }
            return true;

        }
    }
}
