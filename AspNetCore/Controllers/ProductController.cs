﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
