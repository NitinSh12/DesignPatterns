using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern
{
    public interface IEmployeeOrganizationFactory
    {
        public OrganizationDetail GetEmployeeOrganizationDetail(string empCode);
    }
}
