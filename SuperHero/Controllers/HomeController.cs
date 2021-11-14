using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperHero.Models;
using SuperHerore.Application.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //const string SessionName = "_Name";
        private readonly IMediator _mediator;
        private const string filterName = "search";
        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var filter = HttpContext.Session.GetString(filterName);
            ViewBag.serach = filter;
            if (filter != null)
            {
                var command = new SearchCommand { Search = filter };
                var model = await _mediator.Send(command);
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string search)
        {
            ViewBag.serach = search;
            HttpContext.Session.SetString(filterName, search);
            var command = new SearchCommand { Search = search ?? string.Empty };
            var model = await _mediator.Send(command);
            return View(model);
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
