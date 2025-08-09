namespace Phone_Book
{
    partial class DeleteContactForm
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
            DeleteBtn = new Button();
            phonetxtbox = new TextBox();
            nametxtBox = new TextBox();
            BtnCancel = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatAppearance.BorderColor = Color.DimGray;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.CheckedBackColor = Color.White;
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Image = Properties.Resources.DeleteButton1;
            DeleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBtn.Location = new Point(215, 324);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(226, 50);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.TabStop = false;
            DeleteBtn.Text = "  Delete";
            DeleteBtn.TextAlign = ContentAlignment.TopCenter;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // phonetxtbox
            // 
            phonetxtbox.BackColor = SystemColors.Menu;
            phonetxtbox.BorderStyle = BorderStyle.FixedSingle;
            phonetxtbox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonetxtbox.ForeColor = SystemColors.WindowText;
            phonetxtbox.Location = new Point(92, 227);
            phonetxtbox.Name = "phonetxtbox";
            phonetxtbox.PlaceholderText = "   Phone No.";
            phonetxtbox.Size = new Size(453, 57);
            phonetxtbox.TabIndex = 19;
            phonetxtbox.TabStop = false;
            // 
            // nametxtBox
            // 
            nametxtBox.BackColor = SystemColors.Menu;
            nametxtBox.BorderStyle = BorderStyle.FixedSingle;
            nametxtBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxtBox.Location = new Point(92, 117);
            nametxtBox.Name = "nametxtBox";
            nametxtBox.PlaceholderText = "   Name ";
            nametxtBox.Size = new Size(453, 57);
            nametxtBox.TabIndex = 17;
            nametxtBox.TabStop = false;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Image = Properties.Resources.CancelButton;
            BtnCancel.Location = new Point(577, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(50, 49);
            BtnCancel.TabIndex = 14;
            BtnCancel.TabStop = false;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoContact;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(186, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 15;
            label1.Text = "Add Contact";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteContactForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(632, 662);
            Controls.Add(DeleteBtn);
            Controls.Add(phonetxtbox);
            Controls.Add(nametxtBox);
            Controls.Add(BtnCancel);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteContactForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteContactForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private TextBox phonetxtbox;
        private TextBox nametxtBox;
        private Button BtnCancel;
        private PictureBox pictureBox1;
        private Label label1;
    }
}