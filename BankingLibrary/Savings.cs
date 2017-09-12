using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary {
	public class Savings : Account {

		public double IntRate;
		

		public void PayMonthlyInterest() {
			var InterestAmount = CheckBalance() * IntRate;
			Deposit(InterestAmount);
		}

		public override string ToPrint() {
			return base.ToPrint() + $"::{IntRate}";
		}

		//constructor (for when Savings is called in the Program.cs)
		public Savings() : base() { }
		public Savings(string name) : base(name) { }
		public Savings(string name, double intRate) : base(name) {
			IntRate = intRate;
		}

	}
}
