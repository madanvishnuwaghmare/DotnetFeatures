using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudService.Controllers
{
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
            
        }
    }
}
