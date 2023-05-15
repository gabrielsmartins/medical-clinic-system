using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
