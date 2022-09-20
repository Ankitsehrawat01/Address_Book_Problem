using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    public class Addressbook
    {
       public static  List<contacts> add = new List<contacts>();
        public static void AddContact()
        {
            contacts con = new contacts();
            Console.WriteLine("Enter First Name");
            con.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            con.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            con.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            con.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            con.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            con.ZipCode = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            con.Phonenumber = long.Parse(Console.ReadLine());
            add.Add(con);
        }

        public static void Display()
        {
            foreach (contacts data in add)
            {
                Console.WriteLine("Firstname:" + data.FirstName);
                Console.WriteLine("Lastname:" + data.LastName);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("city:" + data.City);
                Console.WriteLine("state:" + data.State);
                Console.WriteLine("Zipcode:" + data.ZipCode);
                Console.WriteLine("PhoneNumber:" + data.Phonenumber);
            }
        }
        public static void EditContact()
        {
            Console.WriteLine("Enter first name to edit a contact");
            string name = Console.ReadLine().ToLower();
            foreach (var data in add)
            {
                if (add.Contains(data))
                {
                    if (data.FirstName.Equals(name))
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                string firstname = Console.ReadLine();
                                data.FirstName = firstname;
                                break;
                            case 2:
                                string lastname = Console.ReadLine();
                                data.LastName = lastname;
                                break;
                            case 3:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 4:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 5:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 6:
                                long zipcode = long.Parse(Console.ReadLine());
                                data.ZipCode = zipcode;
                                break;
                            case 7:
                                long phonenumber = long.Parse(Console.ReadLine());
                                data.Phonenumber = phonenumber;
                                break;
                            default:
                                Console.WriteLine("Choose valid Option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesn't Matches");
                    }
                }
            }
        }
        public static void DeleteContact(string personName)
        {
            for (int i = 0; i < add.Count; i++)
            {
                if (add[i].FirstName == personName)
                {
                    Console.WriteLine("Record {0} succesfully deleted", add[i].FirstName);
                    add.RemoveAt(i);

                }
            }
        }
        public static void AddMultipleContacts()
        {
            Console.WriteLine("Enter the Number of Records you want to Insert");
            int number = (int)Convert.ToInt64(Console.ReadLine());
            while(number> 0)
            {
                AddContact();
                number--;
            }
        }
    }
}