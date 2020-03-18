using EmplpyeeProjectZovkaBancheva.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Helpers
{
    class EmployeeHelpers
    {
        public List<TeamViewModel> FindWorkTogether(List<EmployeeWork> allEmployees)
        {
            List<TeamViewModel> allWorkTogether = new List<TeamViewModel>();
            Dictionary<Tuple<int, int>, Dictionary<int, int>> d = new Dictionary<Tuple<int, int>, Dictionary<int, int>>();

            var employeesGroupedByProject = allEmployees
                .GroupBy(u => u.ProjectID)
                .Select(grp => grp.OrderBy(o => o.DateFrom).ToList())
                .Where(lst => lst.Count > 1)
                .ToList();

            foreach (List<EmployeeWork> employeesPerProject in employeesGroupedByProject)
            {
                var employeesByID = employeesPerProject
                    .GroupBy(emp => emp.EmpID)
                    .Select(group => group.ToList())
                    .ToList();

                for (int i = 0; i < employeesByID.Count; i++)
                {
                    var employeeList = employeesByID[i];

                    foreach (EmployeeWork employee in employeeList)
                    {
                        DateTime startFirstUser = employee.DateFrom;
                        DateTime endFirstUser = employee.DateTo;

                        for (int j = i + 1; j < employeesByID.Count; j++)
                        {
                            var internalEmployeeList = employeesByID[j];

                            foreach (EmployeeWork anotherEmployee in internalEmployeeList)
                            {
                                DateTime startSecondUser = anotherEmployee.DateFrom;
                                DateTime endSecondUser = anotherEmployee.DateTo;

                                if (startFirstUser > endSecondUser || endFirstUser < startSecondUser)
                                {
                                    continue;
                                }

                                var daysSpentTogether = CalculateDaysTogether(startFirstUser, startSecondUser, endFirstUser, endSecondUser);

                                if (daysSpentTogether > 0)
                                {
                                    allWorkTogether.Add(new TeamViewModel()
                                    {
                                        FirstUserId = employee.EmpID,
                                        SecondUserId = anotherEmployee.EmpID,
                                        ProjectID = employee.ProjectID,
                                        DaysSpentTogether = daysSpentTogether
                                    });
                                }
                            }
                        }
                    }
                }
            }
            var teamWork = allWorkTogether.GroupBy(gr => new { gr.FirstUserId, gr.SecondUserId, gr.ProjectID }).Select(
                g => new TeamViewModel()
                {
                    FirstUserId = g.Key.FirstUserId,
                    SecondUserId = g.Key.SecondUserId,
                    DaysSpentTogether = g.Sum(s => s.DaysSpentTogether),
                    ProjectID = g.First().ProjectID
                }).OrderByDescending(o => o.DaysSpentTogether).ToList();

            return teamWork;
        }
        public static int CalculateDifference(DateTime DateFrom, DateTime DateTo)
        {
            return (int)(DateTo - DateFrom).TotalDays;
        }
        public static int CalculateDaysTogether(DateTime startFirstUser, DateTime startSecondUser, DateTime endFirstUser, DateTime endSecondUser)
        {
            int daysTogether = 0;

            if (startFirstUser <= startSecondUser && endFirstUser <= endSecondUser)
            {
                daysTogether = CalculateDifference(startSecondUser, endFirstUser);
            }
            else if (startFirstUser >= startSecondUser && endFirstUser >= endSecondUser)
            {
                daysTogether = CalculateDifference(startFirstUser, endSecondUser);
            }
            else if (startFirstUser >= startSecondUser && endFirstUser <= endSecondUser)
            {
                daysTogether = CalculateDifference(startFirstUser, endSecondUser);
            }
            else if (startFirstUser <= startSecondUser && endFirstUser >= endSecondUser)
            {
                daysTogether = CalculateDifference(startSecondUser, endSecondUser);
            }
            return daysTogether;
        }

    }
}
