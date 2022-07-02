﻿namespace RevisedProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decadent decadent = new Decadent()
            {
                Name = "Decadent Dessert Bar",
                Review = 4.7f,
                Distance = 8.9f,
                Price = "$$",
                OrderOnline = false
            };

            BetweenFriends betweenFriends = new BetweenFriends()
            {
                Name = "Between Friends Coffee",
                Review = 4.9f,
                Distance = 8.9f,
                Price = "$",
                OrderOnline = true
            };

            Vignette vignette = new Vignette()
            {
                Name = "Cafe Vignette",
                Review = 4.1f,
                Distance = 1.7f,
                Price = "$$$",
                OrderOnline = true
            };

            Starbucks starbucks = new Starbucks()
            {
                Name = "Starbucks",
                Review = 4.3f,
                Distance = 6.7f,
                Price = "$$",
                OrderOnline = true
            };

            Console.WriteLine("Cafes in Warner Robins:\nDecadent Dessert Bar\nBetween Friends Coffee\nCafe Vignette\nStarbucks");
            Console.WriteLine("\n[Find details about a specific cafe]");  

            while (true)
            {
                Console.WriteLine("Select a cafe:");
                Console.WriteLine("\n1) Decadent Dessert Bar\n2) Between Friends Coffee\n3) Cafe Vignette\n4) Starbucks");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        decadent.seeDetails();
                        while (true)
                        {                            
                            Console.WriteLine("\n1) See drink menu\n2) See food menu\n3) See coffee flavors 4) Exit");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                decadent.SeeMenu();
                            }
                            else if (choice == "2")
                            {
                                decadent.seeFood();                                
                            }
                            else if (choice == "3")
                            {
                                decadent.seeFlavors();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;

                    case 2:
                        betweenFriends.seeDetails();
                        while (true)
                        {
                            Console.WriteLine("\n1) See drink menu\n2) See food menu\n3) See books avaliable\n4) Exit");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                betweenFriends.SeeMenu();
                            }
                            else if (choice == "2")
                            {
                                betweenFriends.seeFood();
                            }
                            else if (choice == "3")
                            {
                                betweenFriends.seeBooks();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        vignette.seeDetails();
                        while (true)
                        {
                            Console.WriteLine("\n1) See drink menu\n2) See food menu\n3) Exit");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                betweenFriends.SeeMenu();
                            }
                            else if (choice == "2")
                            {
                                betweenFriends.seeFood();
                            }
                            else if (choice == "3")
                            {
                                betweenFriends.seeBooks();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 4:
                        starbucks.seeDetails();
                        break;
                    default:
                        Console.WriteLine("Invalid option, moving on");
                        break;
                }

                // want to 

            }
        }
    }
}