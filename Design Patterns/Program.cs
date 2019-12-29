using AbstractFactoryPattern;
using Factory_Design_Pattern;
using System;
using System.Collections.Generic;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern Output :");
            GetOrganizationDetailFromEmpCode("Int-450");

            Console.WriteLine("Abstract Factory Pattern Output :");
            AddEmployeeToOrganization();

        }

        private static void GetOrganizationDetailFromEmpCode(string empCode)
        {
            // For larger project this can be replaced with DI
            var factoryObject = new EmployeeOrganizatioFactory() as IEmployeeOrganizationFactory;
            var orgDetail = factoryObject.GetEmployeeOrganizationDetail(empCode);
            Console.WriteLine($"Name of the organization is {orgDetail.Name}");
        }

        private static void AddEmployeeToOrganization()
        {
            List<(string name,string empcode)> empList = new List<(string name, string empCode)> {
                                             (name: "Test", empCode: "Nat-123"),
                                             (name: "Test International", empCode: "Int-895"),
                                             (name: "Test outside employee", empCode: "Abc-777"),
                                            };

            foreach (var employee in empList)
            {
                IEmployeeOrganizationDetailFactory objAbstraction = EmployeeOrganizationProvider.GetEmployeeOrganizationFactory(employee.empcode);
                if(objAbstraction == null)
                {
                    Console.WriteLine($"Employee code {employee.empcode} is not valid");
                }
                else
                {
                    IEmployeeDetail employeeDetail = objAbstraction.AddEmployeeToOrganization(employee.name, employee.empcode);
                    employeeDetail.AddEmployee();
                }
            }
        }
    }
}
