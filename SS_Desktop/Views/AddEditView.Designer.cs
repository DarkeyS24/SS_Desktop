namespace SS_Desktop.Views
{
    partial class AddEditView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            details = new TabPage();
            label16 = new Label();
            areaCb = new ComboBox();
            descTxt = new RichTextBox();
            rulesTxt = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bedsNumber = new NumericUpDown();
            bedroomsNumber = new NumericUpDown();
            bathroomsNumber = new NumericUpDown();
            maximumNumber = new NumericUpDown();
            minimumNumber = new NumericUpDown();
            capacityNumber = new NumericUpDown();
            typeCb = new ComboBox();
            exactTxt = new RichTextBox();
            approxTxt = new TextBox();
            titleTxt = new TextBox();
            amenity = new TabPage();
            label14 = new Label();
            dgvAmenities = new DataGridView();
            amenityImage = new DataGridViewImageColumn();
            amenityColumn = new DataGridViewTextBoxColumn();
            checboxColumn = new DataGridViewCheckBoxColumn();
            distance = new TabPage();
            label15 = new Label();
            dgvAttractions = new DataGridView();
            attraction = new DataGridViewTextBoxColumn();
            area = new DataGridViewTextBoxColumn();
            distanceColumn = new DataGridViewTextBoxColumn();
            onFoot = new DataGridViewTextBoxColumn();
            byCar = new DataGridViewTextBoxColumn();
            closeBtn = new Button();
            nextBtn = new Button();
            finishBtn = new Button();
            amenityBindingSource = new BindingSource(components);
            cancelBtn = new Button();
            tabControl.SuspendLayout();
            details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bedsNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bedroomsNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bathroomsNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximumNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimumNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capacityNumber).BeginInit();
            amenity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmenities).BeginInit();
            distance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttractions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amenityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(details);
            tabControl.Controls.Add(amenity);
            tabControl.Controls.Add(distance);
            tabControl.Location = new Point(20, 20);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(915, 511);
            tabControl.TabIndex = 0;
            tabControl.Selecting += OnSelectingToAction;
            // 
            // details
            // 
            details.BackColor = Color.FromArgb(187, 187, 187);
            details.BorderStyle = BorderStyle.FixedSingle;
            details.Controls.Add(label16);
            details.Controls.Add(areaCb);
            details.Controls.Add(descTxt);
            details.Controls.Add(rulesTxt);
            details.Controls.Add(label13);
            details.Controls.Add(label12);
            details.Controls.Add(label11);
            details.Controls.Add(label10);
            details.Controls.Add(label9);
            details.Controls.Add(label8);
            details.Controls.Add(label7);
            details.Controls.Add(label6);
            details.Controls.Add(label5);
            details.Controls.Add(label4);
            details.Controls.Add(label3);
            details.Controls.Add(label2);
            details.Controls.Add(label1);
            details.Controls.Add(bedsNumber);
            details.Controls.Add(bedroomsNumber);
            details.Controls.Add(bathroomsNumber);
            details.Controls.Add(maximumNumber);
            details.Controls.Add(minimumNumber);
            details.Controls.Add(capacityNumber);
            details.Controls.Add(typeCb);
            details.Controls.Add(exactTxt);
            details.Controls.Add(approxTxt);
            details.Controls.Add(titleTxt);
            details.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            details.Location = new Point(4, 29);
            details.Name = "details";
            details.Size = new Size(907, 478);
            details.TabIndex = 0;
            details.Text = "Listing Details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(632, 22);
            label16.Name = "label16";
            label16.Size = new Size(69, 33);
            label16.TabIndex = 27;
            label16.Text = "Area";
            // 
            // areaCb
            // 
            areaCb.FormattingEnabled = true;
            areaCb.Location = new Point(705, 19);
            areaCb.Name = "areaCb";
            areaCb.Size = new Size(188, 41);
            areaCb.TabIndex = 26;
            // 
            // descTxt
            // 
            descTxt.BorderStyle = BorderStyle.FixedSingle;
            descTxt.Location = new Point(298, 286);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(595, 63);
            descTxt.TabIndex = 25;
            descTxt.Text = "";
            // 
            // rulesTxt
            // 
            rulesTxt.BorderStyle = BorderStyle.FixedSingle;
            rulesTxt.Location = new Point(298, 355);
            rulesTxt.Name = "rulesTxt";
            rulesTxt.Size = new Size(595, 63);
            rulesTxt.TabIndex = 24;
            rulesTxt.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 288);
            label13.Name = "label13";
            label13.Size = new Size(147, 33);
            label13.TabIndex = 23;
            label13.Text = "Description";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 22);
            label12.Name = "label12";
            label12.Size = new Size(70, 33);
            label12.TabIndex = 22;
            label12.Text = "Type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(319, 22);
            label11.Name = "label11";
            label11.Size = new Size(66, 33);
            label11.TabIndex = 21;
            label11.Text = "Title";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 219);
            label10.Name = "label10";
            label10.Size = new Size(175, 33);
            label10.TabIndex = 20;
            label10.Text = "Exact Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 164);
            label9.Name = "label9";
            label9.Size = new Size(264, 33);
            label9.TabIndex = 19;
            label9.Text = "Approximate Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 93);
            label8.Name = "label8";
            label8.Size = new Size(70, 33);
            label8.TabIndex = 18;
            label8.Text = "Beds";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 91);
            label7.Name = "label7";
            label7.Size = new Size(131, 33);
            label7.TabIndex = 17;
            label7.Text = "Bedrooms";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(672, 91);
            label6.Name = "label6";
            label6.Size = new Size(141, 33);
            label6.TabIndex = 16;
            label6.Text = "Bathrooms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 432);
            label5.Name = "label5";
            label5.Size = new Size(127, 33);
            label5.TabIndex = 15;
            label5.Text = "Minimum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 432);
            label4.Name = "label4";
            label4.Size = new Size(132, 33);
            label4.TabIndex = 14;
            label4.Text = "Maximum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 430);
            label3.Name = "label3";
            label3.Size = new Size(312, 33);
            label3.TabIndex = 13;
            label3.Text = "Reservation Time (Nights)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 357);
            label2.Name = "label2";
            label2.Size = new Size(136, 33);
            label2.TabIndex = 12;
            label2.Text = "Host Rules";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 91);
            label1.Name = "label1";
            label1.Size = new Size(115, 33);
            label1.TabIndex = 11;
            label1.Text = "Capacity";
            // 
            // bedsNumber
            // 
            bedsNumber.Location = new Point(331, 89);
            bedsNumber.Name = "bedsNumber";
            bedsNumber.Size = new Size(74, 39);
            bedsNumber.TabIndex = 10;
            // 
            // bedroomsNumber
            // 
            bedroomsNumber.Location = new Point(573, 89);
            bedroomsNumber.Name = "bedroomsNumber";
            bedroomsNumber.Size = new Size(74, 39);
            bedroomsNumber.TabIndex = 9;
            // 
            // bathroomsNumber
            // 
            bathroomsNumber.Location = new Point(819, 89);
            bathroomsNumber.Name = "bathroomsNumber";
            bathroomsNumber.Size = new Size(74, 39);
            bathroomsNumber.TabIndex = 8;
            // 
            // maximumNumber
            // 
            maximumNumber.Location = new Point(782, 430);
            maximumNumber.Maximum = new decimal(new int[] { 10001, 0, 0, 0 });
            maximumNumber.Name = "maximumNumber";
            maximumNumber.Size = new Size(74, 39);
            maximumNumber.TabIndex = 7;
            // 
            // minimumNumber
            // 
            minimumNumber.Location = new Point(507, 430);
            minimumNumber.Maximum = new decimal(new int[] { 10001, 0, 0, 0 });
            minimumNumber.Name = "minimumNumber";
            minimumNumber.Size = new Size(74, 39);
            minimumNumber.TabIndex = 6;
            // 
            // capacityNumber
            // 
            capacityNumber.Location = new Point(149, 89);
            capacityNumber.Maximum = new decimal(new int[] { 10001, 0, 0, 0 });
            capacityNumber.Name = "capacityNumber";
            capacityNumber.Size = new Size(74, 39);
            capacityNumber.TabIndex = 5;
            // 
            // typeCb
            // 
            typeCb.FormattingEnabled = true;
            typeCb.Location = new Point(101, 19);
            typeCb.Name = "typeCb";
            typeCb.Size = new Size(188, 41);
            typeCb.TabIndex = 4;
            // 
            // exactTxt
            // 
            exactTxt.BorderStyle = BorderStyle.FixedSingle;
            exactTxt.Location = new Point(298, 217);
            exactTxt.Name = "exactTxt";
            exactTxt.Size = new Size(595, 63);
            exactTxt.TabIndex = 2;
            exactTxt.Text = "";
            // 
            // approxTxt
            // 
            approxTxt.BorderStyle = BorderStyle.FixedSingle;
            approxTxt.Location = new Point(298, 162);
            approxTxt.Name = "approxTxt";
            approxTxt.Size = new Size(595, 39);
            approxTxt.TabIndex = 1;
            // 
            // titleTxt
            // 
            titleTxt.BorderStyle = BorderStyle.FixedSingle;
            titleTxt.Location = new Point(391, 20);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(219, 39);
            titleTxt.TabIndex = 0;
            // 
            // amenity
            // 
            amenity.BackColor = Color.FromArgb(187, 187, 187);
            amenity.Controls.Add(label14);
            amenity.Controls.Add(dgvAmenities);
            amenity.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amenity.Location = new Point(4, 29);
            amenity.Name = "amenity";
            amenity.Size = new Size(907, 478);
            amenity.TabIndex = 1;
            amenity.Text = "Amenities";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 17);
            label14.Name = "label14";
            label14.Size = new Size(341, 33);
            label14.TabIndex = 1;
            label14.Text = "Choose Available Amenities:";
            // 
            // dgvAmenities
            // 
            dgvAmenities.AllowUserToAddRows = false;
            dgvAmenities.AllowUserToDeleteRows = false;
            dgvAmenities.BackgroundColor = Color.White;
            dgvAmenities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmenities.Columns.AddRange(new DataGridViewColumn[] { amenityImage, amenityColumn, checboxColumn });
            dgvAmenities.Location = new Point(20, 68);
            dgvAmenities.Name = "dgvAmenities";
            dgvAmenities.RowHeadersVisible = false;
            dgvAmenities.RowHeadersWidth = 51;
            dgvAmenities.Size = new Size(528, 384);
            dgvAmenities.TabIndex = 0;
            // 
            // amenityImage
            // 
            amenityImage.HeaderText = "";
            amenityImage.MinimumWidth = 6;
            amenityImage.Name = "amenityImage";
            amenityImage.Width = 50;
            // 
            // amenityColumn
            // 
            amenityColumn.HeaderText = "Amenity";
            amenityColumn.MinimumWidth = 6;
            amenityColumn.Name = "amenityColumn";
            amenityColumn.Width = 350;
            // 
            // checboxColumn
            // 
            checboxColumn.HeaderText = "";
            checboxColumn.MinimumWidth = 6;
            checboxColumn.Name = "checboxColumn";
            checboxColumn.Width = 125;
            // 
            // distance
            // 
            distance.BackColor = Color.FromArgb(187, 187, 187);
            distance.Controls.Add(label15);
            distance.Controls.Add(dgvAttractions);
            distance.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            distance.Location = new Point(4, 29);
            distance.Name = "distance";
            distance.Size = new Size(907, 478);
            distance.TabIndex = 2;
            distance.Text = "Distance to Attraction";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 17);
            label15.Name = "label15";
            label15.Size = new Size(341, 33);
            label15.TabIndex = 3;
            label15.Text = "Choose Available Amenities:";
            // 
            // dgvAttractions
            // 
            dgvAttractions.AllowUserToAddRows = false;
            dgvAttractions.AllowUserToDeleteRows = false;
            dgvAttractions.BackgroundColor = Color.White;
            dgvAttractions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttractions.Columns.AddRange(new DataGridViewColumn[] { attraction, area, distanceColumn, onFoot, byCar });
            dgvAttractions.Location = new Point(20, 68);
            dgvAttractions.Name = "dgvAttractions";
            dgvAttractions.RowHeadersVisible = false;
            dgvAttractions.RowHeadersWidth = 51;
            dgvAttractions.Size = new Size(869, 390);
            dgvAttractions.TabIndex = 2;
            // 
            // attraction
            // 
            attraction.HeaderText = "Attraction";
            attraction.MinimumWidth = 6;
            attraction.Name = "attraction";
            attraction.Width = 245;
            // 
            // area
            // 
            area.HeaderText = "Area";
            area.MinimumWidth = 6;
            area.Name = "area";
            area.Width = 245;
            // 
            // distanceColumn
            // 
            distanceColumn.HeaderText = "Distance (Km)";
            distanceColumn.MinimumWidth = 6;
            distanceColumn.Name = "distanceColumn";
            distanceColumn.Width = 125;
            // 
            // onFoot
            // 
            onFoot.HeaderText = "On Foot (minutes)";
            onFoot.MinimumWidth = 6;
            onFoot.Name = "onFoot";
            onFoot.Width = 125;
            // 
            // byCar
            // 
            byCar.HeaderText = "By Car (minutes)";
            byCar.MinimumWidth = 6;
            byCar.Name = "byCar";
            byCar.Width = 125;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(187, 187, 187);
            closeBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(797, 544);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(134, 44);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.FromArgb(187, 187, 187);
            nextBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(657, 544);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(134, 44);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // finishBtn
            // 
            finishBtn.BackColor = Color.FromArgb(187, 187, 187);
            finishBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishBtn.ForeColor = Color.White;
            finishBtn.Location = new Point(797, 544);
            finishBtn.Name = "finishBtn";
            finishBtn.Size = new Size(134, 44);
            finishBtn.TabIndex = 3;
            finishBtn.Text = "Finish";
            finishBtn.UseVisualStyleBackColor = false;
            finishBtn.Click += finishBtn_Click;
            // 
            // amenityBindingSource
            // 
            amenityBindingSource.DataSource = typeof(Models.Amenity);
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(229, 26, 46);
            cancelBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(797, 544);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(134, 44);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cancelBtn);
            Controls.Add(nextBtn);
            Controls.Add(tabControl);
            Controls.Add(finishBtn);
            Controls.Add(closeBtn);
            Name = "AddEditView";
            Size = new Size(955, 604);
            tabControl.ResumeLayout(false);
            details.ResumeLayout(false);
            details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bedsNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)bedroomsNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)bathroomsNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximumNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimumNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)capacityNumber).EndInit();
            amenity.ResumeLayout(false);
            amenity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmenities).EndInit();
            distance.ResumeLayout(false);
            distance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttractions).EndInit();
            ((System.ComponentModel.ISupportInitialize)amenityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private Button closeBtn;
        private Button nextBtn;
        private Button finishBtn;
        private TabPage details;
        private TabPage amenity;
        private TabPage distance;
        private RichTextBox exactTxt;
        private TextBox approxTxt;
        private TextBox titleTxt;
        private RichTextBox descTxt;
        private RichTextBox rulesTxt;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown bedsNumber;
        private NumericUpDown bedroomsNumber;
        private NumericUpDown bathroomsNumber;
        private NumericUpDown maximumNumber;
        private NumericUpDown minimumNumber;
        private NumericUpDown capacityNumber;
        private ComboBox typeCb;
        private Label label14;
        private DataGridView dgvAmenities;
        private BindingSource amenityBindingSource;
        private Label label15;
        private DataGridView dgvAttractions;
        private DataGridViewTextBoxColumn attraction;
        private DataGridViewTextBoxColumn area;
        private DataGridViewTextBoxColumn distanceColumn;
        private DataGridViewTextBoxColumn onFoot;
        private DataGridViewTextBoxColumn byCar;
        private Button cancelBtn;
        private DataGridViewImageColumn amenityImage;
        private DataGridViewTextBoxColumn amenityColumn;
        private DataGridViewCheckBoxColumn checboxColumn;
        private Label label16;
        private ComboBox areaCb;
    }
}
