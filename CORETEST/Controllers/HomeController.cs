using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CORETEST.Models;

namespace CORETEST.Controllers
{
	public class HomeController : Controller
	{
		public HomeController(IEmployeeRepository employeeRepository)
		{
			_eemployeeRepository = employeeRepository;
		}
		//private readonly ILogger<HomeController> _logger;
		private IEmployeeRepository _eemployeeRepository;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		public string Index()
		{
			return _eemployeeRepository.GetEmployee(1).Name;
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
