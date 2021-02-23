using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Menu
    {
        Manager manager = new Manager();
        private void MainMenu()
        {
            Console.WriteLine("1. Faxe Kondi");
            Console.WriteLine("2. Pepsi");
            Console.WriteLine("3. Coca Cola");
            Console.WriteLine("4. exit");
        }

        public void GameLoop()
        {
            Machine machine = new Machine(15, 20, 25);
            while (true)
            {
                MainMenu();
                int userinput = int.Parse(Console.ReadLine());
                Console.Clear();
                manager.Selection(machine, userinput);
                Console.WriteLine(manager.SelectedSoda(machine));
                Console.WriteLine("Insert Money");
                machine.MoneyInserted = double.Parse(Console.ReadLine());
                Console.WriteLine(manager.GiveMoneyBack(machine));
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
