using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            MainMenu menu = new MainMenu();
            while (displayMenu)
            {
                displayMenu = menu.Menu();
            }
        }
    }
}
