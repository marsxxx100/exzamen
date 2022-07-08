using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exam_v_1;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Sum_5and6_11returned()
        {
            // Arrange
            int a = 5;
            int b = 6;
            int expected = 11;

            // Act
            int actual = Calculator.Sum(a, b);

            // Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_10and6_4returned()
        {
            // Arrange
            int a = 10;
            int b = 6;
            int expected = 4;

            // Act
            int actual = Calculator.Difference(a, b);

            // Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Product_5and6_30returned()
        {
            // Arrange
            int a = 5;
            int b = 6;
            int expected = 30;

            // Act
            int actual = Calculator.Product(a, b);

            // Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_10and2_5returned()
        {
            // Arrange
            int a = 10;
            int b = 2;
            int expected = 5;

            // Act
            int actual = Calculator.Division(a, b);

            // Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 12;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

            // Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
