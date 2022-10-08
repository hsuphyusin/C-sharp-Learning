
using System;
using System.Net.Sockets;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           const string ADDRESS = "Mandalay";
           const string YES = "y";
           bool isfinished = false; 
           int id = 1;
           string name,email,phone,gender,address;

           Console.WriteLine("What is your name?");
           name = Console.ReadLine();

           Console.WriteLine("What is your Email?");
           email = Console.ReadLine();

           Console.WriteLine("What's your phone?");
           phone = Console.ReadLine();

           Console.WriteLine("What's your gender?");
           gender = Console.ReadLine();

           Console.WriteLine("What's your address?");
           address = Console.ReadLine();

           if (address == ADDRESS && !isfinished)
           {
              Console.WriteLine("You can submit your submit.");
              Console.WriteLine("Your id is:" + id);
              id++;
              isfinished = true;
           }
           else
           {
              Console.WriteLine("You can't submit your request!");
           }
           while (id <= 100)
           {
              Console.WriteLine("another student y/n:");
              var anotherstudent = Console.ReadLine();
              if (anotherstudent == YES)
              {
                isfinished = false;
                
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                Console.WriteLine("What is your Email?");
                email = Console.ReadLine();

                Console.WriteLine("What's your phone?");
                phone = Console.ReadLine();

                Console.WriteLine("What's your gender?");
                gender = Console.ReadLine();

                Console.WriteLine("What's your address?");
                address = Console.ReadLine();
                    
                if (address == ADDRESS && !isfinished)
                {
                  Console.WriteLine("You can submit your address.");
                  Console.WriteLine("Your id is:" + id);
                  id++;
                  isfinished =true;
                }
                else
                {
                  Console.WriteLine("You can't submit your request!");
                }   
              }
              else
              {
                break;
              }
           }
          Console.WriteLine("The student submit application is closed.\n Thanks for using our program.);");

                /*string fullName = "Hsu Phyu Sin";
                string phoneNo = "123-456-789";
                phoneNo = phoneNo.Replace("-","");

                fullName = fullName.Insert(0, "M");

                Console.WriteLine(phoneNo);*/

                Console.ReadKey();
            
            






        }

        

    }
}