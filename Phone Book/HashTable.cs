using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;

namespace Phone_Book
{
    public class HashTable
    {
        private List<CustomLinkedList> table;
        private readonly int capacity;
        private readonly SQLDataManager sqlDataManager;
        
        public HashTable( int capacity = 10000 )
        {
            this.capacity = capacity;
            sqlDataManager = new SQLDataManager();
            table = new List<CustomLinkedList>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                table.Add(new CustomLinkedList());
            }

            
        }

        private int GenerateHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
            {
                hash = (hash * 31 + c) % capacity;
            }
            return Math.Abs(hash);
        }

        public void Add(Contact contact)
        {
            int phoneHash = GenerateHash(contact.Phone);  // Generate hash from phone number
            

            // Add to hash table using phone hash
            table[phoneHash].Add(contact);

            // Also store in database with the hash
            sqlDataManager.AddContactToDatabase(contact, phoneHash);
        }

        public Contact? Search(string phone)
        {
            int phoneHash = GenerateHash(phone);  // Generate hash from phone number

            // Search in the hash table
            Contact? contact = table[phoneHash].Find(phone);

            // If not found in hash table, try searching in the database
            contact ??= sqlDataManager.GetContactByPhoneHash(phoneHash);  // Use hash to search in database

            return contact;
        }

        public bool Delete(string phone)
        {
            int phoneHash = GenerateHash(phone);  // Generate hash from phone number

            // Delete from hash table
            bool check2 =table[phoneHash].Remove(phone);

            // Delete from database using hash
            bool check1 =sqlDataManager.DeleteContactFromDatabase(phoneHash);
            return check2 || check1;
        }

        
    }
}
