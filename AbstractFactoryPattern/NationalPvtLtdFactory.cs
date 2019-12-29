using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class NationalPvtLtdFactory : IEmployeeOrganizationDetailFactory
    {
        public override IEmployeeDetail AddEmployeeToOrganization(string name, string empCode)
        {
            NationalPvtLtd intOrg = new NationalPvtLtd(name, empCode);
            return intOrg;
        }
    }
}
