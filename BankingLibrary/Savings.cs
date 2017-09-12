using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary {
	public class Savings : Account {

		public new string Name = "Savings Account";
		public double IntRate;
		

		public double PayMonthlyInterest() {
			return Balance *= IntRate;
		}

		public double IntDeposit(double amount)
		{
			return Balance += amount;
		}

		public override string ToPrint() {
			return base.ToPrint() + $"::{IntRate}";
		}
	}
}
