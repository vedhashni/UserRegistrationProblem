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
    public class RegexExample
    {
         static string userpattern = "^[A-Z][a-z]{2,}$";
        static string[] EmailInput = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
        static string pattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
        public static string ValidatingFirstName(String input)
        {
            Console.WriteLine("Validating the First Name");
            Regex regex = new Regex(userpattern);
            //Console.WriteLine("Enter the First Name");
            //string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "First name should not be empty");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                }
                if (result)
                {
                    Console.WriteLine("Valid");
                    return input;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "First should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            
        }

        public static string ValidatingLastName(String input)
        {
            Console.WriteLine("Validating the Last Name");
            Regex regex = new Regex(userpattern);
            //Console.WriteLine("Enter the Last Name");
            //string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Last name should not be empty");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                }
                if (result)
                {
                    Console.WriteLine("Valid");
                    return input;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Last name should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                
                return ex.Message;
            }
            
        }

        public static string ValidatingEmailId(String input)
        {
            
            Regex regex = new Regex(pattern);
            //for (int i = 0; i < EmailInput.Length; i++)
            //{
                bool validemail = regex.IsMatch(input);
                try
                {
                    if (input.Equals(""))
                    {
                        throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email Id should not be empty");
                    }
                    if (input.Equals(null))
                    {
                        throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email Id should not be null");
                    }
                    if (validemail)
                    {
                        Console.WriteLine(input + " ----->Valid");
                        return input;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Email Id should be valid");
                    }
                }
                catch (NullReferenceException ex)
                {
                    
                    return ex.Message;
                }

            
           
        }

        public static String ValidatingPhoneNumber(String input)
        {
            string[] PhoneNumberInput = { "91 9843801062", " 91 8939620291", "919894571810", "B789023", "98#1234" };
            string PhoneNumberPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(PhoneNumberPattern);
            
                bool validnum = regex.IsMatch(input);
                try
                {
                    if (input.Equals(""))
                    {
                        throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Phone number should not be empty");
                    }
                    if (input.Equals(null))
                    {
                        throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Phone number should not be null");
                    }
                    if (validnum)
                    {
                        Console.WriteLine(input + " ----->Valid");
                        return input;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Phone number should be valid");
                    }

            }
                catch (NullReferenceException ex)
                {
                    return ex.Message;
                }
            }

        public static string ValidatingPassWord(String input)
        {
            string[] passwordInput = { "Vedhashni#1062", "Gayatri@10", "vE_d123" };
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex regex = new Regex(passwordPattern);
            
                bool result = regex.IsMatch(input);
            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Password should not be empty");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Password should not be null");
                }
                if (result)
                {
                    Console.WriteLine(input + " ----->Valid");
                    return input;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Passwordshould be valid");
                }

            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }
    }
}
