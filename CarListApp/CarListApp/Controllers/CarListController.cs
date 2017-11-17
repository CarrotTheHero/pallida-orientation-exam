using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarListApp.Repositories;

namespace CarListApp.Controllers
{
    public class CarListController : Controller
    {
        CarListRepository CarListRepository;

        public CarListController(CarListRepository carListRepository)
        {
            CarListRepository = carListRepository;
        }
        
        [Route("/search")]
        [HttpGet]
        public IActionResult PlateSearcher(string plate)
        {
            return View("Index", CarListRepository.CarSearcher(plate));
        }

        [Route("/search/{brand}")]
        [HttpGet]
        public IActionResult Index(string brand)
        {
            return View("Index", CarListRepository.BrandSearcher(brand));
        }

        [Route("/api/search/{brand}")]
        [HttpGet]
        public IActionResult IndexForApi(string brand)
        {
            return Json(CarListRepository.BrandSearcher(brand));
        }

        [Route("/search/police=1")]
        [HttpGet]
        public IActionResult Police()
        {
            return View("Index", CarListRepository.PoliceSearcher());
        }

        [Route("/search/diplomat=1")]
        [HttpGet]
        public IActionResult Diplomat()
        {
            return View("Index", CarListRepository.DiplomatSearcher());
        }
    }
}
