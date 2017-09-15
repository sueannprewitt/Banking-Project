using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingLibrary;

namespace TestCasesForAccount
{
    [TestClass]
    public class TestsForAccount
    {
        [TestMethod]
        public void Testing()
        {
            Account checking = new Account();
            Assert.IsInstanceOfType(checking, typeof(Account), "Default Constructor");

            Assert.AreEqual(96434, checking.getNumber(), "Account Number is 96434");


                }


        [TestMethod]
        public void TestDepositinChecking()
            {
            Account checking = new Account();
            checking.Deposit(100.00);
            var balance = checking.CheckBalance();
            Assert.AreEqual(balance, checking.CheckBalance());
       

        }
    }
}


