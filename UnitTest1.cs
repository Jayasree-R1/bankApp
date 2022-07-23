using System;
using Xunit;
using BankystuffLibrary;
using MySuperBank;
using System.Collections.Generic;


namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicTests()
        {
            Assert.True(true);

        }
        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Jayashree", 1000);
            
            // Test for a negative balance
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(8000,
                DateTime.Now,
                "Attempt to overdraw")
            );

        }
        [Fact]
        public void InvalidAccountTests()
        {
            //// Test that the initial balances must be positive:
            Assert.Throws<ArgumentOutOfRangeException>(
                    () =>  new BankAccount("Invali", -98)
            );
           
        }

    }
}

