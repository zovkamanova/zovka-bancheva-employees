using DataAccess.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess
{
   public class FileReader : IFileReader
    {
        //Method that reads the file from the stream and returns a list of EmployeeWork
        IFileParser _fileParser;
        public FileReader(IFileParser fileParser)
        {
            _fileParser = fileParser;
        }
        public List<EmployeeWork> ReadFromFile(string filePath)
        {
           
            List<string[]> rowsInFile = new List<string[]>();

            //Creating a new stream reader
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    rowsInFile.Add(reader.ReadLine().Split(','));
                }
            }
            //After reading the file, parsing the data with a file parser
            List<EmployeeWork> epmployeesFromFile = _fileParser.ParseDataFromFile(rowsInFile);

            return epmployeesFromFile;
        }
    }
}
