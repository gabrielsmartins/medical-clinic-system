using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTest.Support
{
    public class MedicalAppointmentSupport
    {

        private MedicalAppointmentSupport()
        {

        }

        public static MedicalAppointment.Builder defaultMedicalAppointment()
        {
            return MedicalAppointment.NewBuilder()
                .WithId(new Random().Next())
                .withAnamnesis("Foo")
                .withIcd("F35")
                .WithCreatedAt(DateTime.Now)
                .WithUpdatedAt(DateTime.Now);
        }
    }
}
