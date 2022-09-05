using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistrationForm.Models
{
    public class Patient
    {
        public string name { get; set; }
        public string gender { get; set; }

        public string country { get; set; }
        public string address { get; set; }

        public string mobileNUm { get; set; }
        public string landlineNum { get; set; }
        public string officeNum { get; set; }
        public string homeNum { get; set; }


        public string email { get; set; }

        public DateTime DOB { get; set; }

        public Patient()
        {

        }

        public Patient(string pName, string pGender, string pCountry, string pAddress, string pEmail, DateTime dob, string pMobileNum, string pLandlineNum, string pOfficeNum, string pHomeNum)
        {
            name = pName;
            gender = pGender;
            country = pCountry;
            address = pAddress;
            //contactNo = pContact;
            email = pEmail;
            DOB = dob;
            mobileNUm = pMobileNum;
            landlineNum = pLandlineNum;
            officeNum = pOfficeNum;
            homeNum = pHomeNum;
        }


    }
}
