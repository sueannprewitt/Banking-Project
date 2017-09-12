using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingLibrary;

namespace Banking_Project {
	class Program {

		void Run() {
			Account checking = new Account();
			checking.SetName("Checking 1");
			checking.Withdraw(100.00);
			checking.Deposit(50.00);
			checking.Deposit(-100.00);
			Console.WriteLine($"Account Nbr: {checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Savings savings = new Savings("My Savings Account");
			savings.IntRate = .10;
			savings.Deposit(70.00);
			Console.WriteLine($"Account Nbr: {savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.Transfer(30.00, checking);
			Console.WriteLine($"Account Nbr: {checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr: {savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");


			checking.Transfer(-10.00, savings);
			Console.WriteLine($"Account Nbr: {checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr: {savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.Transfer(100.00, checking);
			Console.WriteLine($"Account Nbr: {checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr: {savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.PayMonthlyInterest();

			Console.WriteLine($"Account Nbr: { savings.getNumber()}, Name: { savings.GetName()}, balance is {savings.CheckBalance()}, interest rate is {savings.IntRate}," +
				$"interest deposit is {savings.CheckBalance()}");

			Savings sav1 = new Savings("Greg's Savings with Interest", 0.05);


		} 
		static void Main(string[] args) {
			new Program().Run();
		}

		
	}
}
