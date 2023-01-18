using Day24UserRegistration;
using System;
using System.Linq.Expressions;

using System;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration");
            Console.WriteLine("hint 1. name(first/last) 2.email 3.Mobile number 4.Password 5.User Registration with lambda");
            try
            {
                Validation Code = new Validation();
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("enter the first name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(Code.TestName(firstName));
                        Console.WriteLine("--------------");
                        Console.WriteLine("enter the last name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(Code.TestName(lastName));
                        break;

                    case 2:
                        Console.WriteLine("enter the Email");
                        string Email = Console.ReadLine();
                        Console.WriteLine(Code.TestEmail(Email));                       
                        break;

                    case 3:
                        Console.WriteLine(Code.TestMobile("9112712717"));
                        break;

                    case 4:
                        Console.WriteLine("Enter the password");
                        string passWord = Console.ReadLine();
                        Console.WriteLine(Code.TestPassword(passWord));
                        break;

                    case 5:
                        Console.WriteLine("Lambda Expression");
                        Console.WriteLine("hint 1. name(first/last) 2.email 3.password 4.phone number");
                        int value = Convert.ToInt16(Console.ReadLine());

                        switch (value)
                        {
                            case 1:
                                Console.WriteLine("enter the first name");
                                string input = Console.ReadLine();
                                bool result = Code.ValidationFirstName(input);
                                Result(result);
                                break;
                            case 2:
                                Console.WriteLine("enter the last name");
                                string lastname = Console.ReadLine();
                                bool result1 = Code.ValidationLasttName(lastname);
                                Result(result1);
                                break;
                            case 3:
                                Console.WriteLine("enter the Email");
                                string email = Console.ReadLine();
                                bool result2 = Code.ValidationEmail(email);
                                Result(result2);
                                break;
                            case 4:
                                Console.WriteLine("Enter the password");
                                string Password = Console.ReadLine();
                                bool result3 = Code.ValidationPassword(Password);
                                Result(result3);
                                break;
                            case 5:
                                Console.WriteLine("enter the phone number");
                                string mobile = Console.ReadLine();
                                bool result4 = Code.ValidationMobile(mobile);
                                Result(result4);
                                break;
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Result(bool results)
        {
            if (results == true)
            {
                Console.WriteLine("Validation succusesfully");
            }
            else
            {
                Console.WriteLine("Invalid ");
            }
        }
    }
}
