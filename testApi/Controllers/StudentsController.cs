using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        string[] StudentNames = new string[] { "John", "Jane", "Mark", "Emily", "David" };
        
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(StudentNames);
        }

    }
}
