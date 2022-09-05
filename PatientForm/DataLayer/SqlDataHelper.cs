using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PatientRegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistrationForm.DataLayer
{
    public class SqlDataHelper : ISqlDataHelper
    {
        string conString = "";

        public SqlDataHelper(IConfiguration configuration)
        {
            conString = configuration.GetConnectionString("DefaultConnection");
        }

        public void RegisterPatient(Patient patient)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                //con.Open();
                //using (SqlCommand command = new SqlCommand("INSERT INTO PatientTbl ", con))
                //{
                //    SqlParameter param = new SqlParameter();
                //    param.ParameterName = "@countryId";
                //    param.Value =

                //    command.Parameters.Add(param);


                //}
                //con.Close();

                con.Open();

                //string query = "INSERT INTO dbo.PatientTbl(name, gender, address, email, DOB, country, mobileNum, landlineNum, officeNum, homeNum) VALUES('hahah', 'm', 'hdhdh', 'gfgfgh', '2022-9-21', 'Pak', '32221', null, null, null);";

                string query = "INSERT INTO dbo.PatientTbl(name, gender, address, email, DOB, country, mobileNum, landlineNum, officeNum, homeNum) VALUES(@name, @gender, @address, @email, @DOB, @country,@mobileNum, @landlineNum, @officeNum, @homeNum)";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    if (String.IsNullOrEmpty(patient.name))
                    {
                        command.Parameters.AddWithValue("@name", DBNull.Value);
                    }
                    else if(patient.name != null)
                    {
                        command.Parameters.AddWithValue("@name", patient.name);
                    }

                    if (String.IsNullOrEmpty(patient.gender))
                    {
                        command.Parameters.AddWithValue("@gender", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@gender", patient.gender);
                    }

                    if (String.IsNullOrEmpty(patient.address))
                    {
                        command.Parameters.AddWithValue("@address", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@address", patient.address);
                    }


                    if (String.IsNullOrEmpty(patient.email))
                    {
                        command.Parameters.AddWithValue("@email", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@email", patient.email);
                    }

                   
                    command.Parameters.AddWithValue("@DOB", patient.DOB.Date);

                    if (String.IsNullOrEmpty(patient.country))
                    {
                        command.Parameters.AddWithValue("@country", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@country", patient.country);
                    }

                    if (String.IsNullOrEmpty(patient.mobileNUm))
                    {
                        command.Parameters.AddWithValue("@mobileNUm", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@mobileNUm", patient.mobileNUm);
                    }

                    if (String.IsNullOrEmpty(patient.landlineNum))
                    {
                        command.Parameters.AddWithValue("@landlineNum", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@landlineNum", patient.landlineNum);
                    }

                    if (String.IsNullOrEmpty(patient.officeNum))
                    {
                        command.Parameters.AddWithValue("@officeNum", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@officeNum", patient.officeNum);
                    }

                    if (String.IsNullOrEmpty(patient.homeNum))
                    {
                        command.Parameters.AddWithValue("@homeNum", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@homeNum", patient.homeNum);
                    }

                    //command.Parameters.AddWithValue("@country", patient.country);
                    //command.Parameters.AddWithValue("@mobileNum", patient.mobileNUm);
                    //command.Parameters.AddWithValue("@landlineNum", patient.landlineNum);
                    //command.Parameters.AddWithValue("@officeNum", patient.officeNum);
                    //command.Parameters.AddWithValue("@homeNum", patient.homeNum);



                    command.ExecuteNonQuery();


                }
                con.Close();

            }
        }
    }
}
