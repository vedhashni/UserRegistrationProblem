using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace TestCaseValidation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Vedhashni", "Vedhashni")]
        [DataRow("Dev", "Dev")]
        [DataRow("v", null)]
        public void ValidateFirstname(string a, string expected)
        {
            try
            {
                var actual = RegexExample.ValidatingFirstName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }

        }

        [TestMethod]
        [DataRow("Gayatri", "Gayatri")]
        [DataRow("Gaya", "Gaya")]
        [DataRow("Ga", null)]

        public void ValidateLastname(string a, string expected)
        {
            try
            {
                var actual = RegexExample.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }

        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]
        [DataRow("abc@abc@gmail.com", null)]

        public void ValidateEmailId(string a, string expected)
        {
            try
            {
                var actual = RegexExample.ValidatingEmailId(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }

        }

        [TestMethod]
        [DataRow("91 9843801062", "91 9843801062")]
        [DataRow("B3456", null)]
        [DataRow("98232@13", null)]

        public void ValidatePhoneNumber(string a, string expected)
        {
            try
            {
                var actual = RegexExample.ValidatingPhoneNumber(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }

        }

        [TestMethod]
        [DataRow("Vedhashni#12", "Vedhashni#12")]
        [DataRow("Gayatri@14", "Gayatri@14")]
        [DataRow("v_Ed$1", null)]
        [DataRow("divya", null)]

        public void ValidatePassword(string a, string expected)
        {
            try
            {
                var actual = RegexExample.ValidatingPassWord(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }

        }

        [TestMethod]
        public void Test_Method_Object_Creation_RegexSample()
        {
            object expected = new RegexExample();
            RegistrationFactory factory = new RegistrationFactory();
            object actual = factory.CreateObjectForRegexExample("UserRegistration.RegexSample", "RegexSample");
            expected.Equals(actual);

        }
        //Test for parameterconstructor invoked using object created
        [TestMethod]
        public void Test_Method_Parameteized_Constructor()
        {
            object expected = new RegexExample("RegularExpression");
            RegistrationFactory factory = new RegistrationFactory();
            object actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSample", "RegularExpression");
            actual.Equals(expected);
        }

        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "No constructor found";
            object obj = null;
            try
            {
                RegistrationFactory factory = new RegistrationFactory();
                obj = factory.CreateObjectForRegexExample("UserRegistration.RegexSample", "RegexSam");

            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "No class found";
            object obj = null;
            try
            {
                RegistrationFactory factory = new RegistrationFactory();
                obj = factory.CreateObjectForRegexExample("UserRegistration.RegexSae", "RegexSample");

            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "Regular Expression";
            string expected = "No class found";
            object actual = null;
            try
            {
                RegistrationFactory factory = new RegistrationFactory();
                actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSae", "RegexSample", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor_Invalid()
        {
            string message = "Regular Expression";
            string expected = "No constructor found";
            object actual = null;
            try
            {
                RegistrationFactory factory = new RegistrationFactory();
                actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSam", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
    }
}
