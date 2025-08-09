using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    public class TrieTree
    {
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children { get; } = new();
            public Contact? Contact { get; set; } // Store contact at the end of the name
            public bool IsEndOfWord { get; set; } = false;
        }

        private readonly TrieNode root;

        public TrieTree()
        {
            root = new TrieNode();
        }

        // Insert a contact into the Trie
        public void Insert(Contact contact)
        {
            TrieNode current = root;
            string name = contact.Name.ToLower();

            foreach (char c in name)
            {
                if (!current.Children.ContainsKey(c))
                {
                    current.Children[c] = new TrieNode();
                }
                current = current.Children[c];
            }
            current.IsEndOfWord = true;
            current.Contact = contact;
        }

        // Search for a contact by name
        public Contact? Search(string name)
        {
            TrieNode current = root;
            name = name.ToLower();

            foreach (char c in name)
            {
                if (!current.Children.ContainsKey(c))
                {
                    return null; // Name not found
                }
                current = current.Children[c];
            }
            return current.IsEndOfWord ? current.Contact : null;
        }

        // Get all contacts sorted alphabetically
        public List<Contact> GetSortedContacts()
        {
            List<Contact> sortedContacts = new();
            GetSortedContacts(root, "", sortedContacts);
            return sortedContacts;
        }

        private void GetSortedContacts(TrieNode node, string prefix, List<Contact> sortedContacts)
        {
            if (node == null) return;

            if (node.IsEndOfWord && node.Contact != null)
            {
                sortedContacts.Add(node.Contact);
            }
            var sortedChildren = node.Children.OrderBy(x => x.Key).ToList();
            foreach (var child in sortedChildren)
            {
                GetSortedContacts(child.Value, prefix + child.Key, sortedContacts);
            }
        }
    }

}
