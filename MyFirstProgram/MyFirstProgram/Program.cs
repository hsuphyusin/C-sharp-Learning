using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Net.WebRequestMethods;

namespace MyFirstProgram
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "\tSchool sumbit application");

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your email address?");
            string email = Console.ReadLine();

            Console.WriteLine("What's your phone number?");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your gender?");
            string gender = Console.ReadLine();

            Console.WriteLine("What's your address?");
            string address = Console.ReadLine();
            
             /*Random random = new Random();
            int IDnumber = random.Next(1,101);
            Console.WriteLine("Your ID number is:" +IDnumber);*/

            if (address == "Mandalay")
            {
               Console.WriteLine("You can submit your request.");
            }
            else
            {
                Console.WriteLine("You can't submit request!);
            } 
             
            int ID = 1;
                                    
            if (gender == "male")
            {
               Console.WriteLine(+2ID);
            }
            else
            {
               Console.WriteLine(++ID);
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