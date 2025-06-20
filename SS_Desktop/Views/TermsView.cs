using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_Desktop.Views
{
    public partial class TermsView : UserControl
    {
        public TermsView()
        {
            InitializeComponent();
        }

        private void TermsView_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Last Updated: February 10, 2022\r\n\r\nThank you for using Stay Seoul!\r\n\r\nThese Terms of Service (“Terms”) are a binding legal agreement between you and Stay Seoul that govern your right to use the websites, applications, and other offerings from Stay Seoul (collectively, the “Stay Seoul Platform”).\r\n When used in these Terms, “Stay Seoul,” “we,” “us,” or “our” refers to the Stay Seoul entity set out on Schedule 1 with whom you are contracting.\r\n\r\nThe Stay Seoul Platform offers an online venue that enables users (“Members”) to publish, offer, search for, and book services.\r\n Members who publish and offer services are “Hosts” and Members who search for, book, or use services are “Guests.” Hosts offer accommodations (“Accommodations”), activities, excursions, and events (“Experiences”), and a variety of travel and other services (collectively, “Host Services,” and each Host Service offering, a “Listing”).\r\n You must register an account to access and use many features of the Stay Seoul Platform, and must keep your account information accurate.\r\nAs the provider of the Stay Seoul Platform, Stay Seoul does not own, control, offer or manage any Listings or Host Services.\r\nStay Seoul is not a party to the contracts entered into directly between Hosts and Guests, nor is Stay Seoul a real estate broker, travel agency, or insurer.\r\nStay Seoul is not acting as an agent in any capacity for any Member, except as specified in the Payments Terms of Service (“Payment Terms”). \r\nWe maintain other terms and policies that supplement these Terms like our Privacy Policy, which describes our collection and use of personal data, and our Payments Terms, which govern any payment services provided to Members by the Stay Seoul payment entities (collectively \"Stay Seoul Payments\").\r\n\r\nIf you are a Host, you are responsible for understanding and complying with all laws, rules, regulations and contracts with third parties that apply to your Host Services.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = this.Parent as Form;
            if (form != null)
            {
                LoginView login = form as LoginView;
                RegisterView registerView = login.Controls.OfType<RegisterView>().FirstOrDefault();
                registerView.Enabled = true;
                this.Visible = false; // Hide the TermsView
            }
        }
    }
}
