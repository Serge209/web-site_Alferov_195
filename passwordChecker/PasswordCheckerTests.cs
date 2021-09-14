using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "ASqs12$$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_8Symbols_ReturnsFalse()
        {
            string password = "Aq1$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_Numbers_ReturnsTrue()
        {
            string password = "Kl!2089631";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_Numbers_ReturnsFalse()
        {
            string password = "Hunkloft";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_Special_ReturnsTrue()
        {
            string password = "Fk12345.!";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_Special_ReturnsFalse()
        {
            string password = "goloki";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_Uppercase_ReturnsTrue()
        {
            string password = "ROMAGOCSj8_";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_Uppercase_ReturnsFalse()
        {
            string password = "lododdod";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_Lowercase_ReturnsTrue()
        {
            string password = "Lmoloksosboss1!";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_Lowercase_ReturnsFalse()
        {
            string password = "FRANKEIN";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }
    }
}
