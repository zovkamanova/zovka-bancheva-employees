using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
   public interface IFileParser
    {
        List<EmployeeWork> ParseDataFromFile(List<string[]> rowsInFile);
    }
}
