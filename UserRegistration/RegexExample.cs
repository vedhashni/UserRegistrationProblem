using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// UC1 - Validating the First Name
    /// UC2 - Validating the Last Name
    /// UC3 - Validating the EmailID
    /// UC4 - Validating the PhoneNumber
    /// UC5 - Password with 8 minimum character
    /// UC6 - Atleast one uppercase in 8 min char
    /// UC7 - Atleast one digit in 8 min char
    /// UC8 - Atleast one special character in 8 min char
    /// </summary>
    class RegexExample
    {
        string userpattern = "^[A-Z][a-z]{2,}$";
        string[] EmailInput = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
        string pattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
        public void ValidatingFirstName()
        {
            Console.WriteLine("Validating the First Name");
            Regex regex = new Regex(userpattern);
            Console.WriteLine("Enter the First Name");
            string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void ValidatingLastName()
        {
            Console.WriteLine("Validating the Last Name");
            Regex regex = new Regex(userpattern);
            Console.WriteLine("Enter the Last Name");
            string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void ValidatingEmailId()
        {
            
            Regex regex = new Regex(pattern);
            for (int i = 0; i < EmailInput.Length; i++)
            {
                bool validemail = regex.IsMatch(EmailInput[i]);
                if (validemail)
                {
                    Console.WriteLine(EmailInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(EmailInput[i] + " ----->Invalid");
                }
            }

        }

        public void ValidatingPhoneNumber()
        {
            string[] PhoneNumberInput = { "91 9843801062", " 91 8939620291", "919894571810", "B789023", "98#1234" };
            string PhoneNumberPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(PhoneNumberPattern);
            for (int i = 0; i < PhoneNumberInput.Length; i++)
            {
                bool validnum = regex.IsMatch(PhoneNumberInput[i]);
                if (validnum)
                {
                    Console.WriteLine(PhoneNumberInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(PhoneNumberInput[i] + " ----->InValid");
                }

            }
        }

        public void ValidatingPassWord()
        {
            string[] passwordInput = { "Vedhashni#1062", "Gayatri@10", "vE_d123" };
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex regex = new Regex(passwordPattern);
            for (int i = 0; i < passwordInput.Length; i++)
            {
                bool result = regex.IsMatch(passwordInput[i]);
                if (result)
                {
                    Console.WriteLine(passwordInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(passwordInput[i] + " ----->InValid");
                }

            }
        }
    }
}
