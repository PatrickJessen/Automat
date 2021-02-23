using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    //enum of the sodas you can buy.
    public enum sodas
    {
        Faxe,
        Pepsi,
        Cola
    }
    class Sodas
    {
        public sodas SodaEnum { get; set; }
        public Price GetPrice { get; set; }
    }
}
