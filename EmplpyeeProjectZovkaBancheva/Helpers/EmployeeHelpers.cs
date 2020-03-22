using EmplpyeeProjectZovkaBancheva.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmplpyeeProjectZovkaBancheva.Helpers
{
    //Helper class that finds the teams that worked longest together on a project
    public class EmployeeHelpers : IEmployeeHelpers
    {
        //A method that finds the teams that worked longest together on a project and returns a list of these teams
        public List<TeamViewModel> FindWorkTogether(List<EmployeeWork> allEmployees)
        {
            List<TeamViewModel> allWorkTogether = new List<TeamViewModel>();

            //Grouping the employee models by ProjectId
            var employeesGroupedByProject = allEmployees
                .GroupBy(emp => emp.ProjectID)
                .Select(group => group.OrderBy(o => o.DateFrom).ToList())
                .Where(list => list.Count > 1)
                .ToList();

            //Looping through all of the eployees worked on a project
            foreach (List<EmployeeWork> employeesPerProject in employeesGroupedByProject)
            {
                //Grouping the list by Employer Id 
                var employeesByID = employeesPerProject
                    .GroupBy(emp => emp.EmpID)
                    .Select(group => group.ToList())
                    .ToList();

                //Looping throuth the collection, grouped on Employed Id
                for (int i = 0; i < employeesByID.Count; i++)
                {
                    var employeeList = employeesByID[i];

                    //Looping through the employees list 
                    foreach (EmployeeWork employee in employeeList)
                    {
                        //Set the start date and end date of the first user worked the project
                        DateTime startFirstUser = employee.DateFrom;
                        DateTime endFirstUser = employee.DateTo;

                        for (int j = i + 1; j < employeesByID.Count; j++)
                        {
                            var internalEmployeeList = employeesByID[j];

                            foreach (EmployeeWork anotherEmployee in internalEmployeeList)
                            {
                                //Set the start date and the end date of the second employer that worked on the project
                                DateTime startSecondUser = anotherEmployee.DateFrom;
                                DateTime endSecondUser = anotherEmployee.DateTo;

                                //If the start date of the first employee is greater than the end date of the second employee Or The endDate of the First Employee if lower than the Start date of the secod user
                                //Means that they haven't worked together on the project and continue to the next iteration of the loop
                                if (startFirstUser > endSecondUser || endFirstUser < startSecondUser)
                                {
                                    continue;
                                }
                                //Set the days spent together on the same project
                                var daysSpentTogether = CalculateDaysTogether(startFirstUser, startSecondUser, endFirstUser, endSecondUser);

                                //If they have worked more than 0 days, it means that they actually wokred together and create a new Team object and add it to a list of team objects
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
            //Grouping the teams based on users Ids and the project Id and order them descending to get the max days spent on a project
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
        //A method that calculates the difference between two dates in days
        public int CalculateDifference(DateTime DateFrom, DateTime DateTo)
        {
            return (int)(DateTo - DateFrom).TotalDays;
        }
        //A method that calculates days spent together on project
        public int CalculateDaysTogether(DateTime startFirstUser, DateTime startSecondUser, DateTime endFirstUser, DateTime endSecondUser)
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
