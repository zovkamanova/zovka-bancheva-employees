using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class EmployeeWork
    {
        public int EmpID { get; set; }
        public int ProjectID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
