using CloudService.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudService.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class CitiController : ControllerBase
    {
        private readonly Data.ApplicaitonDataContext _context;
        public CitiController(Data.ApplicaitonDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getCitis()
        {
            var cities = ApplicaitonDataContext._AppDbContext.Citis.ToList();
            return Ok(cities);


        }
    }
}
