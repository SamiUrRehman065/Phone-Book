namespace Phone_Book
{
    partial class AddContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCancel = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            nametxtBox = new TextBox();
            Emailtxtbox = new TextBox();
            phonetxtbox = new TextBox();
            Catagorycmb = new ComboBox();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Image = Properties.Resources.CancelButton;
            BtnCancel.Location = new Point(579, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(50, 49);
            BtnCancel.TabIndex = 6;
            BtnCancel.TabStop = false;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(188, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 7;
            label1.Text = "Add Contact";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoContact;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // nametxtBox
            // 
            nametxtBox.BackColor = SystemColors.Menu;
            nametxtBox.BorderStyle = BorderStyle.FixedSingle;
            nametxtBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxtBox.Location = new Point(94, 117);
            nametxtBox.Name = "nametxtBox";
            nametxtBox.PlaceholderText = "   Name ";
            nametxtBox.Size = new Size(453, 57);
            nametxtBox.TabIndex = 9;
            nametxtBox.TabStop = false;
            // 
            // Emailtxtbox
            // 
            Emailtxtbox.BackColor = SystemColors.Menu;
            Emailtxtbox.BorderStyle = BorderStyle.FixedSingle;
            Emailtxtbox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emailtxtbox.Location = new Point(94, 208);
            Emailtxtbox.Name = "Emailtxtbox";
            Emailtxtbox.PlaceholderText = "   Email";
            Emailtxtbox.Size = new Size(453, 57);
            Emailtxtbox.TabIndex = 10;
            Emailtxtbox.TabStop = false;
            // 
            // phonetxtbox
            // 
            phonetxtbox.BackColor = SystemColors.Menu;
            phonetxtbox.BorderStyle = BorderStyle.FixedSingle;
            phonetxtbox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonetxtbox.ForeColor = SystemColors.WindowText;
            phonetxtbox.Location = new Point(94, 305);
            phonetxtbox.Name = "phonetxtbox";
            phonetxtbox.PlaceholderText = "   Phone No.";
            phonetxtbox.Size = new Size(453, 57);
            phonetxtbox.TabIndex = 11;
            phonetxtbox.TabStop = false;
            // 
            // Catagorycmb
            // 
            Catagorycmb.FlatStyle = FlatStyle.Flat;
            Catagorycmb.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Catagorycmb.ForeColor = Color.DimGray;
            Catagorycmb.FormattingEnabled = true;
            Catagorycmb.ItemHeight = 45;
            Catagorycmb.Items.AddRange(new object[] { "Bussiness", "Family", "Friends" });
            Catagorycmb.Location = new Point(94, 416);
            Catagorycmb.Name = "Catagorycmb";
            Catagorycmb.Size = new Size(453, 53);
            Catagorycmb.TabIndex = 0;
            Catagorycmb.TabStop = false;
            Catagorycmb.Tag = "";
            Catagorycmb.Text = "    Select Category";
            // 
            // AddBtn
            // 
            AddBtn.FlatAppearance.BorderColor = Color.DimGray;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.CheckedBackColor = Color.White;
            AddBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Image = Properties.Resources.AddButton2;
            AddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddBtn.Location = new Point(239, 537);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(160, 50);
            AddBtn.TabIndex = 12;
            AddBtn.TabStop = false;
            AddBtn.Text = "   Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            AddBtn.MouseLeave += AddBtn_MouseLeave;
            AddBtn.MouseHover += AddBtn_MouseHover;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(632, 662);
            Controls.Add(AddBtn);
            Controls.Add(Catagorycmb);
            Controls.Add(phonetxtbox);
            Controls.Add(Emailtxtbox);
            Controls.Add(nametxtBox);
            Controls.Add(BtnCancel);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddContactForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddContactForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox nametxtBox;
        private TextBox Emailtxtbox;
        private TextBox phonetxtbox;
        private ComboBox Catagorycmb;
        private Button AddBtn;
    }
}