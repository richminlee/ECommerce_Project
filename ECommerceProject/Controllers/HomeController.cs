using Microsoft.AspNetCore.Mvc;
using ECommerceProject.Models;

namespace ECommerceProject.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}