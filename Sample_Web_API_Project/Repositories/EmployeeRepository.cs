using Sample_Web_API_Project.Entities;
using Sample_Web_API_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Web_API_Project.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        RepositoriesContext context;
        public EmployeeRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }
        public int AddEmployee(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var emp = context.Employees.Where(p => p.Id == id).SingleOrDefault();
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees.ToList();
        }

        public int ModifyEmployee(Employee emp)
        {
            var employee = context.Employees.Where(p => p.Id == emp.Id).SingleOrDefault();
            if (employee != null)
            {
                employee.Name = emp.Name;
                employee.Salary = emp.Salary;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
