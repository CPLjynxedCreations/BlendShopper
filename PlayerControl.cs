using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlendShopper
{
    public static class PlayerControl
    {
        public static int intPlayerMoney;
        public static string strPlayerMoney = "100";
        
        
        //would be in ShopManager.cs
        public static int intItemAmount;

        //stays in playercontrol
        public static void ConvertToInt()
        {
            intPlayerMoney = Convert.ToInt32(strPlayerMoney);
        }
        public static void ConvertToString()
        {
            strPlayerMoney = Convert.ToString(intPlayerMoney);
        }

        //would be in ShopManager.cs
        public static void Buy()
        {
            //playermoney - amount
            intItemAmount = 50;
            intPlayerMoney -= intItemAmount;
        }
    }
}
