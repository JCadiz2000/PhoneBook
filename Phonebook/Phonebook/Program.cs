using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Contact
    {
        public string LastName;
        public string FirstName;
        public string PhoneNumber;
        public string Email;
        public string Address;
    }
    class Program
    {
        public static List<Contact> Person = new List<Contact>();
        
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("---------------Phone Book Menu---------------\n");
            Console.WriteLine("1- ADD\t 2-UPDATE\t 3-DELETE\t 4-SEARCH\t 5-DISPLAY\t 0-EXIT");
            Console.WriteLine("\n---------------Phone Book Menu---------------");
            Console.WriteLine("Select:");
            input = Convert.ToInt32(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }

        }

        public static void Add()
        {
            Console.WriteLine("Doing ADD");
            Contact person = new Contact();

            person.LastName = Console.ReadLine();
            person.FirstName = Console.ReadLine();
            person.PhoneNumber = Console.ReadLine();
            person.Email = Console.ReadLine();
            person.Address = Console.ReadLine();
        }
    }


}