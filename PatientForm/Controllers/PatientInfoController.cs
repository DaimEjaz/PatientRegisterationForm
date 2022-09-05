using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientRegistrationForm.BusinessLayer;
using PatientRegistrationForm.Models;

namespace PatientRegistrationForm.Controllers
{
    [Route("api")]
    [ApiController]
    public class PatientInfoController : ControllerBase
    {
        IPassPatientData _patientData;
        public PatientInfoController(IPassPatientData patientData)
        {
            _patientData = patientData;
        }


        [HttpPost]
        [Route("RegisterPatient")]


        public void Post(Patient patient)
        {

            _patientData.PassData(patient);
            //var countryinfoList = _countryManager.GetAllCountriesInfo();


        }
    }
}