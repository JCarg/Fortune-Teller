using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the most accurate virtual fortune telling system on the web.");
                Console.WriteLine("Let's Begin!\a");

                //Name Info
                Console.WriteLine("What is your first name? Type answers below.");
                string firstname = Console.ReadLine();
                Console.WriteLine("\nWhat is your last name?");
                string lastname = Console.ReadLine();

                //Age Info
                Console.WriteLine("\nWhat is your age?");
                int age = int.Parse(Console.ReadLine());
                string years = " ";
                string ageodd = "800 Years";
                string ageeven = "5 years";
                if (age % 2 > 0)
                {
                    years = ageodd;
                }
                else
                {
                    years = ageeven;
                }


                //Birth month Info
                Console.WriteLine("\nWhat is your birth month? Ex: October = 10");
                int birthmonth = int.Parse(Console.ReadLine());
                if (birthmonth >= 1 && birthmonth <= 4)
                {
                    int janaprilcash = 1000000;
                    birthmonth = janaprilcash;
                }
                else if (birthmonth >= 5 && birthmonth <= 8)
                {
                    int mayaugustcash = 500000;
                    birthmonth = mayaugustcash;
                }
                else if (birthmonth >= 9 && birthmonth <= 12)
                {
                    int septdecemcash = 2;
                    birthmonth = septdecemcash;
                }
                else
                {
                    int nomonth = 0;
                    birthmonth = nomonth;
                }

                //Favorite Color Info
                Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                Console.WriteLine("If you would a list of ROYGBIV colors type help.");
                string color = Console.ReadLine();
                string help = color.ToLower();
                if (help == "help")
                {
                    Console.Write("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n");
                    Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                    string helpcolor = Console.ReadLine();
                    color = helpcolor.ToLower();
                switch (color)
                {
                    case ("red"):
                        string redtransportation = "Maserati";
                        color = redtransportation;
                        break;
                    case ("blue"):
                        string bluetransportation = "The Tardis";
                        color = bluetransportation;
                        break;
                    case ("orange"):
                        string orangetransportation = "Hot air balloon";
                        color = orangetransportation;
                        break;
                    case ("yellow"):
                        string yellowtransportation = "Your Feet";
                        color = yellowtransportation;
                        break;
                    case ("green"):
                        string greentransportation = "Giant Squirrel";
                        color = greentransportation;
                        break;
                    case ("indigio"):
                        string indigotransportation = "Unicorn";
                        color = indigotransportation;
                        break;
                    case ("violet"):
                        string violettransportation = "Solid Rainbow";
                        color = violettransportation;
                        break;
                }

            }
                switch (color)
                {
                    case ("red"):
                        string redtransportation = "Maserati";
                        color = redtransportation;
                        break;
                    case ("blue"):
                        string bluetransportation = "The Tardis";
                        color = bluetransportation;
                        break;
                    case ("orange"):
                        string orangetransportation = "Hot air balloon";
                        color = orangetransportation;
                        break;
                    case ("yellow"):
                        string yellowtransportation = "Your Feet";
                        color = yellowtransportation;
                        break;
                    case ("green"):
                        string greentransportation = "Giant Squirrel";
                        color = greentransportation;
                        break;
                    case ("indigio"):
                        string indigotransportation = "Unicorn";
                        color = indigotransportation;
                        break;
                    case ("violet"):
                        string violettransportation = "Solid Rainbow";
                        color = violettransportation;
                        break;
                }


                //Sibling Info
                Console.WriteLine("\nHow many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());
                string oddsib = "The Arctic Circle";
                string vacation = "";
                switch (siblings)
                {
                    case 0:
                    string nosib = "Ancient Rome";
                    vacation = nosib;
                    break;
                    case 1:
                        string onesib = "the crab nebula";
                        vacation = onesib;
                        break;
                    case 2:
                        string twosib = "a Deserted Alley";
                        vacation = twosib;
                        break;
                    case 3:
                        string threesib = "the Center of the Earth";
                        vacation = threesib;
                        break;
                    default:
                        vacation = oddsib;
                        break;
                }
                //End Game
                Console.WriteLine("Thanks for playing! Here is your fortune:");
                Console.Write(firstname + " " + lastname + " will retire in " +years+ " with $" + birthmonth + " in the bank, a vacation home in " + vacation+" and a " + color+"\n for transportation.\a\n");
            }
        }
    }            
