using DoctorFastMock.JsonFiles;
using DoctorFastMock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorFastMock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost, Route("/authentication/login")]
        public dynamic login(loginModel request)
        {
            dynamic resultado = null;
            if (request.username != null && request.password != null)
            {
                if (request.username == "Hernesto34" && request.password == "12345678")
                {
                    using (StreamReader rd = new StreamReader(@"./JsonFiles/loginResponse.json"))
                    {
                        string jsonString = rd.ReadToEnd();
                        resultado = JsonConvert.DeserializeObject<loginResponseModel>(jsonString);

                    }
                }
                else
                {
                    
                    return BadRequest();
                }
                
            }
            
            return resultado;
        }
        
    }
}
