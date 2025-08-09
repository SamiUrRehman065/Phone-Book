using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phone_Book
{
    public partial class AddContactForm : Form
    {
        private readonly HashTable? hashTable;
        private readonly Action refreshGridView;

        public AddContactForm(HashTable? hashTable , Action refreshGridView)
        {
            InitializeComponent();
            this.hashTable = hashTable;
            this.refreshGridView = refreshGridView;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_MouseHover(object sender, EventArgs e)
        {
            AddBtn.ForeColor = Color.White;
        }

        private void AddBtn_MouseLeave(object sender, EventArgs e)
        {
            AddBtn.ForeColor = Color.Black;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (phonetxtbox.Text == "" || nametxtBox.Text == "" || Emailtxtbox.Text == "" || Catagorycmb.SelectedItem == null)
            {
                MessageBox.Show("Plz Fill All Required Fields");
            }
            else
            {
                
                Contact contact = new(nametxtBox.Text, phonetxtbox.Text, Emailtxtbox.Text, Catagorycmb.SelectedItem?.ToString() ?? "");
                hashTable.Add(contact);  // Add contact to hash table and database
                MessageBox.Show("Contact added successfully.");
                refreshGridView?.Invoke(); // Refresh the grid view
                this.Close(); // Close the add form
            }     
        }
    }
} 
