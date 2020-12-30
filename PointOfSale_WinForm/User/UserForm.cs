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
using u=POS_DataModel.Entities;
namespace PointOfSale_WinForm.User
{
    public partial class UserForm : Form
    {
        private readonly UserService userService = new UserService();
        MainForm _mainForm;
     
        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void clear()
        {
            usernameTextBox.Clear();
            passTextBox.Clear();
            retypPassTextBox.Clear();
            roleComboBox.Text = "";
            nameTextBox.Clear();
            availLabel.Visible = false;
            usernameTextBox.Focus();
            
            
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) && String.IsNullOrEmpty(usernameTextBox.Text) && String.IsNullOrEmpty(passTextBox.Text))
            {
                MessageBox.Show("Please Fill up All the Fields");
                return;
            }
            if (roleComboBox.Text=="" || roleComboBox.Text==null)
            {
                MessageBox.Show("Please Select a Role");
                return;
            }
            if (passTextBox.Text != retypPassTextBox.Text)
            {
                MessageBox.Show("Password did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var user = new u.User
                {
                    Username= usernameTextBox.Text,
                    Password= passTextBox.Text,
                    Role=roleComboBox.Text,
                    Name= nameTextBox.Text,
                    IsActive=true
                };
                userService.Insert(user);
                MessageBox.Show("New account has saved!");
                clear();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void checkAvailButton_Click(object sender, EventArgs e)
        {
            var isExist = userService.IsExist(usernameTextBox.Text);
            if (isExist != false)
            {
                MessageBox.Show("This Username is already taken!", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                usernameTextBox.Focus();
            }
            else
            {
                availLabel.Visible = true;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            availLabel.Visible = false;
        }

        private void savePassChhangebutton_Click(object sender, EventArgs e)
        {
            try
            {

                var user = userService.GetUser(usertextBox.Text);
                if (user.Password != oldtextBox.Text)
                {
                    MessageBox.Show("Old Password Is Incorrect.Please Try Again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (newtextBox.Text != retypetextBox.Text)
                {
                    MessageBox.Show("The new password didnot match the retyped password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                user.Password = newtextBox.Text.ToString();
                userService.Update(user);
                MessageBox.Show("Password Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldtextBox.Clear();
                newtextBox.Clear();
                retypetextBox.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelPassChangeButton_Click(object sender, EventArgs e)
        {
            oldtextBox.Clear();
            newtextBox.Clear();
            retypetextBox.Clear();
        }

      
        private void activateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usersTextBox.Text))
                {
                    MessageBox.Show("Please Give A Valid Username");
                    return;
                }
               
                var user = userService.GetById(int.Parse(userIdlabel.Text));
                if (user != null)
                {
                    user.IsActive = activeCheckBox.Checked;
                    userService.Update(user);
                    MessageBox.Show("Account Has Been Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usersTextBox.Clear();
                    activeCheckBox.Checked = false;
                    userIdlabel.Text = "";
                }
                else
                {
                    MessageBox.Show("No Such User Found.", "Not Found.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var user = userService.GetUser(usersTextBox.Text);
                if (user != null)
                {
                    activeCheckBox.Checked = user.IsActive;
                    userIdlabel.Text = user.Id.ToString();
                }
                else
                {
                    activeCheckBox.Checked = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserForm_Resize(object sender, EventArgs e)
        {
            userTabControl.Left = (this.Width - userTabControl.Width) / 2;
            userTabControl.Top = (this.Height - userTabControl.Height) / 2;
        }

        private void roleComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
