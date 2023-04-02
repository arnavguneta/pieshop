using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPieRepository _pieRepository;

		public HomeController(IPieRepository ipieRepository)
		{
			_pieRepository = ipieRepository;
		}

		public IActionResult Index()
		{
			var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
			var homeViewModel = new HomeViewModel(piesOfTheWeek);
			return View(homeViewModel);
		}
	}
}
