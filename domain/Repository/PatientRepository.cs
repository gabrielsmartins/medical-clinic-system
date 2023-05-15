using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface PatientRepository
    {

        Patient Create(Patient patient);

    }
}
