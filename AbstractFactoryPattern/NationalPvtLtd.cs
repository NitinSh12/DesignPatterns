using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class NationalPvtLtd: IEmployeeDetail
    {
        private string _name;
        private string _empCode;
        public NationalPvtLtd(string name, string empCode)
        {
            _name = name;
            _empCode = empCode;
        }
        public void AddEmployee()
        {
            Console.WriteLine($"Employee with name {_name} and employee code {_empCode} is successfully added to National Pvt. Ltd.");
        }
    }
}
