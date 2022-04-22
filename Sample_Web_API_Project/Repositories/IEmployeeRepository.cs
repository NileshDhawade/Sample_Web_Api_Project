﻿using Sample_Web_API_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Web_API_Project.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        int AddEmployee(Employee emp);
        int ModifyEmployee(Employee emp);
        int DeleteEmployee(int id);

    }
}
