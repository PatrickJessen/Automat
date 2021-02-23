using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Price
    {
        public double FaxePrice { get; }
        public double PepsiPrice { get; }
        public double ColaPrice { get; }

        //set the price of the sodas
        public Price(int faxePrice, int pepsiPrice, int colaPrice)
        {
            FaxePrice = faxePrice;
            PepsiPrice = pepsiPrice;
            ColaPrice = colaPrice;
        }
    }
}
