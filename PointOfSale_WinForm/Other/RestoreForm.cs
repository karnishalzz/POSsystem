using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.Other
{
    public partial class RestoreForm : Form
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(directorytextBox.Text))
                {
                    using (var con = new SqlConnection())
                    {
                        string fullPath = "";
                        string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        fullPath = (System.IO.Path.GetDirectoryName(executable));
                        AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
                        var dbfileName = fullPath + "\\posDb.mdf";
                        con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\posDb.mdf;Integrated Security=True;";
                        con.Open();
                        string UseMaster = "USE master";
                        SqlCommand UseMasterCommand = new SqlCommand(UseMaster, con);
                        UseMasterCommand.ExecuteNonQuery();

                        string Alter1 = $@"ALTER DATABASE ""{dbfileName}"" SET Single_User WITH Rollback Immediate";
                        SqlCommand Alter1Cmd = new SqlCommand(Alter1, con);
                        Alter1Cmd.ExecuteNonQuery();

                        string Restore = $@"RESTORE DATABASE ""{dbfileName}"" FROM DISK='{directorytextBox.Text.Trim()}'";
                        SqlCommand RestoreCmd = new SqlCommand(Restore, con);
                        RestoreCmd.ExecuteNonQuery();

                        string Alter2 = $@"ALTER DATABASE ""{dbfileName}"" SET Multi_User";
                        SqlCommand Alter2Cmd = new SqlCommand(Alter2, con);
                        Alter2Cmd.ExecuteNonQuery();
                        con.Close();


                    }

                    MessageBox.Show($"Database backup has successfully restored.", "Confirmation");

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.InitialDirectory = "C:\\";
            diag.Filter = "Database file (posDb.bak)|posDb.bak";
            diag.RestoreDirectory = true;
            if (diag.ShowDialog() == DialogResult.OK)
            {
                directorytextBox.Text = diag.FileName;  //selected folder path

            }
        }
    }
}
