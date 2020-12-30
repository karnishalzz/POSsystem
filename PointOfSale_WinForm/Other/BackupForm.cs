using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.Other
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                string backups = directorytextBox.Text;
                if (!System.IO.Directory.Exists(backups))
                {
                    MessageBox.Show("Please Select a Valid Directory.This Directory Does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string fullPath = "";
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                fullPath = (System.IO.Path.GetDirectoryName(executable));
                AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
                var dbfileName = fullPath + "\\posDb.mdf";
                var backupConn = new SqlConnection { ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\posDb.mdf;Integrated Security=True;" };

                backupConn.Open();

                var backupcomm = backupConn.CreateCommand();
                var backupdb = $@"BACKUP DATABASE ""{dbfileName}"" TO DISK='{Path.Combine(backups, "posDb.bak")}'";
                var backupcreatecomm = new SqlCommand(backupdb, backupConn);
                backupcreatecomm.ExecuteNonQuery();
                backupConn.Close();

                MessageBox.Show($"Database backup has successfully stored in {Path.Combine(backups, "posDb.bak")}", "Confirmation");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                directorytextBox.Text = diag.SelectedPath;  //selected folder path

            }
        }

      
}
}

