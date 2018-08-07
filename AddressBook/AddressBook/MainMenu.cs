using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class MainMenu
    {
        public bool Menu()
        {
            BookOperations addressBook = new BookOperations();
            Console.Clear();
            Console.WriteLine("Address Book: Please choose a function");
            Console.WriteLine("");
            Console.WriteLine("1) View Address Book");
            Console.WriteLine("2) Search by Name");
            Console.WriteLine("3) Add Contact");
            Console.WriteLine("4) Delete Contact");
            Console.WriteLine("5) Exit");
            Console.WriteLine("");
            string result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("All current entries in the address book");
                    Console.WriteLine("***************************************");
                    Console.WriteLine("");
                    addressBook.getAddressBook();
                    foreach (KeyValuePair<string, string> item in addressBook.getAddressBook())
                    {
                        Console.WriteLine("Name: {0}, Address: {1}", item.Key, item.Value);
                    }
                    Console.ReadLine();
                    return true;

                case "2":
                    Console.Clear();
                    Console.Write("Please enter the full name of the person: ");
                    string userInput = Console.ReadLine();
                    addressBook.getAddressBook();

                    foreach (var name in addressBook.getAddressBook() )
                    {
                        if (userInput.Contains(name.Key))
                        {
                            Console.WriteLine("Name: {0}, Address: {1}", name.Key, name.Value);
                        }
                    }
                    Console.ReadLine();
                    return true;



                case "3":
                    Console.Clear();
                    addressBook.AddToBook();
                    return true;

                case "4":
                    Console.Clear();
                    return true;

                case "5":
                    Console.Clear();
                    return false;

            }
            return false;

        }
    }
}
