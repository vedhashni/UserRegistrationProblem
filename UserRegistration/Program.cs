using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to validating User Registration using Regular Expression");
            RegexExample regex = new RegexExample();
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the First Name");
                    string input = Console.ReadLine();
                    RegexExample.ValidatingFirstName(input);
                    break;

                case 2:
                    Console.WriteLine("Enter the Last Name");
                    string input1 = Console.ReadLine();
                    RegexExample.ValidatingLastName(input1);
                    break;

                case 3:
                    Console.WriteLine("Enter Email Id");
                    string input2 = Console.ReadLine();
                    RegexExample.ValidatingEmailId(input2);
                    break;

                case 4:
                    Console.WriteLine("Enter Phone Number");
                    string input3 = Console.ReadLine();
                    RegexExample.ValidatingPhoneNumber(input3);
                    break;

                case 5:
                    Console.WriteLine("Enter Password");
                    string input4 = Console.ReadLine();
                    RegexExample.ValidatingPassWord(input4);
                    break;

                default:
                    break;
            }
        }
    }
}
