using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
    public class SanctuaryMenu
    {
        private EBird[] birds;
        public SanctuaryMenu(EBird[] birds)
        {
            this.birds = birds;
        }
        public void ShowMenu()
        {
            int select;
            do
            {
                Console.WriteLine("--Bird Sanctuary Menu--");
                Console.WriteLine("1. View All Birds");
                Console.WriteLine("2. All Flying Birds");
                Console.WriteLine("3. All Swimming Birds");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your CHOICE");

                select = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                switch (select)
                {
                    case 1:
                        DisplayAllBirds();
                        break;


                    case 2:
                        DisplayFlyingBirds();
                        break;


                    case 3:
                        DisplaySwimmingBirds();
                        break;


                    case 4:
                        Console.WriteLine("OK! Thankyou...");
                        break;


                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine();
            }
            while (select != 4);
        }
        private void DisplayAllBirds()
        {
            foreach (EBird bird in birds)
            {
                bird.DisplayInfo();
                if (bird is IFlyable flyingBird)
                {
                    flyingBird.Fly();
                }
                if (bird is ISwimmable swimmingBird)
                {
                    swimmingBird.Swim();
                }
                Console.WriteLine();
            }
        }
        private void DisplayFlyingBirds()
        {
            foreach (EBird bird in birds)
            {

                if (bird is IFlyable flyingBird)
                {
                    bird.DisplayInfo();

                    flyingBird.Fly();
                    Console.WriteLine();
                }

            }
        }
        private void DisplaySwimmingBirds()
        {
            foreach (EBird bird in birds)
            {

                if (bird is ISwimmable swimmingBird)
                {
                    bird.DisplayInfo();
                    swimmingBird.Swim();
                    Console.WriteLine();
                }

            }
        }
    }
}