using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
            ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            var result = accountController.ValidateEmail(email);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [
            Test,
            TestCase("abcd1234", false),
             TestCase("abcdABCD", false),
             TestCase("ABCD1234", false),
             TestCase("abcD28", false),
             TestCase("ABcd1234", true),
             TestCase("HappyHipp88", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();
            //Act
            var result = accountController.ValidatePassword(password);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
