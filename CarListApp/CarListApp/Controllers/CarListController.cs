﻿using System;
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

        //[Route("/search/{brand}")]
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[Route("/api/search/{brand}")]
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return Json(new object());
        //}
    }
}
