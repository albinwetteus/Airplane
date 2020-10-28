using System;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Welcome to this flight");
                //Console.WriteLine("Please enter number of seats on the airplane");
                //Int32.TryParse(Console.ReadLine(), out int seats);

                int seats = 10;
                var airplane = new Airplane(seats);
                var foodcart = new Foodcart(5);
                
                    
                CreateSampleArticles(foodcart);
                


                 int switchCase = 0;

                while (switchCase != 5)
                {
                    PrintMainMenu();
                    switchCase = Int32.Parse(Console.ReadLine());

                    switch (switchCase)
                    {
                        case 1:
                            int airplaneMenu = 0; 
                            while (airplaneMenu != 5)
                            {
                                Console.Clear();
                                Console.WriteLine("------Airplane Menu-------");
                                Console.WriteLine();
                                Console.WriteLine("1. Show available seats");
                                Console.WriteLine("2. Take off");
                                Console.WriteLine("3. Land");
                                Console.WriteLine("4. Board airplane");
                                Console.WriteLine("5. Back to main menu");
                                airplaneMenu = Int32.Parse(Console.ReadLine());
                                switch (airplaneMenu)
                                {
                                    case 1:
                                        airplane.ShowAvailableSeats();
                                        break;
                                    case 2:
                                        airplane.TakeOff();
                                        break;
                                    case 3:
                                        airplane.Land();
                                        break;
                                    case 4:
                                        airplane.BoardAirplane();
                                        break;

                                    case 5:
                                   
                                    default:
                                        break;
                                }

                            }
                            break;

                        case 5:
                            switchCase = 5;
                            break;
                        default:
                            break;
                    }

                }

            }
        

        private static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("------Main Menu-------");
            Console.WriteLine();
            Console.WriteLine("1. Airplane menu ");
            Console.WriteLine("2. Crew menu ");
            Console.WriteLine("3. Passenger menu ");
            Console.WriteLine("4. Foodcart menu ");
            Console.WriteLine("5. Exit program ");
        }



        private static void CreateSampleArticles(Foodcart foodcart)
        {
            //foodcart.Inventory = new Article[foodcart.NumberOfArticles];
            foodcart.Inventory[0] = new Food("Twix", "Chocolate", false);
            foodcart.Inventory[1] = new Food("Pizza", "Dr.Oetkers", false);
            foodcart.Inventory[2] = new Food("Carrotpuree", "Nestle", true);
            foodcart.Inventory[3] = new Drink("Coca-Cola", false);
            foodcart.Inventory[4] = new Drink("Heineken", true);
        }

    }
}
