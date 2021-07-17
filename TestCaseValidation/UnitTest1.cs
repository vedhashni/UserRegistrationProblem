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

            var actual = RegexExample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Gayatri", "Gayatri")]
        [DataRow("Gaya", "Gaya")]
        [DataRow("Ga", null)]

        public void ValidateLastname(string a, string expected)
        {

            var actual = RegexExample.ValidatingLastName(a);
            Assert.AreEqual(expected, actual);
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

            var actual = RegexExample.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 9843801062", "91 9843801062")]
        [DataRow("B3456", null)]
        [DataRow("98232@13", null)]

        public void ValidatePhoneNumber(string a, string expected)
        {

            var actual = RegexExample.ValidatingPhoneNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Vedhashni#12", "Vedhashni#12")]
        [DataRow("Gayatri@14", "Gayatri@14")]
        [DataRow("v_Ed$1", null)]
        [DataRow("divya", null)]

        public void ValidatePassword(string a, string expected)
        {

            var actual = RegexExample.ValidatingPassWord(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
