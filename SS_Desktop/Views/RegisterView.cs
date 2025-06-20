using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SS_Desktop.Libraries.Context;
using SS_Desktop.Models;

namespace SS_Desktop.Views
{
    public partial class RegisterView : UserControl
    {
        private int terms = 0;
        public RegisterView()
        {
            InitializeComponent();
        }

        private void termsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            terms++;
            Form form = this.Parent as Form;
            if (form != null)
            {
                LoginView login = form as LoginView;
                TermsView termsView = login.Controls.OfType<TermsView>().FirstOrDefault();
                this.Enabled = false;
                termsView.BringToFront();
                termsView.Visible = true;
            }
        }

        private bool IsFieldEmptyOrBadWrited()
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text) || string.IsNullOrWhiteSpace(userTxt.Text) ||
                string.IsNullOrWhiteSpace(pswdTxt.Text) || string.IsNullOrWhiteSpace(rePswdTxt.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (pswdTxt.Text != rePswdTxt.Text)
            {
                MessageBox.Show("Passwords do not match.", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (datePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth cannot be in the future.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (datePicker.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("You must be at least 18 years old to register.", "Age restriction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (members.Value <= 0)
            {
                MessageBox.Show("Please select a valid number of members.", "Invalid members", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!maleRb.Checked && !femaleRb.Checked)
            {
                MessageBox.Show("Please select a gender.", "Select a gender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!termsCb.Checked || terms == 0)
            {
                MessageBox.Show("You must read at least once and accept the terms and conditions to register.", "Terms not accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form form = this.Parent as Form;
            //if (form != null)
            //{
            //    LoginView login = form as LoginView;
            //    login.Visible
            //}

            this.Visible = false;
        }

        private void OnClickToRegisterAndLogin(object sender, EventArgs e)
        {
            var response = IsFieldEmptyOrBadWrited();
            if (response)
            {
                using (var context = new AppContextDb())
                {
                    context.Users.Add(SetUser());
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false; // Hide the RegisterView after successful registration
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while registering: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private User SetUser()
        {
            User user = new User()
            {
                UserName = userTxt.Text,
                Password = pswdTxt.Text,
                FullName = nameTxt.Text,
                BirthDate = new DateOnly(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day),
                FamilyCount = (int)members.Value,
                Gender = maleRb.Checked ? true : false,
                UserTypeId = 2, // Assuming 2 is the UserTypeId for regular users
            };

            return user;
        }
    }
}
