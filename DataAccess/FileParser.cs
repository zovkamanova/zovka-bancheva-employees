using DataAccess.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataAccess
{
   public class FileParser :IFileParser
    {
        //This is a method that is parsing the data coming from file and set it to the EmployeeWork model and returns a list of EmployeeWork models
        public List<EmployeeWork> ParseDataFromFile(List<string[]> rowsInFile)
        {
            List<EmployeeWork> employeesModels = new List<EmployeeWork>();

            //Looping through all of the rows of the text file and  parse the values
            foreach (var row in rowsInFile)
            {
                EmployeeWork employeeWorkModel = new EmployeeWork();

                //Trimming the whitespace in the file 
                employeeWorkModel.EmpID = Convert.ToInt32(row[0].Trim());
                employeeWorkModel.ProjectID = Convert.ToInt32(row[1].Trim());
                //Setting the DateFrom property with any DateTime formats
                employeeWorkModel.DateFrom = DateTime.ParseExact(row[2].Trim(), GetAllDateTimeFormats(), CultureInfo.InvariantCulture, DateTimeStyles.None);

                if (row[3].Trim() == "NULL")
                {
                    //If there is a "NULL" value in the text file, set the DateTo value to DateTime.Now
                    employeeWorkModel.DateTo = DateTime.Now.Date;
                }
                else
                {
                    //Setting the DateTo property with any DateTime formats
                    employeeWorkModel.DateTo = DateTime.ParseExact(row[3].Trim(), GetAllDateTimeFormats(), CultureInfo.InvariantCulture, DateTimeStyles.None);
                }

                employeesModels.Add(employeeWorkModel);

            }
            return employeesModels;
        }

        //A method that returns all DateTime Formats
        public string[] GetAllDateTimeFormats()
        {
            string[] dateTimeFormats = new string[]{"yyyy-MM-dd", "yyyy/MM/dd", "yyyy.MM.dd",
            "yyyy-dd-MM", "yyyy/dd/MM", "yyyy.dd.MM",
            "MM-dd-yyyy", "MM/dd/yyyy", "MM.dd.yyyy",
            "MMM-dd-yyyy", "MMM/dd/yyyy", "MMM.dd.yyyy",
            "MMMM-dd-yyyy", "MMMM/dd/yyyy", "MMMM.dd.yyyy" };

            return dateTimeFormats;
        }
    }
}
