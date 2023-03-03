using HelpDeskTicketSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskTicketSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        FavoriteDbContext dbContext = new FavoriteDbContext();

        //[HttpGet("Favorites")]
        //public List<Favorite> GetFavorites()
        //{
        //    List<Favorite> Favorites = new List<Favorite>();
        //    Favorites.Add(dbContext);
        //    return dbContext.Favorites;
        //}
    }
}
