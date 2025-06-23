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
    public partial class AddEditView : UserControl
    {
        private List<ItemAttraction> itemAttractions1 = new List<ItemAttraction>();
        private List<ItemAmenity> itemAmenities1 = new List<ItemAmenity>();
        private Item item1 = new Item();
        private string title = "";
        private bool tabManager = false;
        private int viewAction = 0; // 0 = Add, 1 = Edit, 2 = View
        public AddEditView()
        {
            InitializeComponent();
            using (var context = new AppContextDb())
            {
                typeCb.DataSource = context.ItemTypes.Select(it => it.Name).ToList();
                areaCb.DataSource = context.Areas.Select(a => a.Name).ToList();
            }
        }

        public void SetEditFields(Item item)
        {
                            if (item != null)
                            {
                                titleTxt.Text = item.Title;
                                capacityNumber.Value = item.Capacity;
                                bedsNumber.Value = item.NumberOfBeds;
                                bedroomsNumber.Value = item.NumberOfBedrooms;
                                bathroomsNumber.Value = item.NumberOfBathrooms;
                                approxTxt.Text = item.ApproximateAddress;
                                exactTxt.Text = item.ExactAddress;
                                descTxt.Text = item.Description;
                                rulesTxt.Text = item.HostRules;
                                minimumNumber.Value = item.MinimumNights;
                                maximumNumber.Value = item.MaximumNights;
                                typeCb.SelectedIndex = (int)item.ItemTypeId - 1; // Assuming ItemTypeId starts from 1
                                areaCb.SelectedIndex = (int)item.AreaId - 1; // Assuming AreaId starts from 1
                            }
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void setAmenities(Guid? guid)
        {
            dgvAmenities.Rows.Clear();
            using (var context = new AppContextDb())
            {
                if(viewAction == 0)
                {
                    context.Amenities.ToList().ForEach(a =>
                    {
                        Image icon = Image.FromFile($"C:/Users/angel_mata/source/repos/SS_Desktop/SS_Desktop/Images/PNG/16px/{a.IconName}");
                        dgvAmenities.Rows.Add(icon, a.Name, false);
                    });
                }
                else
                {
                    var list = context.ItemAmenities.Include(a => a.Amenity).Include(a => a.Item).Where(a => a.Item.Guid == guid).ToList();
                    context.Amenities.ToList().ForEach(a =>
                    {
                        Image icon = Image.FromFile($"C:/Users/angel_mata/source/repos/SS_Desktop/SS_Desktop/Images/PNG/16px/{a.IconName}");
                        bool isInList = list.Any(item => item.AmenityId == a.Id);
                         dgvAmenities.Rows.Add(icon, a.Name, isInList);
                    });
                }
            }
        }

        public void SetAttractions(Guid? guid)
        {
            dgvAttractions.Rows.Clear();
            using (var context = new AppContextDb())
            {
                if (viewAction == 0)
                {
                    context.Attractions.Include(a => a.Area).ToList().ForEach(a =>
                    {
                        dgvAttractions.Rows.Add(a.Name, a.Area.Name, 0, 0, 0);
                    });
                }
                else
                {
                    var list = context.ItemAttractions.Include(a => a.Attraction).Include(a => a.Item).Where(a => a.Item.Guid == guid).ToList();
                    context.Attractions.Include(a => a.Area).ToList().ForEach(a =>
                    {
                        var item = list.FirstOrDefault(i => i.AttractionId == a.Id);
                        if (item != null)
                        {
                            dgvAttractions.Rows.Add(a.Name, a.Area.Name, item.Distance, item.DurationOnFoot, item.DurationByCar);
                        }
                        else
                        {
                            dgvAttractions.Rows.Add(a.Name, a.Area.Name, 0,0,0);
                        }
                    });
                }
            }
        }

        public void SetAction(int index)
        {
            viewAction = index;
        }

        public void SetFinishBtnVisible(bool value)
        {
            finishBtn.Visible = value;
        }

        public void SetCancelBtnVisible(bool value)
        {
            cancelBtn.Visible = value;
        }

        public void SetCloseBtnVisible(bool value)
        {
            closeBtn.Visible = value;
        }

        public void SetNextBtnVisible(bool value)
        {
            nextBtn.Visible = value;
        }

        private void OnSelectingToAction(object sender, TabControlCancelEventArgs e)
        {
            if (viewAction == 0)
            {
                if(e.TabPageIndex == 0 && !tabManager)
                {
                    e.Cancel = true;
                }else if (e.TabPageIndex == 1 && !tabManager)
                {
                    e.Cancel = true;
                }else if (e.TabPageIndex == 2 && !tabManager)
                {
                    e.Cancel = true;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Form form = this.Parent as Form;
            if (form != null)
            {
                LoginView login = form as LoginView;
                ListView list = login.Controls.OfType<ListView>().FirstOrDefault();
                var itemList = login.getItemList();
                var itemOwnerList = login.getItemListByUserId(UserSigned.GetUserSigned().Id);
                list.SetDataGridView(itemList, itemOwnerList, (int)UserSigned.GetUserSigned().UserTypeId);
                list.Visible = true;
                this.Visible = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (checkEmptyAndWrongFields())
            {
                Item item = SetItemValues();
                this.item1 = item;
                using (var context = new AppContextDb())
                {
                    item1.ItemType = context.ItemTypes.FirstOrDefault(it => it.Id == item1.ItemTypeId);
                    item1.Area = context.Areas.FirstOrDefault(it => it.Id == item1.AreaId);
                    item1.User = context.Users.FirstOrDefault(it => it.Id == item1.UserId);
                    var list = context.Items.FirstOrDefault(i => i.Title.Equals(title));
                    if (list != null)
                    {
                        item1.Guid = list.Guid;
                        item1.Id = list.Id; // Set the Id to the existing item's Id
                    }
                }

                List<ItemAmenity> itemAmenities = new List<ItemAmenity>();
                foreach (DataGridViewRow row in dgvAmenities.Rows)
                {
                    bool check = (bool)row.Cells[2].Value;
                    if (check)
                    {
                        ItemAmenity itemAmenity = new ItemAmenity()
                        {
                            ItemId = 0, // This will be set later when the item is saved
                            AmenityId = row.Index + 1
                        };
                        itemAmenities.Add(itemAmenity);
                    }
                }
                this.itemAmenities1 = itemAmenities;

                List<ItemAttraction> itemAttractions = new List<ItemAttraction>();
                foreach (DataGridViewRow row in dgvAttractions.Rows)
                {
                    if (Decimal.Parse(row.Cells[2].Value.ToString()) > 0)
                    {
                        ItemAttraction itemAttraction = new ItemAttraction()
                        {
                            AttractionId = row.Index + 1, // Assuming AttractionId starts from 1 
                            ItemId = 0, // This will be set later when the item is saved
                            Distance = Decimal.Parse(row.Cells[2].Value.ToString()),
                            DurationOnFoot = (row.Cells[3].Value.ToString() != "0") ? (Int64)row.Cells[3].Value : 0,
                            DurationByCar = (row.Cells[4].Value.ToString() != "0") ? (Int64)row.Cells[4].Value : 0,
                        };
                        itemAttractions.Add(itemAttraction);
                    }
                }
                this.itemAttractions1 = itemAttractions;

                using (var context = new AppContextDb())
                {
                    if (itemAttractions1.Count >= 2)
                    {
                        context.Entry(item1).State = EntityState.Modified; // Update the existing item
                        context.SaveChanges(); // Save the item first to get the ItemId

                        this.item1 = context.Items.FirstOrDefault(i => i.Id == item1.Id);
                        if (itemAttractions1 != null && itemAttractions1.Count > 0 && item1.Id > 0)
                        {
                            foreach (var attraction in itemAttractions1)
                            {
                                attraction.ItemId = item1.Id; // Set the ItemId for each attraction
                                attraction.Item = item1;
                            }
                            foreach (var amenity in itemAmenities1)
                            {
                                amenity.ItemId = item1.Id; // Set the ItemId for each amenity
                                amenity.Item = item1;
                            }
                            context.ItemAmenities.UpdateRange(itemAmenities1); // Ensure the item amenities is updated
                            context.ItemAttractions.UpdateRange(itemAttractions1); // Ensure the item attractions is updated
                            context.SaveChanges(); // Save the attractions and amenities

                            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form form = this.Parent as Form;
                            if (form != null)
                            {
                                LoginView login = form as LoginView;
                                ListView listView = login.Controls.OfType<ListView>().FirstOrDefault();
                                var list = login.getItemList();
                                var ownerList = login.getItemListByUserId(UserSigned.GetUserSigned().Id);
                                var numId = UserSigned.GetUserSigned().UserTypeId;
                                listView.SetDataGridView(list, ownerList, (numId == 1)?1:2);
                                listView.Visible = true;
                                this.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("At least 2 distances to diferent attractions need to be filled", "Attractions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            List<ItemAttraction> itemAttractions = new List<ItemAttraction>();
            foreach (DataGridViewRow row in dgvAttractions.Rows)
            {
                ItemAttraction itemAttraction;
                if (Decimal.Parse(row.Cells[2].Value.ToString()) > 0)
                {
                    using (var context = new AppContextDb())
                    {
                        itemAttraction = new ItemAttraction()
                        {
                            AttractionId = context.Attractions.FirstOrDefault(a => a.Name == row.Cells[0].Value.ToString()).Id,
                            ItemId = 0, // This will be set later when the item is saved
                            Distance = Decimal.Parse(row.Cells[2].Value.ToString()),
                            DurationOnFoot = (row.Cells[3].Value.ToString() != "0") ? (Int64)row.Cells[3].Value : 0,
                            DurationByCar = (row.Cells[4].Value.ToString() != "0") ? (Int64)row.Cells[4].Value : 0,
                        };
                    }
                    itemAttractions.Add(itemAttraction);
                }
            }
            this.itemAttractions1 = itemAttractions;

            using (var context = new AppContextDb())
            {
                if (itemAttractions1.Count >= 2)
                {
                    item1.ItemType = context.ItemTypes.FirstOrDefault(it => it.Id == item1.ItemTypeId);
                    item1.Area = context.Areas.FirstOrDefault(it => it.Id == item1.AreaId);
                    item1.User = context.Users.FirstOrDefault(it => it.Id == item1.UserId);

                    context.Items.Add(item1);
                    context.SaveChanges(); // Save the item first to get the ItemId

                    this.item1 = context.Items.FirstOrDefault(i => i.Guid == item1.Guid);
                    if (item1.Id > 0)
                    {
                        foreach (var attraction in itemAttractions1)
                        {
                            attraction.ItemId = item1.Id; // Set the ItemId for each attraction
                            attraction.Item = item1;
                            attraction.Attraction = context.Attractions.FirstOrDefault(a => a.Id == attraction.AttractionId); // Ensure the attraction is loaded
                        }
                        foreach (var amenity in itemAmenities1)
                        {
                            amenity.ItemId = item1.Id; // Set the ItemId for each amenity
                            amenity.Item = item1;
                            amenity.Amenity = context.Amenities.FirstOrDefault(a => a.Id == amenity.AmenityId); // Ensure the amenity is loaded
                        }
                        context.ItemAmenities.AddRange(itemAmenities1);
                        context.ItemAttractions.AddRange(itemAttractions1);
                        context.SaveChanges(); // Save the attractions and amenities

                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form form = this.Parent as Form;
                        if (form != null)
                        {
                            LoginView login = form as LoginView;
                            ListView listView = login.Controls.OfType<ListView>().FirstOrDefault();
                            var list = login.getItemList();
                            var ownerList = login.getItemListByUserId(UserSigned.GetUserSigned().Id);
                            var numId = UserSigned.GetUserSigned().UserTypeId;
                            listView.SetDataGridView(list, ownerList, (numId == 1) ? 1 : 2);
                            listView.Visible = true;
                            this.Visible = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("At least 2 distances to diferent attractions need to be filled", "Attractions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool checkEmptyAndWrongFields()
        {
            // Check if any required fields are empty or have invalid values
            if (string.IsNullOrEmpty(titleTxt.Text) || string.IsNullOrEmpty(approxTxt.Text) || string.IsNullOrEmpty(exactTxt.Text) || string.IsNullOrEmpty(descTxt.Text) || string.IsNullOrEmpty(rulesTxt.Text)) 
            {
                MessageBox.Show("Please fill in all required fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (capacityNumber.Value <= 0)
            {
                MessageBox.Show("Capacity must be greater than 0.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (bedsNumber.Value <= 0)
            {
                MessageBox.Show("Beds number must be greater than 0.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (bedroomsNumber.Value <= 0)
            {
                MessageBox.Show("Bedrooms number must be greater than 0.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (bathroomsNumber.Value <= 0)
            {
                MessageBox.Show("Bathrooms number must be greater than 0.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (minimumNumber.Value <= 0)
            {
                MessageBox.Show("minimum nights must be greater than 0.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (maximumNumber.Value <= 0)
            {
                MessageBox.Show("maximum nights must be greater than 0.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (maximumNumber.Value <= minimumNumber.Value)
            {
                MessageBox.Show("maximum nights must be greater than minimum nights.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true; // Return true if there are errors, false otherwise
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 0)
            {
                if (checkEmptyAndWrongFields())
                {
                    Item item = SetItemValues();
                    this.item1 = item;
                    this.tabManager = true;
                    tabControl.SelectedIndex = 1; // Move to the next tab if all fields are valid
                    this.tabManager = false;
                }
            }
            else if (tabControl.SelectedIndex == 1)
            {
                List<ItemAmenity> itemAmenities = new List<ItemAmenity>();
                foreach (DataGridViewRow row in dgvAmenities.Rows)
                {
                    bool check = (bool)row.Cells[2].Value;
                    ItemAmenity itemAmenity;
                    if (check)
                    {
                        using (var context = new AppContextDb())
                        {
                            itemAmenity = new ItemAmenity()
                            {
                                ItemId = 0, // This will be set later when the item is saved
                                AmenityId = context.Amenities.FirstOrDefault(a => a.Name == row.Cells[2].Value.ToString()).Id
                            };
                        }
                        itemAmenities.Add(itemAmenity);
                    }
                }
                this.itemAmenities1 = itemAmenities;
                this.tabManager = true;
                tabControl.SelectedIndex = 2;
                this.tabManager = false;
                SetCancelBtnVisible(false);
                SetFinishBtnVisible(true);
                nextBtn.Enabled = false; // Disable the button to prevent multiple clicks
            }
        }

        private Item SetItemValues()
        {
            return new Item()
            {
                UserId = (Int64)UserSigned.GetUserSigned().Id,
                ItemTypeId = (Int64)(typeCb.SelectedIndex + 1),
                AreaId = (Int64)areaCb.SelectedIndex + 1,
                Title = titleTxt.Text,
                Capacity = (int)capacityNumber.Value,
                NumberOfBeds = (int)bedsNumber.Value,
                NumberOfBedrooms = (int)bedroomsNumber.Value,
                NumberOfBathrooms = (int)bathroomsNumber.Value,
                ApproximateAddress = approxTxt.Text,
                ExactAddress = exactTxt.Text,
                Description = descTxt.Text,
                HostRules = rulesTxt.Text,
                MinimumNights = (int)minimumNumber.Value,
                MaximumNights = (int)maximumNumber.Value
            };
        }
    }
}
