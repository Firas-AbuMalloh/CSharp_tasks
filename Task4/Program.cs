using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program //Class 
    {
        class student // Class
        {
            private int Id; //Filds
            public int _Id // property 
            {
                get
                {
                    return Id;
                }
                set
                {
                    if (value > 0) 
                    Id= value;
                        else
                        Id = 0;
                }
            }
            private string Name; //field 
            public string _Name //property 
            {
                get
                {
                    return Name;
                }
                set
                {
                    if (value != "")
                        Name = value;
                    else
                        Name = "Firas Abumalloh";
                }
            }
            private int Age; //field 
            public int _Age //property 
            {
                get
                {
                    return Age;
                }
                set
                {
                    if (value > 18)
                        Age = value;
                    else
                        Age = 18;
                }
            }

            public string Email { get; set; } // Auto property 
            public const int MinAge = 18; // Constant field 
            public const int MaxAge = 40; // Constant field 

            public void GetDetails() // method to return All Student Details
            {
                Console.WriteLine("Student ID : {0} \nStudent Name : {1} \nStudent Age : {2}", Id, Name, Age);
            }

            public student(int _id, int _age, string _name) // Constructor with 3 parametars
            {
                Id = _id;
                Name = _name;
                Age = _age;
            }

            ~student() // Destructor
            { 
                Console.WriteLine("De-STRUCTOR IS CALLED . . .");
            }
            static void Main(string[] args)
            {
                student std = new student(1001, 22, "Ahmad");
                std.GetDetails();



                student std2 = new student(1002, 30, "Firas");
                std2 .GetDetails();
            }
        }
    }
}



// 1-	What is class  :
// a class is a blueprint or template for creating objects.
// It defines the structure, behavior, and attributes of those objects.



//2-	What is object
//object is an instance of a class

//3-    Mention the OOP Principles

//Encapsulation
//    Inheritance
//    Polymorphism
//    Abstraction

//4 - What is field
//    field is a variable that is declared directly within a class or struct

//What is encapsulation
//encapsulation is a fundamental concept in object-oriented programming



