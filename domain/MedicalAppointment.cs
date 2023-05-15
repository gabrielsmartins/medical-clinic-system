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
        private Patient Patient { get; set; }
        private string Anamnesis { get; set; }
        private string? Icd { get; set; }
        private DateTime CreatedAt { get; set; }
        private DateTime UpdatedAt { get; set; }

    }
}
