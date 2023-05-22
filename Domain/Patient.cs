using Domain.Enums;
using System;

namespace Domain
{
    public class Patient
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Boolean? MedicationAllergy { get; set; }
        public string MedicationAllergyDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static Builder NewBuilder() {
            return new Builder();
        }

        public class Builder
        {
            private Patient? _patient;

            public Builder()
            {
                this._patient = new Patient();
            }

     
            public Builder WithId(Guid id)
            {
                this._patient.Id = id;
                return this;
            }

            public Builder WithName(string name)
            {
                this._patient.Name = name;
                return this;
            }

            public Builder WithMotherName(string motherName)
            {
                this._patient.MotherName = motherName;
                return this;
            }

            public Builder WithDateOfBirth(DateTime dateOfBirth)
            {
                this._patient.DateOfBirth = dateOfBirth;
                return this;
            }

            public Builder WithGender(Gender gender)
            {
                this._patient.Gender = gender;
                return this;
            }

            public Builder WithMedicationAllergy(Boolean medicationAllergy)
            {
                this._patient.MedicationAllergy = medicationAllergy;
                return this;
            }

            public Builder WithMedicationAllergyDescription(string medicationAllergyDescription)
            {
                this._patient.MedicationAllergyDescription = medicationAllergyDescription;
                return this;
            }

            public Builder WithCreatedAt(DateTime createdAt)
            {
                this._patient.CreatedAt = createdAt;
                return this;
            }

            public Builder WithUpdatedAt(DateTime updatedAt)
            {
                this._patient.UpdatedAt = updatedAt;
                return this;
            }

            public Patient Build()
            {
                return this._patient;
            }

        }

    }

}