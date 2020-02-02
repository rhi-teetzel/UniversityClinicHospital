using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void CareForPatients_Health_Increases()
        {
            //Arrange
            var patient = new Patient("");
            var doctor = new Doctor("", 2, "");
            var testHealth = patient.HealthLevel;

            //Act
            doctor.CareForPatients();

            //Assert
            Assert.Equal(testHealth + 20, patient.HealthLevel);
        }

    }
}
