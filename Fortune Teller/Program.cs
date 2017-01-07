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


            Console.WriteLine("What is your first name? Type answers below.");
            string firstname=Console.ReadLine();
            Console.WriteLine("\nWhat is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("\nWhat is your age?");
            int age = int.Parse(Console.ReadLine());
            short oddretireyears = 800;
            byte evenretireyears = 5;
            if (age%2>0)
            {
                Console.WriteLine("You will retire in " + oddretireyears + " years.");
            }      
            else
            {
                Console.WriteLine("You will retire in " + evenretireyears + " years.");
            }


            Console.WriteLine("\nWhat is your birth month? Ex: October = 10");
            int birthmonth = int.Parse(Console.ReadLine());
            float janaprilcash = 1000000.00f;
            float mayaugustcash = 500000.00f;
            float septdecemcash = .02f;
            if (birthmonth>=1&&birthmonth<=4)
            {
                Console.WriteLine("You will have $" + janaprilcash + " in the bank.");
            }
            else if (birthmonth >= 5 && birthmonth <= 8)
            {
                Console.WriteLine("You will have $" + mayaugustcash + " in the bank.");
            }
            else if (birthmonth >= 9 && birthmonth <= 12)
            {
                Console.WriteLine("You will have $" + septdecemcash + " in the bank.");
            }
            else
            {
                Console.WriteLine("You will have $0.00 in the bank.");
            }

            Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
            Console.WriteLine("If you would a list of ROYGBIV colors type help.");
            string color = Console.ReadLine();
            string redtransportation = "Maserati";
            string orangetransportation = "Hot air balloon";
            string yellowtransportation = "Your Feet";
            string greentransportation = "Giant Squirrel";
            string bluetransportation = "The Tardis";
            string indigotransportation = "Unicorn";
            string violettransportation = "Solid Rainbows";
            string help = color.ToLower();
            if (help == "help")
            {
                Console.Write("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n");
                Console.WriteLine("\nWhat is your favorite ROYGBIV color?");  
                string helpcolor = Console.ReadLine();
                color = helpcolor.ToLower();
            }

            switch (color)
            {
                case ("red"):
                    Console.WriteLine("Your main mode of transportation will be "+redtransportation+".");
                    break;
                case ("blue"):
                    Console.WriteLine("Your main mode of transportation will be "+bluetransportation+".");
                    break;
                case ("orange"):
                    Console.WriteLine("Your main mode of transportation will be " + orangetransportation + ".");
                    break;
                case ("yellow"):
                    Console.WriteLine("Your main mode of transportation will be " + yellowtransportation + ".");
                    break;
                case ("green"):
                    Console.WriteLine("Your main mode of transportation will be " + greentransportation + ".");
                    break;
                case ("indigio"):
                    Console.WriteLine("Your main mode of transportation will be " + indigotransportation + ".");
                    break;
                case ("violet"):
                    Console.WriteLine("Your main mode of transportation will be " + violettransportation + ".");
                    break;
            }


        }
    }
}
