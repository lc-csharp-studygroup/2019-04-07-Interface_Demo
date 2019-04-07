using System;
using System.Collections.Generic;
using System.Text;

namespace _2019_04_07_Interface_Demo
{
    public class EmployeeRecord : ISavable
    {
        public void Save()
        {
            // Connect to Database 2
            // Save to Database 2
            Console.WriteLine("Save EmployeeRecord to Database 2");
        }

        public void Validate()
        {
            // Ensure properties have valid values
            Console.WriteLine("Validating EmployeeRecord");
        }
    }
}
