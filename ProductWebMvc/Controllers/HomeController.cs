using Microsoft.AspNetCore.Mvc;
using ProductWebMvc.Models;
using System.Diagnostics;

namespace ProductWebMvc.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly HttpClient _httpClient;
      

        public HomeController( IHttpClientFactory httpClient)
        {
            
            _httpClient = httpClient.CreateClient();
        }

        public IActionResult Index(int? id)
        {
            HomeIndexViewModel model = new HomeIndexViewModel(_httpClient, id);
            
            return View(model);
        }

        public IActionResult Products(int cid,string cname )
        {
            HomeIndexViewModel model = new HomeIndexViewModel(_httpClient, cid);

            return View(nameof(Index), model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}