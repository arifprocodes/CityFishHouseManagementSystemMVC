﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineFishHouseManagementSystemMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult UserList()
        {
            return View();
        }
        public ActionResult Feeedback()
        {
            return View();
        }
        public ActionResult TicketData()
        {
            return View();
        }
    }
}