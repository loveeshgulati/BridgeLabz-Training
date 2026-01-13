using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.LoanBuddy
{
    class PersonalLoan : LoanApplication
    {
        public PersonalLoan(Applicant applicant, int months) : base(applicant, months, 12.0)
        {
        }
    }
}
