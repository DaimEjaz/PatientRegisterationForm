using PatientRegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistrationForm.BusinessLayer
{
    public interface IPassPatientData
    {
        public void PassData(Patient patientData);
    }
}
