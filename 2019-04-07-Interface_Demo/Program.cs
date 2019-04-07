using System;
using System.Collections.Generic;

namespace _2019_04_07_Interface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRecord customer = new CustomerRecord();
            customer.Validate();
            customer.Save();

            EmployeeRecord employee = new EmployeeRecord();
            employee.Validate();
            employee.Save();


            //ISavable savable = new CustomerRecord();
            ISavable savable = new EmployeeRecord();
            savable.Validate();
            savable.Save();


            List<ISavable> savables = new List<ISavable>
            {
                new CustomerRecord(),
                new EmployeeRecord()
            };

            foreach (ISavable item in savables)
            {
                item.Validate();
                item.Save();
            }

        }
    }
}
