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
using SS_Desktop.Libraries.Context;
using SS_Desktop.Libraries.SignedIn;
using SS_Desktop.Models;

namespace SS_Desktop.Views
{
    public partial class ListView : UserControl
    {
        private int userType;
        private List<Item> items;
        public ListView()
        {
            InitializeComponent();
        }

        public void SetDataGridView(List<Item> list, List<Item> listOwner, int userType)
        {
            items = list;
            this.userType = userType;
            dgvTravelers.Rows.Clear();
            dgvOwners.Rows.Clear();

            foreach (var item in list)
            {
                dgvTravelers.Rows.Add(item.Title, item.Capacity, item.Area.Name, item.ItemType.Name);
            }

            foreach (var item in listOwner)
            {
                dgvOwners.Rows.Add(item.Title, item.Capacity, item.Area.Name, item.ItemType.Name, "Edit Details");
            }
        }

        private void OnTextChangeToSearch(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTxt.Text))
            {
                dgvTravelers.Rows.Clear();
                foreach (var item in items)
                {
                    if (item.Title.Contains(searchTxt.Text) || item.Area.Name.Contains(searchTxt.Text))
                    {
                        dgvTravelers.Rows.Add(item.Title, item.Capacity, item.Area.Name, item.ItemType.Name);
                    }
                }
            }
            else
            {
                dgvTravelers.Rows.Clear();
                foreach (var item in items)
                {
                    dgvTravelers.Rows.Add(item.Title, item.Capacity, item.Area.Name, item.ItemType.Name);
                }
            }

        }

        private void dgvOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                using (var context = new AppContextDb())
                {
                    var item = context.Items
                        .Include(i => i.Area)
                        .Include(i => i.ItemType)
                        .FirstOrDefault(i => i.Title == dgvOwners.Rows[e.RowIndex].Cells[0].Value.ToString());

                    Form form = this.Parent as Form;
                    if (form != null)
                    {
                        LoginView login = form as LoginView;
                        AddEditView addEdit = login.Controls.OfType<AddEditView>().FirstOrDefault();
                        addEdit?.SetAction(1); // Set action to Edit
                        addEdit?.SetNextBtnVisible(false); // Hide next button
                        addEdit?.SetCancelBtnVisible(false); // Hide cancel button
                        addEdit?.SetCloseBtnVisible(true); // Show close button
                        addEdit?.SetFinishBtnVisible(false); // Hide finish button
                        addEdit?.SetAttractions(item.Guid);
                        addEdit?.setAmenities(item.Guid);
                        addEdit?.SetEditFields(item);
                        addEdit.Visible = true;
                        this.Visible = false;
                    }
                }
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (userType > 1)
            //{
            //    e.Cancel = true;
            //}
        }

        private void OnClickToLogOut(object sender, EventArgs e)
        {
            this.Visible = false;
            UserSigned.SetUserSigned(null);
        }

        private void OnClickToAddItem(object sender, EventArgs e)
        {
            Form form = this.Parent as Form;
            if (form != null)
            {
                LoginView login = form as LoginView;
                AddEditView addEdit = login.Controls.OfType<AddEditView>().FirstOrDefault();
                addEdit?.SetAction(0); // Set action to Add
                addEdit?.SetNextBtnVisible(true); // Show next button
                addEdit?.SetCancelBtnVisible(true); // Show cancel button
                addEdit?.SetCloseBtnVisible(false); // Hide close button
                addEdit?.SetFinishBtnVisible(false); // Hide finish button
                addEdit?.SetAttractions(null);
                addEdit?.setAmenities(null);
                addEdit.Visible = true;
                this.Visible = false;
            }
        }
    }
}
