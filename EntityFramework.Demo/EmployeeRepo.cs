using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Demo
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext employeeContext;
        public EmployeeRepo(EmployeeContext employeeContext) { 
        
        }
        public Employee Create(string firstName, 
            string lastName,
            string address,
            string homePhone,
            string cellPhone)
        {
           var response = employeeContext.Add(new Employee { FirstName = firstName, LastName = lastName, Address = address, Homephone = homePhone, Cellphone = cellPhone });
            employeeContext.SaveChanges();
            return response.Entity;
            throw new NotImplementedException();
        }

        public void Delete(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }

        public Employee Update(Employee employee)
        {
            var response = employeeContext.Update(employee);
            employeeContext.SaveChanges();
            return response.Entity;
        }
    }
}
