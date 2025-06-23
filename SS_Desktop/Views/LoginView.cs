using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SS_Desktop.Libraries.BoolSignedIn;
using SS_Desktop.Libraries.Context;
using SS_Desktop.Libraries.SignedIn;
using SS_Desktop.Models;

namespace SS_Desktop.Views
{
    public partial class LoginView : Form
    {
        private List<Item> items;
        private int signed;
        public LoginView()
        {
            InitializeComponent();
            if (BoolUserSigned.GetUserSigned() != null && BoolUserSigned.GetUserSigned() == 1)
            {
                var user = UserSigned.GetUserSigned();
                if (user != null)
                {
                    ListView list = this.Controls.OfType<ListView>().FirstOrDefault();
                    if (list != null)
                    {
                        list.SetDataGridView(getItemList(), getItemListByUserId(user.Id), (int)user.UserTypeId);
                        list.Visible = true; // Show the ListView if it exists
                    }
                }
            }
        }

        private void showCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                pswdTxt.UseSystemPasswordChar = false;
                pswdTxt.PasswordChar = '\0'; // Clear the password character
            }
            else
            {
                pswdTxt.UseSystemPasswordChar = true;
                pswdTxt.PasswordChar = '*'; // Set the password character back to '*'
            }
        }

        private void signedCb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            signed = check.Checked ? 1 : 0; // Set signed to 1 if checked, otherwise 0
            BoolUserSigned.SetUserSigned(signed);
        }

        private void createLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterView registerView = this.Controls.OfType<RegisterView>().FirstOrDefault();
            if (registerView != null)
            {
                registerView.Visible = true; // Show the RegisterView
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        public List<Item> getItemList()
        {
            using (var context = new AppContextDb())
            {
                var list = context.Items.Include(i => i.ItemType).Include(i => i.Area).ToList();
                items = list;
                return list;
            }
        }

        public List<Item> getItemListByUserId(Int64 userId)
        {
            using (var context = new AppContextDb())
            {
                var list = context.Items.Include(i => i.ItemType).Include(i => i.Area).Where(i => i.UserId == userId).ToList();
                return list;
            }
        }

        private void Login()
        {
            using (var context = new AppContextDb())
            {
                if (string.IsNullOrEmpty(userTxt.Text) && !string.IsNullOrEmpty(pswdTxt.Text))
                {
                    var user = context.Users.FirstOrDefault(u => u.UserName.Equals(empTxt.Text) && u.Password.Equals(pswdTxt.Text) && u.UserTypeId == 1);
                    UserSigned.SetUserSigned(user);
                    if (user != null)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListView list = this.Controls.OfType<ListView>().FirstOrDefault();
                        if (list != null)
                        {
                            list.SetDataGridView(getItemList(), getItemListByUserId(user.Id), 1);
                            list.Visible = true; // Show the ListView if it exists
                            SetLoginFieldsEmpty();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (string.IsNullOrEmpty(empTxt.Text) && !string.IsNullOrEmpty(pswdTxt.Text))
                {
                    var user = context.Users.FirstOrDefault(u => u.UserName.Equals(userTxt.Text) && u.Password.Equals(pswdTxt.Text) && u.UserTypeId == 2);
                    UserSigned.SetUserSigned(user);
                    if (user != null)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListView list = this.Controls.OfType<ListView>().FirstOrDefault();
                        if (list != null)
                        {
                            list.SetDataGridView(getItemList(), getItemListByUserId(user.Id), 2);
                            list.Visible = true; // Show the ListView if it exists
                            SetLoginFieldsEmpty();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void SetLoginFieldsEmpty()
        {
            empTxt.Text = "";
            userTxt.Text = "";
            pswdTxt.Text = "";
            showCb.Checked = false;
        }

        private void OnKeyPressedToList(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Login();
            }
        }
    }
}
