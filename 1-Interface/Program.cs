using System;

namespace _1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool validInput = false;
            //Console.WriteLine("Please input the 10 digit the phone number");
            //while (validInput == false)
            //{
            //    string input = Console.ReadLine();
            //    if (input.Length != 10)
            //    {
            //        Console.WriteLine($"{input} is not the valid phone number lenght, please re-input the number");
            //    }
            //    else
            //    {
            //        validInput = true;
            //        var number = new PhoneNumber(input);
            //        Console.WriteLine(number.ToString());
            //        var a = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("Please input the 10 digit the phone number");
            //string input = Console.ReadLine();
            //var number = new PhoneNumber(input);
            //Console.WriteLine(number.ToString());
            //var a = Console.ReadLine();


            bool keepGoing = true;
            string userChoice;

            while (keepGoing)
            {
                userChoice = TestInterface.GetRecordType();

                switch (userChoice)
                {
                    case "0":
                        keepGoing = false;
                        return;
                    case "1":
                        try
                        {
                            Console.WriteLine("Please enter the 10 digit phone number");
                            string input = Console.ReadLine();
                            var phoneNumber = new PhoneNumber(input);
                            Console.WriteLine($"Formatted number is {phoneNumber.ToString()}");
                        }
                        catch(ArgumentOutOfRangeException)
                        { Console.WriteLine("invalid input, please try again"); }
                        catch(FormatException)
                        { Console.WriteLine("invalid format, please try again"); }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Please enter the 9 digit social security number");
                            string input = Console.ReadLine();
                            var ssn = new SocialSecurityNumber(input);
                            Console.WriteLine($"Formatted number is {ssn.ToString()}");
                        }
                        catch (ArgumentOutOfRangeException)
                        { Console.WriteLine("invalid input, please try again"); }
                        catch (FormatException)
                        { Console.WriteLine("invalid format, please try again"); }
                        break;
                        
                    default:
                        break;
                
                }
                
            }


        }
    }
    
}
