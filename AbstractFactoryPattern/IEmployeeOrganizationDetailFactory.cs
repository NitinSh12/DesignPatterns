using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class IEmployeeOrganizationDetailFactory
    {
        public abstract IEmployeeDetail AddEmployeeToOrganization(string name, string empCode);
    }
}
