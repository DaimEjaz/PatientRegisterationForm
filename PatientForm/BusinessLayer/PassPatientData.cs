using PatientRegistrationForm.DataLayer;
using PatientRegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistrationForm.BusinessLayer
{
    public class PassPatientData: IPassPatientData
    {
        ISqlDataHelper _sqlDatahelper;
        public PassPatientData(ISqlDataHelper sqlDatahelper)
        {
            _sqlDatahelper = sqlDatahelper;
        }
        public void PassData(Patient patientData)
        {
            _sqlDatahelper.RegisterPatient(patientData);
        }

    }
}
