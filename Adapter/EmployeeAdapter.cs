// In case you need some guidance: https://refactoring.guru/design-patterns/adapter

using Microsoft.VisualBasic.CompilerServices;

namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var employeeList = new List<Employee>();
            for (int i = 0; i < employeesArray.Length; i++)
            {
                
                Employee employee = new Employee(int.Parse(employeesArray[i,0]), employeesArray[i,1], employeesArray[i,2], decimal.Parse(employeesArray[i,3]));
                employeeList.Add(employee);
                
            }
            
            thirdPartyBillingSystem.ProcessSalary(employeeList);
        }
    }
}
