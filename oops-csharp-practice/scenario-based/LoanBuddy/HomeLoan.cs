using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.LoanBuddy
{
    class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant, int months) : base(applicant, months, 8.5) { }
        public override double CalculateEMI()
        {
            return base.CalculateEMI() * 0.98;
        }
    }
}
