using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFour.Generics.DynamicOnlineMarketplace
{
    class MarketplaceMain
    {
        static void Main()
        {
            MarketplaceMenu menu = new MarketplaceMenu();
            menu.Start();   // changed from ShowMenu()

            Console.ReadLine();
        }
    }
}
