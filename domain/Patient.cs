using Domain.Enums;

namespace domain
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Boolean? MedicationAllergy {  get; set; }
        public string MedicationAllergyDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }

}