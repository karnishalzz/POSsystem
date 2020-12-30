using BusinessLayer_POS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.POS
{
    public partial class PasswordChangeForm : Form
    {
        POSForm _pOSForm;
        private readonly UserService userService = new UserService();
        public PasswordChangeForm(POSForm pOSForm)
        {
            InitializeComponent();
            _pOSForm = pOSForm;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = userService.GetUser(_pOSForm.usernameLabel.Text);
                if (user.Password != oldpassTextBox.Text)
                {
                    MessageBox.Show("Old Password Did Not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (newpassTextBox.Text != retypepassTextBox.Text)
                {
                    MessageBox.Show("New Password Did Not Match the Confirm Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    user.Password = newpassTextBox.Text.ToString();
                    userService.Update(user);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
