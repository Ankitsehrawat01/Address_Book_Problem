using Address_book;
using System;

namespace Address_book
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Addressbook add = new Addressbook();

            add.AddContact();
            while (true)
            {
                Console.WriteLine("1-add, 2-display, 3-edit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.AddContact();
                        break;
                    case 2:
                        add.Display();
                        break;
                    case 3:
                        add.EditContact();
                        break ;
                } 

            }
        }
    }
}