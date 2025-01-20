using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3oop
{
    public class Room
    {
        public int roomNumber;
        public string roomType;
        public double Price;
        public bool IsBooked;
        public const string HotelName = "Grand Stay Hotel";
    }
    internal class Program
    {
        static void Main(string[] args)
        {


           
            Room room = new Room();

            Console.WriteLine("Please Enter room number :");
            int numberOfRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter room Type : Single, Double, Suite");
            string typeOfRoom = Console.ReadLine();
            Console.WriteLine("Please Enter room Price :");
            double PriceOfRoom = Convert.ToDouble(Console.ReadLine());


            room.roomNumber = numberOfRoom;
            room.Price = PriceOfRoom;
            room.roomType = typeOfRoom; ;

            Console.WriteLine("\n\n\n");


            odd();
            Console.WriteLine("\n\n\n");

            smallest();
            Console.WriteLine("\n\n\n");

            factorial();
            Console.WriteLine("\n\n\n");

            prime();
            Console.WriteLine("\n\n\n");

            prime();
            Console.WriteLine("\n\n\n");

            largest();
            Console.WriteLine("\n\n\n");

            pattern();
            Console.WriteLine("\n\n\n");




        }


        public static void pattern()
        {
            Console.WriteLine("Please Enter a number .. .");
            int numm = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 1; i <= numm; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter+ " ");
                    counter++;

                }
                Console.WriteLine();
            }

        }
        public static void largest()
        {
            Console.WriteLine("Plz Enter 6 Number to Find largest number .. .");
            int[] arr2 = new int[6];
            for (int i = 0; i < 6; i++)
            {
               arr2[i]= int.Parse(Console.ReadLine());
            }

            int largest = arr2[0];
            foreach(int i in arr2)
            {
                if (largest < i)
                    largest = i;
            }
            Console.WriteLine("The largest Number is {0}",largest);
        }


        public static void odd()
        {
            Console.WriteLine("Please Enter a Number To Check if Odd or Even .. .");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Number ({0}) is Even", num);
            else
                Console.WriteLine("Number ({0}) is Odd", num);
        }


        public static void smallest()
        {
            Console.WriteLine("Plz Enter 5 Number to Check 2nd smallest of the five .. .");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);

            Console.WriteLine("2nd smallest of the five is : {0}", arr[1]);

        }


        public static void factorial()
        {

            Console.WriteLine("Plz Enter a Number To calculates the factorial .. .");

            int num1 = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("factorial of {0} is {1}", num1, factorial);
        }


        public static void prime()
        {
            Console.WriteLine("Please Enter Two Numbers To print all the prime numbers between them: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int big;
            int small;

            if (num1 < num2)
            {
                big = num2;
                small = num1;
            }
            else
            {
                big = num1;
                small = num2;
            }

            if (big < 2)
            {
                Console.WriteLine("No Number is Prime.");
            }
            else
            {
                Console.WriteLine("Prime numbers between {0} and {1}:", small, big);

                for (int i = small; i <= big; i++)
                {
                    if (i % 2 == 0)
                        continue;
                    else
                    {
                        bool isPrime = false;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                            else isPrime = true;

                        }
                        if (isPrime)
                            Console.Write(i + " ");
                    }
                }
            }

        }
    }
}

