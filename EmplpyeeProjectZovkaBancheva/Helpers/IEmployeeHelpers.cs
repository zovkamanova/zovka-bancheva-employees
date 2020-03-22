using EmplpyeeProjectZovkaBancheva.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplpyeeProjectZovkaBancheva.Helpers
{
   public interface IEmployeeHelpers
    {
        List<TeamViewModel> FindWorkTogether(List<EmployeeWork> allEmployees);

        int CalculateDifference(DateTime DateFrom, DateTime DateTo);
        int CalculateDaysTogether(DateTime startFirstUser, DateTime startSecondUser, DateTime endFirstUser, DateTime endSecondUser);
    }
}
