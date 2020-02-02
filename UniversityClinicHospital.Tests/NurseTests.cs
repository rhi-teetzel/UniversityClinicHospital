using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void CareForPatients_Health_Increases_Different_From_Doctor()
        {
            //Arrange
            var patient = new Patient("");
            var nurse = new Nurse("", 2, 1);
            var testHealth = patient.HealthLevel;

            //Act
            nurse.CareForPatients(patient);

            //Assert
            Assert.Equal(testHealth + 30, patient.HealthLevel);

        }

        [Fact]
        public void DrawBlood_Blood_Level_Decreases_by_10()
        {
            //Arrange
            var patient = new Patient("");
            var nurse = new Nurse("", 4, 1);
            var testBloodLvl = patient.BloodLevel;

            //Act
            nurse.DrawBlood(patient);

            //Assert
            Assert.Equal(testBloodLvl - 10, patient.BloodLevel);
        }


    }
}
