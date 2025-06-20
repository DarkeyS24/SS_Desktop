namespace SS_Desktop.Views
{
    partial class ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            tabControl = new TabControl();
            travelers = new TabPage();
            pictureBox1 = new PictureBox();
            searchTxt = new TextBox();
            dgvTravelers = new DataGridView();
            itemTitleTraveler = new DataGridViewTextBoxColumn();
            capacityTraveler = new DataGridViewTextBoxColumn();
            areaTraveler = new DataGridViewTextBoxColumn();
            itemTypeTraveler = new DataGridViewTextBoxColumn();
            owners = new TabPage();
            addBtn = new Button();
            dgvOwners = new DataGridView();
            itemTitle = new DataGridViewTextBoxColumn();
            capacity = new DataGridViewTextBoxColumn();
            itemArea = new DataGridViewTextBoxColumn();
            itemType = new DataGridViewTextBoxColumn();
            editLink = new DataGridViewLinkColumn();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            logOutBtn = new Button();
            tabControl.SuspendLayout();
            travelers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTravelers).BeginInit();
            owners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(travelers);
            tabControl.Controls.Add(owners);
            tabControl.Location = new Point(42, 182);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(873, 358);
            tabControl.TabIndex = 0;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // travelers
            // 
            travelers.BackColor = Color.FromArgb(187, 187, 187);
            travelers.BorderStyle = BorderStyle.FixedSingle;
            travelers.Controls.Add(pictureBox1);
            travelers.Controls.Add(searchTxt);
            travelers.Controls.Add(dgvTravelers);
            travelers.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            travelers.Location = new Point(4, 29);
            travelers.Name = "travelers";
            travelers.Size = new Size(865, 325);
            travelers.TabIndex = 0;
            travelers.Text = "I'm Traveler";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTxt.Location = new Point(21, 12);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(292, 39);
            searchTxt.TabIndex = 1;
            searchTxt.TextChanged += OnTextChangeToSearch;
            // 
            // dgvTravelers
            // 
            dgvTravelers.BackgroundColor = Color.White;
            dgvTravelers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravelers.Columns.AddRange(new DataGridViewColumn[] { itemTitleTraveler, capacityTraveler, areaTraveler, itemTypeTraveler });
            dgvTravelers.GridColor = Color.FromArgb(187, 187, 187);
            dgvTravelers.Location = new Point(21, 65);
            dgvTravelers.Name = "dgvTravelers";
            dgvTravelers.RowHeadersVisible = false;
            dgvTravelers.RowHeadersWidth = 51;
            dgvTravelers.ScrollBars = ScrollBars.Vertical;
            dgvTravelers.ShowCellErrors = false;
            dgvTravelers.Size = new Size(825, 240);
            dgvTravelers.TabIndex = 0;
            // 
            // itemTitleTraveler
            // 
            itemTitleTraveler.HeaderText = "Title";
            itemTitleTraveler.MinimumWidth = 6;
            itemTitleTraveler.Name = "itemTitleTraveler";
            itemTitleTraveler.Width = 180;
            // 
            // capacityTraveler
            // 
            capacityTraveler.HeaderText = "Capacity";
            capacityTraveler.MinimumWidth = 6;
            capacityTraveler.Name = "capacityTraveler";
            capacityTraveler.Width = 125;
            // 
            // areaTraveler
            // 
            areaTraveler.HeaderText = "Area";
            areaTraveler.MinimumWidth = 6;
            areaTraveler.Name = "areaTraveler";
            areaTraveler.Width = 180;
            // 
            // itemTypeTraveler
            // 
            itemTypeTraveler.HeaderText = "Type";
            itemTypeTraveler.MinimumWidth = 6;
            itemTypeTraveler.Name = "itemTypeTraveler";
            itemTypeTraveler.Width = 180;
            // 
            // owners
            // 
            owners.BackColor = Color.FromArgb(187, 187, 187);
            owners.BorderStyle = BorderStyle.FixedSingle;
            owners.Controls.Add(addBtn);
            owners.Controls.Add(dgvOwners);
            owners.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owners.Location = new Point(4, 29);
            owners.Name = "owners";
            owners.Size = new Size(865, 325);
            owners.TabIndex = 1;
            owners.Text = "I'm Owner / Manager";
            // 
            // addBtn
            // 
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(21, 12);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(221, 40);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add Listing";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += OnClickToAddItem;
            // 
            // dgvOwners
            // 
            dgvOwners.BackgroundColor = Color.White;
            dgvOwners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwners.Columns.AddRange(new DataGridViewColumn[] { itemTitle, capacity, itemArea, itemType, editLink });
            dgvOwners.GridColor = SystemColors.Window;
            dgvOwners.Location = new Point(21, 65);
            dgvOwners.Name = "dgvOwners";
            dgvOwners.RowHeadersVisible = false;
            dgvOwners.RowHeadersWidth = 51;
            dgvOwners.Size = new Size(825, 240);
            dgvOwners.TabIndex = 1;
            dgvOwners.CellContentClick += dgvOwners_CellContentClick;
            // 
            // itemTitle
            // 
            itemTitle.HeaderText = "Title";
            itemTitle.MinimumWidth = 6;
            itemTitle.Name = "itemTitle";
            itemTitle.Width = 180;
            // 
            // capacity
            // 
            capacity.HeaderText = "Capacity";
            capacity.MinimumWidth = 6;
            capacity.Name = "capacity";
            capacity.Width = 125;
            // 
            // itemArea
            // 
            itemArea.HeaderText = "Area";
            itemArea.MinimumWidth = 6;
            itemArea.Name = "itemArea";
            itemArea.Width = 180;
            // 
            // itemType
            // 
            itemType.HeaderText = "Type";
            itemType.MinimumWidth = 6;
            itemType.Name = "itemType";
            itemType.Width = 180;
            // 
            // editLink
            // 
            editLink.HeaderText = "";
            editLink.MinimumWidth = 6;
            editLink.Name = "editLink";
            editLink.Width = 157;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(298, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(324, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 187, 187);
            panel1.Location = new Point(0, 568);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 36);
            panel1.TabIndex = 7;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.FromArgb(187, 187, 187);
            logOutBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.Location = new Point(831, 0);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.RightToLeft = RightToLeft.No;
            logOutBtn.Size = new Size(124, 40);
            logOutBtn.TabIndex = 8;
            logOutBtn.Text = "Log out";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += OnClickToLogOut;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logOutBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(tabControl);
            Name = "ListView";
            Size = new Size(955, 604);
            tabControl.ResumeLayout(false);
            travelers.ResumeLayout(false);
            travelers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTravelers).EndInit();
            owners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOwners).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage travelers;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TabPage owners;
        private DataGridView dgvTravelers;
        private TextBox searchTxt;
        private Button addBtn;
        private DataGridView dgvOwners;
        private DataGridViewTextBoxColumn itemTitle;
        private DataGridViewTextBoxColumn capacity;
        private DataGridViewTextBoxColumn itemArea;
        private DataGridViewTextBoxColumn itemType;
        private DataGridViewLinkColumn editLink;
        private DataGridViewTextBoxColumn itemTitleTraveler;
        private DataGridViewTextBoxColumn capacityTraveler;
        private DataGridViewTextBoxColumn areaTraveler;
        private DataGridViewTextBoxColumn itemTypeTraveler;
        private Button logOutBtn;
        private PictureBox pictureBox1;
    }
}
