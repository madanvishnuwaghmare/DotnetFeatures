using CloudService.Data;
using CloudService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudService.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class CitiController : ControllerBase
    {
        private readonly Data.ApplicaitonDataContext _context;
        public CitiController(Data.ApplicaitonDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCitis()
        {
            var cities = _context.Citis.ToList();
            return Ok(cities);
        }

        [HttpPost]
        [Route("AddCitis")]
        public IActionResult AddCitis([FromBody] CitisDTO dTO)
        {
            var newCity = new Citis
            {
                CityName = dTO.CityName,
                CityDescription = dTO.CityDescription
            };

            _context.Citis.Add(newCity);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCitis), new { id = newCity.Id }, newCity);
        }

    }
}
