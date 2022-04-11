using DoctorFastMock.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorFastMock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet,Route("/doctor/GetDoctor")]
        public DoctorModel GetDoctor([FromHeader]string JWT)
        {
            dynamic resultado;
            using(StreamReader rd = new StreamReader(@"./JsonFiles/Doctor.json"))
            {
                string jsonString = rd.ReadToEnd();
                resultado = JsonConvert.DeserializeObject<DoctorModel>(jsonString);

            }
            return resultado;
        }

        [HttpGet, Route("/doctor/GetAllDoctors")]
        public AllDoctorsModel GetAllDoctors([FromHeader] string JWT)
        {
            dynamic resultado;
            using (StreamReader rd = new StreamReader(@"./JsonFiles/AllDoctors.json"))
            {
                string jsonString = rd.ReadToEnd();
                resultado = JsonConvert.DeserializeObject<AllDoctorsModel>(jsonString);

            }
            return resultado;
        }

        [HttpGet, Route("/patient/GetPatient")]
        public PatientModel GetPatient([FromHeader] string JWT)
        {
            dynamic resultado;
            using (StreamReader rd = new StreamReader(@"./JsonFiles/Patient.json"))
            {
                string jsonString = rd.ReadToEnd();
                resultado = JsonConvert.DeserializeObject<PatientModel>(jsonString);

            }
            return resultado;
        }
    }
}
