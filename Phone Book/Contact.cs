using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    public class Contact(string name, string phone, string email, string category)
    {
        public string Name { get; set; } = name;
        public string Phone { get; set; } = phone;
        public string Email { get; set; } = email;
        public string Category { get; set; } = category;
    }
}
