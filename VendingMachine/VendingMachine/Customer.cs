using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Customer
    {
        private decimal money = 100M;
        public decimal Money { get { return money; } set { money = value; } }

        public List<VendingMachine> customerInventoryList = new List<VendingMachine>();


    }
}
