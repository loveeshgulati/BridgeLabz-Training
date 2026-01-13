using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.LoanBuddy
{
    internal interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }
}
