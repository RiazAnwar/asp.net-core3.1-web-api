using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiTesting.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpGet("getname")]
            public string GetName()
        
        {
            return "Riaz Anwar";
        }
        [HttpGet("getmarks")]
        public int GetMarks(int rollnumber)
        {
            return 100;
        }
        [HttpPost("saveuser")]
        public string Save(StudentDTO dto)
        {
            return "Done";
        }
    }

    public class StudentDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
