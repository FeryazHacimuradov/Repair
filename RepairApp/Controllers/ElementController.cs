﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Controllers
{
    public class ElementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
