using Day24UserRegistration;
using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("ENTER : 1)FirstName/LastName\n2)EmailId\n3)Mobile\n4)Password");
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
                        Console.WriteLine("Enter the Email");
                        string Email = Console.ReadLine();
                        Console.WriteLine(Code.TestName(Email));
                        break;

                    case 3:
                        Console.WriteLine(Code.TestMobile("9112712717"));
                        break;

                    case 4:
                        Console.WriteLine("Enter the password");
                        string passWord = Console.ReadLine();
                        Console.WriteLine(Code.TestPassword(passWord));
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
