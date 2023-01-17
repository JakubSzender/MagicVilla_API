using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/UsersAuth")]
    [ApiController]
    public class UsersController : Controller
    {
        public readonly IUserRepository _userRepo;
        public UsersController(IUserRepository userRepo)
        {
            _userRepo= userRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
