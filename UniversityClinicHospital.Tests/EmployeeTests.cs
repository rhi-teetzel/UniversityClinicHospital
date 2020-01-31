using System;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class EmployeeTests
    {
        [Fact]
       public void Pay_All_Employess_Changes_Paid_To_True()
        {
            //Arrange
            var employee = new Employee();
            employee.employeesList.Add(employee);

            //Act
            employee.PayAllEmployees();

            //Assert
            Assert.True(employee.Paid);
            
        }
    }
}
