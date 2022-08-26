using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
     class linkedlist
    {

        internal node head;

        public void Add(int data)
        {
            node Node = new node(data);
            
                if (head == null)
            {
                head = Node;
            }
                else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }
            Console.WriteLine("{0} added into linked list", Node.data);

        }
        public void AddFirst(int data)
        {
            node Node = new node(data);
            Node.next = head;
            head = Node;
            Console.WriteLine("{0} added into linked list", Node.data);
        }


        public void Display ()
        {
            Console.WriteLine("\nDisplaying Nodes\n");
            node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }

            }

        }
    
