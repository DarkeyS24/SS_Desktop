namespace SS_Desktop.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer comp = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (comp != null))
            {
                comp.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            label1 = new Label();
            panel2 = new Panel();
            signedCb = new CheckBox();
            showCb = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pswdTxt = new TextBox();
            userTxt = new TextBox();
            empTxt = new TextBox();
            exitBtn = new Button();
            loginBtn = new Button();
            panel3 = new Panel();
            label5 = new Label();
            createLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            addEditView2 = new AddEditView();
            listView1 = new ListView();
            termsView1 = new TermsView();
            registerView1 = new RegisterView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 150);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 187, 187);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(signedCb);
            panel2.Controls.Add(showCb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pswdTxt);
            panel2.Controls.Add(userTxt);
            panel2.Controls.Add(empTxt);
            panel2.Location = new Point(225, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 300);
            panel2.TabIndex = 0;
            // 
            // signedCb
            // 
            signedCb.AutoSize = true;
            signedCb.Font = new Font("Open Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signedCb.Location = new Point(30, 246);
            signedCb.Name = "signedCb";
            signedCb.Size = new Size(184, 28);
            signedCb.TabIndex = 6;
            signedCb.Text = "Keep me signed in";
            signedCb.UseVisualStyleBackColor = true;
            signedCb.CheckedChanged += signedCb_CheckedChanged;
            // 
            // showCb
            // 
            showCb.AutoSize = true;
            showCb.Font = new Font("Open Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showCb.Location = new Point(286, 218);
            showCb.Name = "showCb";
            showCb.Size = new Size(164, 28);
            showCb.TabIndex = 5;
            showCb.Text = "Show password";
            showCb.UseVisualStyleBackColor = true;
            showCb.CheckedChanged += showCb_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(187, 187, 187);
            label4.Font = new Font("Open Sans", 13.8F, FontStyle.Bold);
            label4.Location = new Point(30, 175);
            label4.Name = "label4";
            label4.Size = new Size(131, 33);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(187, 187, 187);
            label3.Font = new Font("Open Sans", 13.8F, FontStyle.Bold);
            label3.Location = new Point(30, 108);
            label3.Name = "label3";
            label3.Size = new Size(74, 33);
            label3.TabIndex = 3;
            label3.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(187, 187, 187);
            label2.Font = new Font("Open Sans", 13.8F, FontStyle.Bold);
            label2.Location = new Point(30, 42);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 2;
            label2.Text = "Employee:";
            // 
            // pswdTxt
            // 
            pswdTxt.BorderStyle = BorderStyle.FixedSingle;
            pswdTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pswdTxt.Location = new Point(186, 173);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.Size = new Size(255, 39);
            pswdTxt.TabIndex = 2;
            pswdTxt.UseSystemPasswordChar = true;
            pswdTxt.KeyPress += OnKeyPressedToList;
            // 
            // userTxt
            // 
            userTxt.BorderStyle = BorderStyle.FixedSingle;
            userTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(186, 106);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(255, 39);
            userTxt.TabIndex = 1;
            // 
            // empTxt
            // 
            empTxt.BorderStyle = BorderStyle.FixedSingle;
            empTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empTxt.Location = new Point(186, 40);
            empTxt.Name = "empTxt";
            empTxt.Size = new Size(255, 39);
            empTxt.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(306, 485);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(143, 42);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loginBtn.Location = new Point(485, 485);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(138, 42);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(187, 187, 187);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(createLink);
            panel3.Location = new Point(306, 549);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 36);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(187, 187, 187);
            label5.Font = new Font("Open Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 5);
            label5.Name = "label5";
            label5.Size = new Size(207, 24);
            label5.TabIndex = 5;
            label5.Text = "Don't have an account?";
            // 
            // createLink
            // 
            createLink.AutoSize = true;
            createLink.Font = new Font("Open Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createLink.Location = new Point(217, 5);
            createLink.Name = "createLink";
            createLink.Size = new Size(102, 24);
            createLink.TabIndex = 6;
            createLink.TabStop = true;
            createLink.Text = "Create one";
            createLink.LinkClicked += createLink_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // addEditView2
            // 
            addEditView2.BackColor = Color.White;
            addEditView2.Location = new Point(-3, 0);
            addEditView2.Name = "addEditView2";
            addEditView2.Size = new Size(960, 598);
            addEditView2.TabIndex = 6;
            addEditView2.Visible = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(-3, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(960, 598);
            listView1.TabIndex = 7;
            listView1.Visible = false;
            // 
            // termsView1
            // 
            termsView1.Location = new Point(257, 38);
            termsView1.Name = "termsView1";
            termsView1.Size = new Size(436, 474);
            termsView1.TabIndex = 8;
            termsView1.Visible = false;
            // 
            // registerView1
            // 
            registerView1.Location = new Point(-3, 0);
            registerView1.Name = "registerView1";
            registerView1.Size = new Size(960, 596);
            registerView1.TabIndex = 9;
            registerView1.Visible = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 597);
            Controls.Add(registerView1);
            Controls.Add(termsView1);
            Controls.Add(listView1);
            Controls.Add(addEditView2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(loginBtn);
            Controls.Add(exitBtn);
            Name = "LoginView";
            Text = "Seoul Stay - Welcome";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private CheckBox showCb;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox pswdTxt;
        private TextBox userTxt;
        private TextBox empTxt;
        private Button exitBtn;
        private CheckBox signedCb;
        private Button loginBtn;
        private Panel panel3;
        private LinkLabel createLink;
        private Label label5;
        private PictureBox pictureBox1;
        private RegisterView registerView1;
        private TermsView termsView1;
        private AddEditView addEditView1;
        private AddEditView addEditView2;
        private ListView listView1;
    }
}