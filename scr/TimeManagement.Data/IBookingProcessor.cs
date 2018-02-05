using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.Data
{
    public interface IBookingProcessor
    {
        bool Create(int employeeId, DateTime date, decimal duration);
    }
}
