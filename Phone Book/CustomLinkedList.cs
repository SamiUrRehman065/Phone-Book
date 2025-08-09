using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book
{
    public class CustomLinkedList
    {
        public Node? Head { get; private set; }

        public void Add(Contact contact)
        {
            Node newNode = new(contact);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public Contact? Find(string phone)
        {
            Node? current = Head;
            while (current != null)
            {
                if (current.Data.Phone == phone) return current.Data;
                current = current.Next;
            }
            return null;
        }

        public bool Remove(string phone)
        {
            if (Head == null) return false;

            if (Head.Data.Phone == phone)
            {
                Head = Head.Next;
                return true;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data.Phone != phone)
            {
                current = current.Next;

            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
