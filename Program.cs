using Address_book;
using System;

namespace Address_book
{
    public class Program
    {

        public static void Main(string[] args)
        { 
            Addressbook.AddContact();
            while (true)
            {
                Console.WriteLine("1-add, 2-display, 3-edit, 4-Delete");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Addressbook.AddContact();
                        break;
                    case 2:
                        Addressbook.Display();
                        break;
                    case 3:
                        Addressbook.EditContact();
                        break ;
                    case 4:
                        Console.WriteLine("Enter name to delete the record");
                        string name = Console.ReadLine();
                        Addressbook.DeleteContact(name);
                        break;
                    case 5:
                        Addressbook.AddMultipleContacts();
                        break;
                }

            }
        }
    }
}