using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Snack : VendingMachine
    {
        public static Candy Hotdog = new Candy { Name = "Hotdog", Price = 16M, ID = 1 };
        public static Candy Cookies = new Candy { Name = "Cookies", Price = 21M, ID = 2 };

        public static List<Candy> snackMenu = new List<Candy>
        {
            Hotdog,
            Cookies,

        };
    }
}
