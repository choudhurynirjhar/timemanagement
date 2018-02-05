using System;
using System.Collections.Generic;

namespace TimeManagement.Data
{
    public interface IEmployeeProvider
    {
        IEnumerable<Employee> Get(); 
    }
}
