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
                    regex.ValidatingFirstName();
                    break;

                case 2:
                    regex.ValidatingLastName();
                    break;

                case 3:
                    regex.ValidatingEmailId();
                    break;

                case 4:
                    regex.ValidatingPhoneNumber();
                    break;

                default:
                    break;
            }
        }
    }
}
