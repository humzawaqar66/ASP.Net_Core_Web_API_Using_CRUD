using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testApi.Data;
using testApi.Models.Domain;

namespace NZWalksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDBContext dBContext;

        public RegionsController(NZWalksDBContext dbContext)
        {
            this.dBContext = dbContext;
        }

        // Get All Regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dBContext.Regions.ToList();

            return Ok(regions);
        }
        // Get Single Region By ID
        [HttpGet]
        [Route("{Id:Guid}")]

        public IActionResult GetById([FromRoute] Guid Id)
        {
            //var region = dBContext.Regions.Find(Id);
            
            var region = dBContext.Regions.FirstOrDefault(x => x.Id == Id);
            
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }
    }
}
