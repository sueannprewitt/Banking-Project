using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary {
		/// <summary>
	/// The account class simulates an account at a bank
	/// </summary>
	public class Account {
		//Properties go here
		/// <summary>
		/// Contains the value of the next instance account number
		/// </summary>
		private static int nextAccountNumber = 96434;
		private const int incrementAccountNumber = 74747;
		public double Balance = 0;
		public string Name = "Checking";
		public int Number = 0;

		public virtual string ToPrint() {
			return $"{Number}: {Name} - {Balance}";
	}



		//Methods go here

		/// <summary>
		/// Transfer money from one account to another
		/// </summary>
		/// <param name="Amount"></param>
		/// <param name="ToAccount"></param>
		/// <returns></returns>
		public bool Transfer(double Amount, Account ToAccount) {
			if (Withdraw(Amount)) { 
			ToAccount.Deposit(Amount);
			return true;
		} else {
				return false;
			}
		

		}
		
		private bool IsAmountInvalid(double amount) {
			if(amount > 0) { //this is good
				return false;
			}else { //this is bad
				return true;
			}
		}
		/// <summary>
		/// Adds money into an account
		/// </summary>
		/// <param name="amount">The money to deposit</param>
		/// <returns>Returns true if deposit is successful; otherwise false</returns>
		public bool Deposit(double amount) {
			if (IsAmountInvalid(amount)){ //this is bad
				Console.WriteLine("Amount must be > zero.");
				return false;
			} 
			Balance += amount;
			return true;
		}
		/// <summary>
		/// Withdraws money from an account
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public bool Withdraw(double amount) {
			if (IsAmountInvalid(amount)) { //this is bad
				Console.WriteLine("Amount must be > zero.");
				return false;
			}
			if (amount > CheckBalance()) {
				Console.WriteLine("Insufficient funds.");
				return false;
			} else {
				Balance -= amount;
				return true;
			}
			
		}
		public double CheckBalance() {
			return Balance;
		}

		public string GetName() {
			return Name;
		}

		public void SetName(string name) {
			Name = name;
		}
		public int getNumber () {
			return Number;
		}
		private void SetNumber(int number) {

		}
		//default constructor
		public Account() {
			Number = nextAccountNumber;
			nextAccountNumber += incrementAccountNumber;
		}

		public Account(string name) {
			Name = name;
			Number = nextAccountNumber;
			nextAccountNumber += incrementAccountNumber;
		}

	}

}
