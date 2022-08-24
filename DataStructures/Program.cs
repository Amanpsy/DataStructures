using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Data Structure Program\n");
            Console.WriteLine("Press 1 \n1:Linked List.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) {

                case 1:
                    linkedlist Linkedlist = new linkedlist();
                    Linkedlist.Add(56);
                    Linkedlist.Add(30);
                    Linkedlist.Add(70);

                    break;
            
            
            
            }
           
        }
    }
}
