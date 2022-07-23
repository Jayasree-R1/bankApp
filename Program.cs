using System;
using BankystuffLibrary;
using Humanizer;
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("car".Pluralize());
            Console.WriteLine("Octopus".Pluralize());
            Console.WriteLine("Hair".Pluralize());
            Console.WriteLine("Fish".Pluralize());
            Console.WriteLine("Pant".Pluralize());

            Console.WriteLine(22319.ToWords());


            var account = new BankAccount("Jayashree", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");        
            account.MakeWithdrawal(50, DateTime.Now, "Lunch");           
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");          
            account.MakeDeposit(1090, DateTime.Now, "Salary Credited!!");            
            account.MakeWithdrawal(189, DateTime.Now, "Algo Expert");
            account.MakeWithdrawal(134, DateTime.Now, "Shopping");
            account.MakeWithdrawal(25, DateTime.Now, "Icecream");
            account.MakeWithdrawal(80, DateTime.Now, "Gym fee");
            account.MakeWithdrawal(12, DateTime.Now, "Netflix Subscription");


            Console.WriteLine(account.GetAccountHistory());

        }
    }
}