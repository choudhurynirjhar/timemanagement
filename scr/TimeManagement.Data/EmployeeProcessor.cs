using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.Data
{
    public class EmployeeProcessor : IEmployeeProcessor
    {
        private readonly string connectionString;

        public EmployeeProcessor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
