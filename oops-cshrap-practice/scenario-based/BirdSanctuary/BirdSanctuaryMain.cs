using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
     public  class BirdSanctuaryMain
    {
       public static void Main(string[] args)
        {
            EBird[] birds =
            {
                new Eagle("Chidiya"),
                new Sparrow("Choti Chidiya"),
                new Duck("Battak"),
                new Penguin("Penguin"),
                new Seagull("pani ka gul")
            };

            SanctuaryMenu menu = new SanctuaryMenu(birds);
            menu.ShowMenu();
        }
    }
}
