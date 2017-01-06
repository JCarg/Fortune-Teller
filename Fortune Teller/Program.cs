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


            Console.WriteLine("What is your birth month? Ex: October = 10");
            byte birthmonth = byte.Parse(Console.ReadLine());
            int janaprilcash = 10000000;
            if (birthmonth>=1&&birthmonth<=4)


            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("If you would a list of ROYGBIV colors type help.");
            string color = Console.ReadLine();
            string help = color.ToLower();
            Console.WriteLine(color);
            if (help == "help")
            {
                Console.Write("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n");
            }

        }
    }
}
