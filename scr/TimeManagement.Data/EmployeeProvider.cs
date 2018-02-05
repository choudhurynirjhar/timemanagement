using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.Data
{
    public class EmployeeProvider : IEmployeeProvider
    {
        private readonly string connectionString;

        public EmployeeProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Employee> Get()
        {
            IEnumerable<Employee> employee = null;

            return employee;
        }
    }
}
