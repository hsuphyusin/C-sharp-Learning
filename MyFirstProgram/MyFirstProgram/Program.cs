using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace MyFirstProgram
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            String name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your gender?");
            string gender = Console.ReadLine();

            Console.WriteLine("What is your ID?");
            int ID = Convert.ToInt32(Console.ReadLine());

            if (gender == "male")
            {
                if (age >= 50)
                {
                    Console.WriteLine("You can't Sayy Htoe");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("You can Sayy Htoe with 18mm.");
                }
                else if (age >= 10)
                {
                    Console.WriteLine("You can Sayy Htoe with 10mm.");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("Impossible number.");
                }
                else if (age <= 10)
                {
                    Console.WriteLine("You can't Sayy Htoe.");
                }
            }
            else
            {
                if (ID >= 301)
                {
                    Console.WriteLine("You are Senior.");
                }
                else if (ID >= 101)
                {
                    Console.WriteLine("You are Junior.");
                }
                else if (ID < 100)
                {
                    Console.WriteLine("You are Senior.");
                }
                else if (ID < 0)
                {
                    Console.WriteLine("Your ID is invalid.");
                }
            }
               
            

                /*string fullName = "Hsu Phyu Sin";
                string phoneNo = "123-456-789";
                phoneNo = phoneNo.Replace("-","");

                fullName = fullName.Insert(0, "M");

                Console.WriteLine(phoneNo);*/

                Console.ReadKey();
            
            






        }
    }
}