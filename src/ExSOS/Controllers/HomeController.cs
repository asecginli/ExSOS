// ======================================
// Author: Atif SECGINLI
// Email:  info@intapptech.com
// Copyright (c) 2017 www.intapptech.com
// 
// ==> Gun4Hire: contact@intapptech.com
// ======================================

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace IntAppTech.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }





        // GET api/values
        [Route("api/[controller]"), Authorize, HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
