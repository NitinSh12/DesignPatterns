using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern
{
    public class EmployeeOrganizatioFactory : IEmployeeOrganizationFactory
    {
        public OrganizationDetail GetEmployeeOrganizationDetail(string empCode)
        {
            if(empCode.Contains("Nat"))
            {
                return new NationalPvtLtd();
            }
            else if (empCode.Contains("Int"))
            {
                return new InternationalPvtLtd();
            } 
            else
            {
                throw new ArgumentException("Invalid Employee Code");
            }
        }
    }
}
