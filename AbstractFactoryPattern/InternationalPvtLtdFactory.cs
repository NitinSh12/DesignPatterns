using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class InternationalPvtLtdFactory: IEmployeeOrganizationDetailFactory
    {
        public override IEmployeeDetail AddEmployeeToOrganization(string name, string empCode)
        {
            InternationalPvtLtd intOrg = new InternationalPvtLtd(name, empCode);
            return intOrg;
        }
    }
}
