using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Please Enter a Number : ");

            double d = Convert.ToDouble(Console.ReadLine());
            int i = Convert.ToInt32(d);
            Console.WriteLine("the Number in int is :{0}", i);
            Console.WriteLine("Your Number in double is :{0}", d);

            Console.WriteLine("\n\n\n");

            /////////////////////////////////////////////////

            Console.WriteLine("3- Please Enter a Number :");
            string s = Console.ReadLine();
            Console.WriteLine("Your String aftar Using ToString() :" + s.ToString());

            Console.WriteLine("\n\n\n");

            ///////////////////////////////////////////////

            string sUpper = "Uppercase: C# IS FUN!";
            string sLowar = "Lowercase: c# is fun!";

            Console.WriteLine(sUpper.ToUpper());
            Console.WriteLine(sUpper.ToLower());

            Console.WriteLine("\n\n\n");

            /////////////////////////////////////
            ///

            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            String LastName = Console.ReadLine();

            string Full = firstName + " " + LastName;

            int len = firstName.Length + LastName.Length;

            Console.WriteLine("The Length of Full Name is : {0}", len);
            Console.WriteLine("\n\n\n");


            //////////////////////////////////////////


            Console.WriteLine("The Min Value is : "+min1());
            Console.WriteLine("\n\n\n");

            //////////////////////////////////////

            Killo();
            Console.WriteLine("\n\n\n");

            /////////////////////////////////////////////////////
            ///

            Console.WriteLine(minutes());

            Console.WriteLine("\n\n\n");

            /////////////////////////////////////////////////////


            Console.WriteLine("The Hours is {0}", minutes2());
            Console.WriteLine("\n\n\n");


            ////////////////////////////////////////////////////////




            Console.WriteLine("Plz Enter Tow Numbers To Compare ");

            double xNum1x = Convert.ToDouble(Console.ReadLine());
            double xNum2x = Convert.ToDouble(Console.ReadLine());
            string result = "";
            Console.WriteLine(Compare(xNum1x, xNum2x,ref result));
            Console.WriteLine($" between {xNum1x} and {xNum2x} : {result}" );

            Console.WriteLine("\n\n\n");


            ////////////////////////////////////////////////////////////////////////////////////////
            ///


            Console.WriteLine("Plz Enter a Number To Calculate : ");

            string r = Console.ReadLine();
            int sum = 0;
            for (int iii = 0; iii < r.Length; iii++)
            {
                char c1 = (char)Convert.ToInt32(r[iii]);
                string s11 = c1.ToString();
                int e = int.Parse(s11);

                sum += e;

 
            }

            Console.WriteLine("The Sum is : "+ sum);
            Console.WriteLine("\n\n\n");


            ////////////////////////////////////////////////////////////////////////////
            ///


            Console.WriteLine("Plz Enter Numbers to Revers  .. .");

            string arr1 = Console.ReadLine(); 
            int[] arr2 = new int[arr1.Length];


            int counter = arr1.Length -1;
            for (int z = 0; z < arr1.Length; z++)
            {
                char c1 = (char)Convert.ToInt32(arr1[z]);
                string s11 = c1.ToString();
                int e = int.Parse(s11);

                arr2[counter] = e;
                counter--;
            }



            for (int y = 0; y < arr2.Length; y++)
            {
                Console.Write(arr2[y]);
            }



            Console.WriteLine("\n\n\n");





            Console.WriteLine("Please Enter Tow Number To Check if Divisible .. .");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 % number2 == 0)
                Console.WriteLine("Divisible");
            else
                Console.WriteLine("Not Divisible");

            Console.WriteLine("\n\n\n");



            Console.WriteLine("Enter Three Number To Find the Middle Value");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int middle;

            if ((num1 >= num2 && num1 <= num3) || (num1 <= num2 && num1 >= num3))
            {
                middle = num1;
            }
            else if ((num2 >= num1 && num2 <= num3) || (num2 <= num1 && num2 >= num3))
            {
                middle = num2;
            }
            else
            {
                middle = num3;
            }

            Console.WriteLine("The middle value is: " + middle);





        }


        public static double Compare(double num1, double num2, ref string b)
        {

             b = (num1 == num2) ? "Smaller" :
                     (num1 < num2) ? "Smaller":
                       "Greater";
            double xxx = num1 + num2;
            return xxx; 

        }


        public static double min1()
        {
            Console.WriteLine("Please Enter Tow Number : ");

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            double i1;
            double i2;

            bool x = double.TryParse(num1, out i1);
            bool y = double.TryParse(num2, out i2);

            if (x && y)
            {
                if (i1 < i2)
                    return i1;
                else return i2;
            }

            return 0;

        }

        public static void Killo(){

            Console.WriteLine("Enter Your K/Hr to Convert To Miles :");
            double k = Convert.ToDouble(Console.ReadLine());

            double sum = 0.6213711922 * k;
            Console.WriteLine(" The M = " + sum);
            }


        public static int minutes()
        {
            Console.WriteLine("Please Enter an hour");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter an minutes");
            int m = Convert.ToInt32(Console.ReadLine());

            return (h * 60) + m;
        }




        public static double minutes2()
        {
            Console.WriteLine("Please Enter The minutes :");

            double d = Convert.ToDouble(Console.ReadLine());

            return (d / 60);

        }
    }
}
