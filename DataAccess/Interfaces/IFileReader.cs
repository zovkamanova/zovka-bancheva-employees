using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
  public interface IFileReader
    {
        List<EmployeeWork> ReadFromFile(string filePath);
    }
}
