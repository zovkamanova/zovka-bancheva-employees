using DataAccess;
using DataAccess.Interfaces;
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
        IFileReader _fileReader;
        IEmployeeHelpers _employeeHelpers;
        public UploadFileController(IFileReader fileReader,IEmployeeHelpers employeeHelpers)
        {
            _fileReader = fileReader;
            _employeeHelpers = employeeHelpers;
        }
        [HttpPost("UploadFile")]
        public async Task<IActionResult> Index(IFormFile file)
        {

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
                List<EmployeeWork> employeesListFromFile = _fileReader.ReadFromFile(filePath);

                //Setting a list of the teams worked longest on projects, ap the pass it to the view
                List<TeamViewModel> teamViewModels = _employeeHelpers.FindWorkTogether(employeesListFromFile);

                return View(teamViewModels);
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Error", "Home");
        }
    }
}