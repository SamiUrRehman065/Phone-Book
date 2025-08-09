using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Phone_Book
{
    public class SQLDataManager
    {
        private readonly string _connectionString;
        public SQLDataManager() {
            _connectionString = "Data Source=SAMIURREHMANTHI\\SQLEXPRESS;Initial Catalog=PhoneBookDataBase;Integrated Security=True;Trust Server Certificate=True";
        }
        public void AddContactToDatabase(Contact contact , int phoneHash)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Contacts (Name, Phone, Email, Category, PhoneHash) VALUES (@Name, @Phone, @Email, @Category, @PhoneHash)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name.Trim());
                command.Parameters.AddWithValue("@Phone", contact.Phone.Trim());
                command.Parameters.AddWithValue("@Email", contact.Email.Trim());
                command.Parameters.AddWithValue("@Category", contact.Category.Trim());
                command.Parameters.AddWithValue("@PhoneHash", phoneHash);

                
                command.ExecuteNonQuery();
            }
        }

        public bool DeleteContactFromDatabase(int phoneHash)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                string query = "DELETE FROM Contacts WHERE PhoneHash = @PhoneHash";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@PhoneHash", phoneHash);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return (rowsAffected > 0);
            }
        }

        public List<Contact> GetAllContacts(string? category = null)
        {
            List<Contact> contacts = new();
            using (SqlConnection connection = new(_connectionString))
            {
                string query = category == null
                    ? "SELECT * FROM Contacts"
                    : "SELECT * FROM Contacts WHERE Category = @Category";

                SqlCommand command = new(query, connection);
                if (category != null)
                {
                    command.Parameters.AddWithValue("@Category", category);
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new Contact(
                        reader["Name"]?.ToString() ?? "",
                        reader["Phone"]?.ToString() ?? "",
                        reader["Email"]?.ToString() ?? "",
                        reader["Category"]?.ToString() ?? ""
                    ));
                }
            }

            // Sort contacts using Trie
            TrieTree trie = new();
            foreach (var contact in contacts)
            {
                trie.Insert(contact);
            }

            // Return sorted list from Trie
            return trie.GetSortedContacts();
        }

        public Contact? GetContactByPhoneHash(int phoneHash)
        {
            Contact? contact = null;
            using (SqlConnection connection = new(_connectionString))
            {
                string query = "SELECT * FROM Contacts WHERE PhoneHash = @PhoneHash";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@PhoneHash", phoneHash);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    contact = new Contact(
                        reader["Name"].ToString()??"",
                        reader["Phone"].ToString()??"",
                        reader["Email"].ToString()??"",
                        reader["Category"].ToString()??""
                    );
                }
            }
            return contact;
        }
    }
}
