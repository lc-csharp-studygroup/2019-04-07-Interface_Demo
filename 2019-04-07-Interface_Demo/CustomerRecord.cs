using System;
using System.Collections.Generic;
using System.Text;

namespace _2019_04_07_Interface_Demo
{
    public class CustomerRecord : ISavable
    {
        public void Save()
        {
            // Connect to Database 1
            // Save to Database 1
            // handle deadlocks
            Console.WriteLine("Save CustomerRecord to Database 1");
        }

        public void Validate()
        {
            // Ensure properties have valid values
            Console.WriteLine("Validating CustomerRecord");
        }
    }
}
