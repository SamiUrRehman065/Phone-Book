using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class DeleteContactForm : Form
    {
        private readonly HashTable? hashTable;
        private readonly Action refreshGridView;
        public DeleteContactForm(HashTable? hashTable, Action refreshGridView)
        {
            InitializeComponent();
            this.hashTable = hashTable;
            this.refreshGridView = refreshGridView;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (phonetxtbox.Text == ""|| nametxtBox.Text == "")
            {
                MessageBox.Show("Plz Fill All Required Fields");
            }
            else
            {
                
                string phone = phonetxtbox.Text;
                bool check =hashTable.Delete(phone);  // Delete from hash table and database
                if (check)
                {
                    MessageBox.Show("Contact deleted successfully.");
                    refreshGridView?.Invoke(); // Refresh the grid view
                    this.Close();
                }
                else {
                    MessageBox.Show("Contact Not Found");
                   
                }
                
            }
        }
    }
}
