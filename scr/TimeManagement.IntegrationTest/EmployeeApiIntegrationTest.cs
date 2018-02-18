using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data;
using Xunit;

namespace TimeManagement.IntegrationTest
{
    public class EmployeeApiIntegrationTest
    {
        [Fact]
        public async Task Test_Get_All()
        {

            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/employee");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        [Fact]
        public async Task Test_Post()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.PostAsync("/api/employee"
                    , new StringContent(
                        JsonConvert.SerializeObject(new Employee()
                        {
                            Address = "Test",
                            FirstName = "John",
                            LastName = "Mak",
                            CellPhone = "111-222-3333",
                            HomePhone = "222-333-4444"
                        }), 
                        Encoding.UTF8, 
                        "application/json"));

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
