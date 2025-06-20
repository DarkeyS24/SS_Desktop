namespace SS_Desktop.Views
{
    partial class RegisterView
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
            panel1 = new Panel();
            label7 = new Label();
            members = new NumericUpDown();
            groupBox1 = new GroupBox();
            femaleRb = new RadioButton();
            maleRb = new RadioButton();
            termsLink = new LinkLabel();
            termsCb = new CheckBox();
            datePicker = new DateTimePicker();
            label6 = new Label();
            rePswdTxt = new TextBox();
            pswdTxt = new TextBox();
            nameTxt = new TextBox();
            userTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)members).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 187, 187);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(members);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(termsLink);
            panel1.Controls.Add(termsCb);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(rePswdTxt);
            panel1.Controls.Add(pswdTxt);
            panel1.Controls.Add(nameTxt);
            panel1.Controls.Add(userTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(34, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 466);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(416, 137);
            label7.Name = "label7";
            label7.Size = new Size(215, 33);
            label7.TabIndex = 14;
            label7.Text = "Family members:";
            // 
            // members
            // 
            members.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            members.Location = new Point(652, 135);
            members.Name = "members";
            members.Size = new Size(213, 39);
            members.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(femaleRb);
            groupBox1.Controls.Add(maleRb);
            groupBox1.Location = new Point(411, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 73);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // femaleRb
            // 
            femaleRb.AutoSize = true;
            femaleRb.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            femaleRb.Location = new Point(122, 23);
            femaleRb.Name = "femaleRb";
            femaleRb.Size = new Size(121, 37);
            femaleRb.TabIndex = 1;
            femaleRb.TabStop = true;
            femaleRb.Text = "Female";
            femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            maleRb.AutoSize = true;
            maleRb.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maleRb.Location = new Point(23, 23);
            maleRb.Name = "maleRb";
            maleRb.Size = new Size(93, 37);
            maleRb.TabIndex = 0;
            maleRb.TabStop = true;
            maleRb.Text = "Male";
            maleRb.UseVisualStyleBackColor = true;
            // 
            // termsLink
            // 
            termsLink.AutoSize = true;
            termsLink.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            termsLink.Location = new Point(416, 421);
            termsLink.Name = "termsLink";
            termsLink.Size = new Size(283, 28);
            termsLink.TabIndex = 11;
            termsLink.TabStop = true;
            termsLink.Text = "View Terms and Conditions";
            termsLink.LinkClicked += termsLink_LinkClicked;
            // 
            // termsCb
            // 
            termsCb.AutoSize = true;
            termsCb.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            termsCb.Location = new Point(20, 421);
            termsCb.Name = "termsCb";
            termsCb.Size = new Size(390, 32);
            termsCb.TabIndex = 10;
            termsCb.Text = "I agree to the Terms and Conditions";
            termsCb.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(171, 211);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(213, 39);
            datePicker.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(411, 290);
            label6.Name = "label6";
            label6.Size = new Size(226, 33);
            label6.TabIndex = 8;
            label6.Text = "Re-type password:";
            // 
            // rePswdTxt
            // 
            rePswdTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rePswdTxt.Location = new Point(652, 287);
            rePswdTxt.Name = "rePswdTxt";
            rePswdTxt.Size = new Size(213, 39);
            rePswdTxt.TabIndex = 7;
            // 
            // pswdTxt
            // 
            pswdTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pswdTxt.Location = new Point(171, 287);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.Size = new Size(213, 39);
            pswdTxt.TabIndex = 6;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(171, 136);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(213, 39);
            nameTxt.TabIndex = 5;
            // 
            // userTxt
            // 
            userTxt.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(171, 65);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(213, 39);
            userTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 290);
            label5.Name = "label5";
            label5.Size = new Size(131, 33);
            label5.TabIndex = 3;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 217);
            label4.Name = "label4";
            label4.Size = new Size(121, 33);
            label4.TabIndex = 2;
            label4.Text = "Birthday:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 139);
            label3.Name = "label3";
            label3.Size = new Size(136, 33);
            label3.TabIndex = 1;
            label3.Text = "Full name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(140, 33);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // button1
            // 
            button1.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(307, 530);
            button1.Name = "button1";
            button1.Size = new Size(275, 42);
            button1.TabIndex = 1;
            button1.Text = "Return to login form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 16);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 2;
            label1.Text = "Your information";
            // 
            // button2
            // 
            button2.Font = new Font("Open Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(616, 530);
            button2.Name = "button2";
            button2.Size = new Size(219, 42);
            button2.TabIndex = 3;
            button2.Text = "Register & login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnClickToRegisterAndLogin;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "RegisterView";
            Size = new Size(955, 604);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)members).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox userTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private LinkLabel termsLink;
        private CheckBox termsCb;
        private DateTimePicker datePicker;
        private Label label6;
        private TextBox rePswdTxt;
        private TextBox pswdTxt;
        private TextBox nameTxt;
        private Label label7;
        private NumericUpDown members;
        private RadioButton femaleRb;
        private RadioButton maleRb;
    }
}
