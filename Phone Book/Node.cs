using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    public class Node(Contact data)
    {

        public Contact Data { get; set; } = data;
        public Node? Next { get; set; } = null;
    }
}
