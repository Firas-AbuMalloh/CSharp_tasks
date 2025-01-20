using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tasks
{
    

    internal class Program
    {

        static void Main(string[] args)
        {

           


            //1 - Create console application that read string from user and print the same string

            Console.WriteLine("Plz Enter a String .. " + "\n ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Your Enter is : {0}", s1);


            double d = 1.1;
            string s = "Firas";
            char c = 'a';
            bool b = true;
            int num = 0;
            const int x = 1;

            Console.WriteLine(d);
            Console.WriteLine(s);

            Console.WriteLine(c);

            Console.WriteLine(b);
            Console.WriteLine(num);

            Console.WriteLine(x);

            //////////////////////////////////
            ///

            string[] car = { "BMW", "Volvo", "Kia" };

            for (int i = 0; i < car.Length; i++)
            {

                Console.WriteLine(car[i]);
            }
            //////////////////////////////////////////////
            ///


            Console.WriteLine("Input your firstname: ");

            string firstname = Console.ReadLine();

            Console.WriteLine("Input your last Name : ");

            string lastName = Console.ReadLine();


            Console.WriteLine("Input your year of birth");
            string age = Console.ReadLine();

            Console.WriteLine("Your Input is :{0} {1} {2}", firstname, lastName, age);


            Console.WriteLine("Input 10 elements in the array  : ");
            int[] arr = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("element - {0} : {1}", i, arr[i]);
            }



        }
    }


  
}