using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Manager
    {
        //select wich soda you wanna buy
        public void Selection(Machine machine, int userinput)
        {
            if (userinput == 1)
            {
                machine.Soda.SodaEnum = sodas.Faxe;
            }
            else if (userinput == 2)
            {
                machine.Soda.SodaEnum = sodas.Pepsi;
            }
            else if (userinput == 3)
            {
                machine.Soda.SodaEnum = sodas.Cola;
            }
            else if (userinput == 4)
            {
                Environment.Exit(1);
            }
        }

        //checks what soda you selected and sets the price of the soda
        public string SelectedSoda(Machine machine)
        {
            if (machine.Soda.SodaEnum == sodas.Faxe)
            {
                machine.Price = machine.Soda.GetPrice.FaxePrice;
                return $"You chose Faxe Kondi, that costs {machine.Soda.GetPrice.FaxePrice}";
            }
            else if (machine.Soda.SodaEnum == sodas.Pepsi)
            {
                machine.Price = machine.Soda.GetPrice.PepsiPrice;
                return $"You chose Pepsi, that costs {machine.Soda.GetPrice.PepsiPrice}";
            }
            else if (machine.Soda.SodaEnum == sodas.Cola)
            {
                machine.Price = machine.Soda.GetPrice.ColaPrice;
                return $"You chose Coca Cola, that costs {machine.Soda.GetPrice.ColaPrice}";
            }
            return null;
        }

        //gives money back depended on how much you paid
        public string GiveMoneyBack(Machine machine)
        {
            if (machine.MoneyInserted >= machine.Price)
            {
                machine.ReturnMoney = machine.MoneyInserted - machine.Price;
                return $"You get {machine.ReturnMoney} back";
            }
            else
            {
                return "Not enough money";
            }
        }
    }
}
