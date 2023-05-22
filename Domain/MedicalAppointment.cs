using System;

namespace Domain
{
    public class MedicalAppointment
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public string Anamnesis { get; set; }
        public string? Icd { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static Builder NewBuilder()
        {
            return new Builder();
        }

        public class Builder
        {
            private readonly MedicalAppointment _medicalAppointment;

            public Builder()
            {
                this._medicalAppointment = new MedicalAppointment();
            }

            public Builder WithId(int id)
            {
                this._medicalAppointment.Id = id;
                return this;
            }

            public Builder WithPatient(Patient patient)
            {
                this._medicalAppointment.Patient = patient;
                return this;
            }

            public Builder withAnamnesis(string anamnesis)
            {
                this._medicalAppointment.Anamnesis = anamnesis;
                return this;
            }

            public Builder withIcd(string icd)
            {
                this._medicalAppointment.Icd = icd;
                return this;
            }

            public Builder WithCreatedAt(DateTime createdAt)
            {
                this._medicalAppointment.CreatedAt = createdAt;
                return this;
            }

            public Builder WithUpdatedAt(DateTime updatedAt)
            {
                this._medicalAppointment.UpdatedAt = updatedAt;
                return this;
            }

            public MedicalAppointment Build()
            {
                return this._medicalAppointment;
            }

        }

    }
}
