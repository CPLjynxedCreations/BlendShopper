using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlendShopper
{
    public static class PlayerControl
    {

        public static string playerMoney = "100";
        //would be in ShopManager.cs
        public static string amount;

        public static void Buy()
        {
            //playermoney - amount
            amount = "50";
        }
    }
}
