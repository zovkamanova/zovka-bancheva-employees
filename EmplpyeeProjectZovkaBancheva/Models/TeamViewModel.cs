using System;
using System.Collections.Generic;
using System.Text;

namespace EmplpyeeProjectZovkaBancheva.Models
{
   //This is the view model of the teams that worked longest together on project
   public class TeamViewModel
    {
        public int FirstUserId { get; set; }
        public int SecondUserId { get; set; }
        public int ProjectID { get; set; }
        public int DaysSpentTogether { get; set; }
    }
}
