using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_5Symbols_ReturnsFalse()
        {
            string password = "A@s12";
            bool exepted = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_10Symbols_ReturnsTrue()
        {
            string password = "A@S12asdfg";
            bool exepted = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod()]
        public void Check_22Symbols_ReturnsFalse()
        {
            string password = "A@S12asdfgffffffffffff";
            bool exepted = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_PresenceOfNumbersTrue()
        {
            //наличие цифр = presence of numbers
            string password = "A@S12asdfg";
            bool exepted = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod()]
        public void Check_PresenceOfNumbersFalse()
        {
            //наличие цифр = presence of numbers
            string password = "A@Sssasdfg";
            bool exepted = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_ThePresenceOfSpecialCharactersTrue()
        {
            //наличие спецсимволов = the presence of special characters
            string password = "A@S12asdfg";
            bool exepted = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod()]
        public void Check_ThePresenceOfSpecialCharactersFalse()
        {
            //наличие спецсимволов = the presence of special characters
            string password = "AsS12asdfg";
            bool exepted = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_ThePresenceOfCapitalLettersTrue()
        {
            //наличие прописных букв = the presence of capital letters
            string password = "A@S12asdfg";
            bool exepted = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod()]
        public void Check_ThePresenceOfCapitalLettersFalse()
        {
            //наличие прописных букв = the presence of capital letters
            string password = "A@S12ASDFG";
            bool exepted = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_ThePresenceOfLowercaseLettersTrue()
        {
            //наличие строчных букв = the presence of capital letters
            string password = "A@S12asdfg";
            bool exepted = true;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(exepted, actual);
        }
        [TestMethod()]
        public void Check_ThePresenceOfLowercaseLettersFalse()
        {
            //наличие строчных букв = the presence of capital letters
            string password = "a@s12asdfg";
            bool exepted = false;
            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
    }
}