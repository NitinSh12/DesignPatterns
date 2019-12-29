using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class EmployeeOrganizationProvider
    {
        public static IEmployeeOrganizationDetailFactory GetEmployeeOrganizationFactory(string empCode)
        {
            if (empCode.Contains("Nat"))
            {
                return new NationalPvtLtdFactory();
            }
            else if (empCode.Contains("Int"))
            {
                return new InternationalPvtLtdFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
