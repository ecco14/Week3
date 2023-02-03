using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the speed limit: ");
            
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The speed limit is now set to " + speedLimit); //This code sets the speed limit. User defined.

                Car a = new Car(); //Car A created.

            Console.WriteLine("What is the make of the first car: "); //Car Make
            a.make = Console.ReadLine();

            Console.WriteLine("What is the model of the first car: "); //Car Model.
            a.model = Console.ReadLine();

            Console.WriteLine("What is the speed of the first car: "); //Car speed.
            a.speed = Convert.ToInt32(Console.ReadLine());

            if (speedLimit < a.speed) //Begin the magical math calculations.
            {
                int spd = a.speed - speedLimit;

                int demerits = spd / 5; //Divides the speed difference by 5 to calculate demerit amount.

                if (demerits >= 5)  //If demerits are equal to or greater than 5, license suspention code triggers.
                {
                    Console.WriteLine("This driver will have his license suspended! ");
                }

                Console.WriteLine("Warning! This vehicle is traveling " + spd + " mph over the speed limit!");  //begin statement if car is speeding, but not 25 mph over speed limit.
                Console.WriteLine("The driver of this vehicle will have " + demerits + " demerits added to his license!");

            }
            else
            {
                Console.WriteLine("No ticket needed. ");
            }

            Car b = new Car(); //This is the second car comparitor.

            Console.WriteLine("What is the make of the second car: ");
            b.make = Console.ReadLine();

            Console.WriteLine("What is the model of the second car: ");
            b.model = Console.ReadLine();

            Console.WriteLine("What is the speed of the second car: ");
            b.speed = Convert.ToInt32(Console.ReadLine());

            if (speedLimit < b.speed)
            {
                int spd = b.speed - speedLimit;
                int demerits = spd / 5;

                if (demerits >= 5)
                {
                    Console.WriteLine("This driver will have his license suspended! ");
                }

                Console.WriteLine("Warning! This vehicle is traveling " + spd + " mph over the speed limit!");
                Console.WriteLine("The driver of this vehicle will have " + demerits + " demerits added to his license!");

            }
            else
            {
                Console.WriteLine("No ticket needed. ");
            }
            Car c = new Car();  //This is the third car comparitor.

            Console.WriteLine("What is the make of the third car: ");
            c.make = Console.ReadLine();

            Console.WriteLine("What is the model of the third car: ");
            c.model = Console.ReadLine();

            Console.WriteLine("What is the speed of the third car: ");
            c.speed = Convert.ToInt32(Console.ReadLine());

            if (speedLimit < c.speed)
            {
                int spd = c.speed - speedLimit;
                int demerits = spd / 5;

                if (demerits >= 5)
                {
                    Console.WriteLine("LICENSE SUSPENSION: ENABLED!");
                }

                Console.WriteLine("Warning! This vehicle is traveling " + spd + " mph over the speed limit!");
                Console.WriteLine("The driver of this vehicle will have " + demerits + " demerits added to his license!");

            }
            else
            {
                Console.WriteLine("No ticket needed. ");
            }

            
        }

        public class Car
        {
            public string make;
            public string model;
            public int speed;

           
        }

    }
}
