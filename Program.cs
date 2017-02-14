using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your First Name:");
            string userFirstNam = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string userLastNam = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int userAge =int.Parse(Console.ReadLine());

            Console.WriteLine("What is the number of your birth month:");
            int userBirthMon = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite color from ROYGBIV.");

            Console.WriteLine("Type Help, If you dont know What ROYGBIV stands for. ");
            string colors = "Help";
             colors.ToLower();
             colors = Console.ReadLine();



            if (colors.ToLower() == "help")
                {
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                     colors = Console.ReadLine();
                
                }

                Console.WriteLine("How many siblings do you have? ");
                int userSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine(userFirstNam + "" + userLastNam);

            

                if (userAge % 2 == 0)
                {
                    Console.WriteLine(" will retire in 36 years, ");
                }
                else
                {
                    Console.WriteLine(" will retire in 35 years, ");
                }

                switch (userSiblings)
           
                {
                    case '0':
                        Console.WriteLine(" a vacation home in Utah, ");
                        break;

                    case '1':
                        Console.WriteLine(" a vacation home in New York, ");
                        break;

                    case '2':
                        Console.WriteLine(" a vacation home in Florida, ");
                        break;

                    case '3':
                        Console.WriteLine(" a vacation home in Mexico, ");
                        break;

                    default:
                        Console.WriteLine(" a vacation home in Alaska, ");
                        break;

                }


                switch (colors.ToLower())

                {
                    case "Red":
                        Console.WriteLine(" and a Train, ");
                        break;

                    case "Orange":
                        Console.WriteLine(" and a Boat, ");
                        break;

                    case "Yellow":
                        Console.WriteLine(" and a Car, ");
                        break;

                    case "Green":
                        Console.WriteLine(" and a Bike, ");
                        break;

                    case "Blue":
                        Console.WriteLine(" and Walking, ");
                        break;

                    case "Indigo":
                        Console.WriteLine(" and a Bus, ");
                        break;

                    case "Violet":
                        Console.WriteLine(" and a Taxi, ");
                        break;

                    default:
                        Console.WriteLine("Please enter a color from the ROYGBIV color wheel. Thank You! ");
                        break;
                }


                if (userBirthMon <= 4)
                {
                    Console.WriteLine(" with $60,000 in the bank,");
                }

                else if (userBirthMon >= 5 && userBirthMon <= 8)
                {
                    Console.WriteLine(" with $4,000 in the bank,");
                }

                else if (userBirthMon >= 9 && userBirthMon <= 12)
                {
                    Console.WriteLine(" with $1,000,000 in the bank,");
                }

                else if (userBirthMon <= 0 && userBirthMon > 12)
                {
                    Console.WriteLine(" with $0.00 in the bank,");
                }

            



            }
    }
}
