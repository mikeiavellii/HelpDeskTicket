using HelpDeskTicketSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskTicketSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        TicketDbContext dbContext = new TicketDbContext();

        [HttpPut("Favorites")]
        public List<Favorite> GetFavorites()
        {

            return dbContext.Favorites.ToList();
        }

    }
}
