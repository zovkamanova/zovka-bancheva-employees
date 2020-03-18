using DataAccess;
using EmplpyeeProjectZovkaBancheva.Helpers;
using EmplpyeeProjectZovkaBancheva.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace EmplpyeeProjectZovkaBancheva.Controllers
{
    public class UploadFileController : Controller
    {
        [HttpPost("UploadFile")]
        public async Task<IActionResult> Index(IFormFile file)
        {
            //Instantiating the two helper classes 

            FileReader fileReader = new FileReader();
            EmployeeHelpers helpers = new EmployeeHelpers();
            string filePath = "";

            //Creating a try/catch block to prevent breaking the application if the file is not found or is in a bad format 
            try
            {
                if (file.Length > 0)
                {
                    //Setting a temporary file path
                    filePath = Path.GetTempFileName();

                    //Opening a file stream to copy the file to
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }

                //Setting  a list of employees which are read from the file
                List<EmployeeWork> employeesListFromFile = fileReader.ReadFromFile(filePath);

                //Setting a list of the teams worked longest on projects, ap the pass it to the view
                List<TeamViewModel> teamViewModels = helpers.FindWorkTogether(employeesListFromFile);

                return View(teamViewModels);
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Error", "Home");
        }
    }
}