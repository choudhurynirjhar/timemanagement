using Dapper;
using System.Data.SqlClient;

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
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO Employee (first_name, last_name, address, home_phone, cell_phone) VALUES (@FirstName, @LastName, @Address, @HomePhone, @CellPhone)",
                    new { employee.FirstName, employee.LastName, employee.Address, employee.HomePhone, employee.CellPhone });
            }
        }

        public void Delete(int employeeId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("DELETE FROM Employee WHERE id=@Id",
                new { Id = employeeId });
            }
        }

        public void Update(Employee employee)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("UPDATE Employee SET first_name =@FirstName, last_name =@LastName, address=@Address, home_phone=@HomePhone, cell_phone=@CellPhone WHERE id=@Id",
                new { employee.FirstName, employee.LastName, employee.Address, employee.HomePhone, employee.CellPhone, employee.Id });
            }
        }
    }
}
