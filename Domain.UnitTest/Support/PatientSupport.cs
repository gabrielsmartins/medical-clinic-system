using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTest.Support
{
    public static class PatientSupport
    {
        public static Patient.Builder defaultPatient()
        {
            return Patient.NewBuilder()
                          .WithId(Guid.NewGuid())
                          .WithName("John Wick")
                          .WithMotherName("Maria Wick")
                          .WithGender(Enums.Gender.MALE)
                          .WithDateOfBirth(DateTime.Now.AddYears(-30))
                          .WithMedicationAllergy(true)
                          .WithMedicationAllergyDescription("Aspirina")
                          .WithCreatedAt(DateTime.Now)
                          .WithUpdatedAt(DateTime.Now);
        }

    }
}
