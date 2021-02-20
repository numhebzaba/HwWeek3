using System;

namespace HwWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Password 6 digit : ");
            int passWord = int.Parse(Console.ReadLine());

            Console.Write("Password2 : ");
            string agency = Console.ReadLine();

            if (agency == "CIA")
            {

                if ((passWord % 10) % 3 == 0 
                    && (passWord / 10) % 10 != 1 
                    && (passWord / 10) % 10 != 3 
                    && (passWord / 10) % 10 != 5 
                    &&(passWord / 1000) % 10 >= 6 
                    && (passWord / 1000) % 10 != 8)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("Flase");
                }
            }


            if (agency == "FBI")
            {
                if ((passWord / 100000) % 10 >= 4 
                    && (passWord / 100000) % 10 <= 7 
                    && ((passWord / 100) % 10) %2 == 0 
                    && (passWord / 100) % 10 != 6 
                    && ((passWord / 10000) % 10) % 2 == 1)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("Flase");
                }
            }


            if (agency == "NSA")
            {
                if ((passWord % 10)  == 1
                    || (passWord % 10)  == 2
                    || (passWord % 10)  == 3
                    || (passWord % 10)  == 5
                    || (passWord % 10)  == 6
                    || ((passWord / 100) % 10) % 3 == 0
                    || ((passWord / 100) % 10) % 2 != 0)
                {
                    if (((passWord / 100) % 10) % 3 == 0
                    && ((passWord / 100) % 10) % 2 != 0)
                    {
                        if ((passWord / 10) % 10 == 7
                        || (passWord / 1000) % 10 == 7
                        || (passWord / 10000) % 10 == 7
                        || (passWord / 100000) % 10 == 7)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("Flase");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Flase");
                    }


                }
                else
                {
                    Console.WriteLine("Flase");
                }

                Console.ReadLine();
            }
        }
    }
}
