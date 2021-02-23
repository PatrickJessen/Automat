using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Machine
    {
        public Sodas Soda { get; set; }
        public double MoneyInserted { get; set; }
        public double ReturnMoney { get; set; }
        public double Price { get; set; }

        public Machine(int faxePrice, int pepsiPrice, int colaPrice)
        {
            Soda = new Sodas();
            Soda.GetPrice = new Price(faxePrice, pepsiPrice, colaPrice);
        }
    }
}
