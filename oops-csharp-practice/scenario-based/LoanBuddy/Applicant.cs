using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.LoanBuddy
{
    internal class Applicant
    {
        private string name;
        private int creditScore;
        private double income;
        private double loanAmount;
        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }
        public int GetCreditScore()
        {
            return creditScore;
        }
        public double GetIncome()
        {
            return income;
        }
        public double GetLoanAmount()
        {
            return loanAmount;
        }
        public string GetName()
        {
            return name;
        }

    }
}
