using System.Text.Json.Serialization;

namespace Infra.Web.Dto
{
    public class PatientDto
    {
        [JsonPropertyName("id")]

        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mother_name")]
        public string MotherName { get; set; }

        [JsonPropertyName("date_of_birth")]
        public DateOnly DateOfBirth { get; set; }

        [JsonPropertyName("gender")]
        public Char Gender { get; set; }

        [JsonPropertyName("medication_allergy")]
        public Boolean? MedicationAllergy { get; set; }

        [JsonPropertyName("medication_allergy_description")]
        public string MedicationAllergyDescription { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }

}