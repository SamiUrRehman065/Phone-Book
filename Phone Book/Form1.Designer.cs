namespace Phone_Book
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CancelBtn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            FriendsContactsBtn = new Button();
            BussinessContactsBtn = new Button();
            familyContactsBtn = new Button();
            AllContactsBtn = new Button();
            panel3 = new Panel();
            Addbtn = new Button();
            Deletebtn = new Button();
            Searchbtn = new Button();
            SearchtxtBox = new TextBox();
            dataGridView1 = new DataGridView();
            ContactName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1547, 76);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoContact;
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            CancelBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Image = Properties.Resources.CancelButton;
            CancelBtn.Location = new Point(1492, 13);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(50, 49);
            CancelBtn.TabIndex = 0;
            CancelBtn.TabStop = false;
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(73, 16);
            label1.Name = "label1";
            label1.Size = new Size(154, 46);
            label1.TabIndex = 0;
            label1.Text = "Contacts";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(FriendsContactsBtn);
            panel2.Controls.Add(BussinessContactsBtn);
            panel2.Controls.Add(familyContactsBtn);
            panel2.Controls.Add(AllContactsBtn);
            panel2.Location = new Point(11, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 674);
            panel2.TabIndex = 1;
          
            // 
            // FriendsContactsBtn
            // 
            FriendsContactsBtn.FlatAppearance.BorderColor = Color.DimGray;
            FriendsContactsBtn.FlatAppearance.BorderSize = 0;
            FriendsContactsBtn.FlatAppearance.CheckedBackColor = Color.White;
            FriendsContactsBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            FriendsContactsBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            FriendsContactsBtn.FlatStyle = FlatStyle.Flat;
            FriendsContactsBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FriendsContactsBtn.Image = Properties.Resources.FriendsContacts;
            FriendsContactsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FriendsContactsBtn.Location = new Point(29, 261);
            FriendsContactsBtn.Name = "FriendsContactsBtn";
            FriendsContactsBtn.Size = new Size(222, 50);
            FriendsContactsBtn.TabIndex = 3;
            FriendsContactsBtn.TabStop = false;
            FriendsContactsBtn.Text = "Friends";
            FriendsContactsBtn.UseVisualStyleBackColor = true;
            FriendsContactsBtn.Click += FriendsContactsBtn_Click;
            // 
            // BussinessContactsBtn
            // 
            BussinessContactsBtn.FlatAppearance.BorderColor = Color.DimGray;
            BussinessContactsBtn.FlatAppearance.BorderSize = 0;
            BussinessContactsBtn.FlatAppearance.CheckedBackColor = Color.White;
            BussinessContactsBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            BussinessContactsBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            BussinessContactsBtn.FlatStyle = FlatStyle.Flat;
            BussinessContactsBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BussinessContactsBtn.Image = Properties.Resources.BussinessContacts;
            BussinessContactsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BussinessContactsBtn.Location = new Point(29, 103);
            BussinessContactsBtn.Name = "BussinessContactsBtn";
            BussinessContactsBtn.Size = new Size(222, 50);
            BussinessContactsBtn.TabIndex = 1;
            BussinessContactsBtn.TabStop = false;
            BussinessContactsBtn.Text = "Bussines";
            BussinessContactsBtn.UseVisualStyleBackColor = true;
            BussinessContactsBtn.Click += BussinessContactsBtn_Click;
            // 
            // familyContactsBtn
            // 
            familyContactsBtn.FlatAppearance.BorderColor = Color.DimGray;
            familyContactsBtn.FlatAppearance.BorderSize = 0;
            familyContactsBtn.FlatAppearance.CheckedBackColor = Color.White;
            familyContactsBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            familyContactsBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            familyContactsBtn.FlatStyle = FlatStyle.Flat;
            familyContactsBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            familyContactsBtn.Image = Properties.Resources.FamilyContacts;
            familyContactsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            familyContactsBtn.Location = new Point(29, 182);
            familyContactsBtn.Name = "familyContactsBtn";
            familyContactsBtn.Size = new Size(222, 50);
            familyContactsBtn.TabIndex = 2;
            familyContactsBtn.TabStop = false;
            familyContactsBtn.Text = "Family";
            familyContactsBtn.UseVisualStyleBackColor = true;
            familyContactsBtn.Click += familyContactsBtn_Click;
            // 
            // AllContactsBtn
            // 
            AllContactsBtn.FlatAppearance.BorderColor = Color.DimGray;
            AllContactsBtn.FlatAppearance.BorderSize = 0;
            AllContactsBtn.FlatAppearance.CheckedBackColor = Color.White;
            AllContactsBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            AllContactsBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            AllContactsBtn.FlatStyle = FlatStyle.Flat;
            AllContactsBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllContactsBtn.Image = Properties.Resources.AllContacts;
            AllContactsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AllContactsBtn.Location = new Point(29, 27);
            AllContactsBtn.Name = "AllContactsBtn";
            AllContactsBtn.Size = new Size(222, 50);
            AllContactsBtn.TabIndex = 0;
            AllContactsBtn.TabStop = false;
            AllContactsBtn.Text = "   All Contacts";
            AllContactsBtn.UseVisualStyleBackColor = true;
            AllContactsBtn.Click += AllContactsBtn_Click;
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Addbtn);
            panel3.Controls.Add(Deletebtn);
            panel3.Controls.Add(Searchbtn);
            panel3.Controls.Add(SearchtxtBox);
            panel3.Controls.Add(dataGridView1);
            panel3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(300, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(1233, 674);
            panel3.TabIndex = 2;
            // 
            // Addbtn
            // 
            Addbtn.AllowDrop = true;
            Addbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Addbtn.FlatAppearance.BorderSize = 0;
            Addbtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            Addbtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Image = Properties.Resources.AddButton2;
            Addbtn.Location = new Point(1036, 10);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(92, 59);
            Addbtn.TabIndex = 5;
            Addbtn.TabStop = false;
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.AllowDrop = true;
            Deletebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Deletebtn.FlatAppearance.BorderSize = 0;
            Deletebtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            Deletebtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Image = Properties.Resources.DeleteButton1;
            Deletebtn.Location = new Point(1124, 8);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(94, 59);
            Deletebtn.TabIndex = 6;
            Deletebtn.TabStop = false;
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.FlatAppearance.BorderSize = 0;
            Searchbtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            Searchbtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            Searchbtn.FlatStyle = FlatStyle.Flat;
            Searchbtn.Image = Properties.Resources.Search1;
            Searchbtn.Location = new Point(972, 8);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(94, 59);
            Searchbtn.TabIndex = 4;
            Searchbtn.TabStop = false;
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // SearchtxtBox
            // 
            SearchtxtBox.BackColor = SystemColors.Menu;
            SearchtxtBox.BorderStyle = BorderStyle.FixedSingle;
            SearchtxtBox.CharacterCasing = CharacterCasing.Lower;
            SearchtxtBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchtxtBox.Location = new Point(23, 10);
            SearchtxtBox.Name = "SearchtxtBox";
            SearchtxtBox.PlaceholderText = "   Search Number";
            SearchtxtBox.Size = new Size(943, 57);
            SearchtxtBox.TabIndex = 0;
            SearchtxtBox.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ContactName, Phone, Email, Category });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(23, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1205, 586);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // ContactName
            // 
            ContactName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ContactName.Frozen = true;
            ContactName.HeaderText = "Contact Name";
            ContactName.MinimumWidth = 6;
            ContactName.Name = "ContactName";
            ContactName.ReadOnly = true;
            ContactName.Width = 273;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Phone.Frozen = true;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 273;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 273;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1545, 786);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Book";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button AllContactsBtn;
        private Button BussinessContactsBtn;
        private Button familyContactsBtn;
        private Button FriendsContactsBtn;
        private Button CancelBtn;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ContactName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Category;
        private Button Addbtn;
        private Button Deletebtn;
        private Button Searchbtn;
        private TextBox SearchtxtBox;
    }
}
