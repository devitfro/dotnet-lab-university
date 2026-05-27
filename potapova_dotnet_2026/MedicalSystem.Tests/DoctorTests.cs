using Core.Models;
using Xunit;

namespace MedicalSystem.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void Doctor_Name_Should_Be_Set()
        {
            Doctor doctor = new Doctor();

            doctor.Name = "John";

            Assert.Equal("John", doctor.Name);
        }

        [Fact]
        public void Doctor_Rating_Should_Be_Valid()
        {
            Doctor doctor = new Doctor();

            doctor.Rating = 4.5;

            Assert.Equal(4.5, doctor.Rating);
        }

        [Fact]
        public void Compute_Should_Return_Correct_Value()
        {
            Doctor doctor =
                new Doctor("John", "Cardio", 10, 4.0);

            decimal result = doctor.Compute();

            Assert.Equal(400, result);
        }
    }
}