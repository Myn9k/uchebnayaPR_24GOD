using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNIT_TESTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_TESTS.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8symbols_ReturnsTrue()
        {
            // Arrange.
            string password = "efty$iol";
            bool excepted = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void Check_4symbols_ReturnsFalse()
        {
            // Arrange.
            string password = "e$ty";

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_PasswordWidthLowerSymbols_ReturnTrue()
        {
            // Arrange.
            string password = "Efty1@34";
            bool excepted = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod()]
        public void Check_PasswordWidthLowerSymbols_ReturnFalse()
        {
            // Arrange.
            string password = "efty$234";
            bool excepted = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod()]
        public void Check_10symbols_ReturnsTrue()
        {
            // Arrange.
            string password = "Fey$i1l23";
            bool excepted = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void Check_2symbols_ReturnsFalse()
        {
            // Arrange.
            string password = "ee";

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.IsFalse(actual);
        }
        
    }
}