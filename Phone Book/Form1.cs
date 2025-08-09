namespace Phone_Book
{
    public partial class Form1 : Form
    {
        private readonly HashTable? hashTable;
        private SQLDataManager sqlDataManager;

        public Form1()
        {
            InitializeComponent();
            sqlDataManager = new SQLDataManager();
            hashTable = new HashTable();
            PopulateDataGridView();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddContactForm NewForm = new(hashTable, PopulateDataGridView);
            NewForm.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteContactForm NewForm = new(hashTable, PopulateDataGridView);
            NewForm.ShowDialog();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (SearchtxtBox.Text == "")
            {
                MessageBox.Show("Plz Enter The Number First ");
            }
            else
            {
                Contact? contact = hashTable.Search(SearchtxtBox.Text);  // Search in hash table and database
                if (contact != null)
                {
                    MessageBox.Show($"Contact Found: {contact.Name}, {contact.Phone}");
                }
                else
                {
                    MessageBox.Show("Contact not found.");
                }
            }
        }

        private void PopulateDataGridView()
        {
            try
            {
                // Step 1: Get sorted contacts from SQLDataManager
                SQLDataManager sqlDataManager = new();
                List<Contact> sortedContacts = sqlDataManager.GetAllContacts();
                dataGridView1.Rows.Clear();
                // Step 2: Add sorted contacts to a Linked List
                LinkedList<Contact> linkedListContacts = new();
                foreach (var contact in sortedContacts)
                {
                    linkedListContacts.AddLast(contact);

                }

                // Step 3: Display contacts in DataGridView from Linked List
                dataGridView1.Rows.Clear();
                foreach (var contact in linkedListContacts)
                {
                    dataGridView1.Rows.Add(contact.Name, contact.Phone, contact.Email, contact.Category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void PopulateDataGridView(string? category = null)
        {
            try
            {
                // Fetch contacts from the database
                List<Contact> contacts = category == null
                    ? sqlDataManager.GetAllContacts() // Fetch all contacts
                    : sqlDataManager.GetAllContacts(category); // Fetch contacts by category

                // Populate linked list with the contacts
                CustomLinkedList linkedList = new();
                foreach (var contact in contacts)
                {
                    linkedList.Add(contact);
                }

                // Clear existing rows in DataGridView
                dataGridView1.Rows.Clear();

                // Traverse linked list and add data to DataGridView
                Node? current = linkedList.Head;
                while (current != null)
                {
                    Contact contact = current.Data;
                    dataGridView1.Rows.Add(contact.Name, contact.Phone, contact.Email, contact.Category);
                    current = current.Next;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BussinessContactsBtn_Click(object sender, EventArgs e)
        {
            PopulateDataGridView("Bussiness");
        }

        private void familyContactsBtn_Click(object sender, EventArgs e)
        {
            PopulateDataGridView("Family");
        }

        private void FriendsContactsBtn_Click(object sender, EventArgs e)
        {
            PopulateDataGridView("Friends");
        }

        private void AllContactsBtn_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        
    }
}

