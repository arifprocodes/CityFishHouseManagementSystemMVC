using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using OnlineFishHouseManagementSystemMVC.Models;

namespace OnlineFishHouseManagementSystemMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult News()
        {
            
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserTB userTB)
        {
            using(FishTicketDataEntities db=new FishTicketDataEntities())
            {
                if(ModelState.IsValid)
                {
                    db.UserTBs.Add(userTB);
                    db.SaveChanges();
                    ViewBag.Message = "Registration Sucessfuly";
                    ModelState.Clear();
                }
                return View(userTB);
            }
        }
        [HttpPost]
        public ActionResult Contact(FeedBackTB feedBackTB)
        {
            using (FishTicketDataEntities db = new FishTicketDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.FeedBackTBs.Add(feedBackTB);
                    db.SaveChanges();
                    ViewBag.Message = "Feedback Send Sucessfuly";
                    ModelState.Clear();
                }
                return View(feedBackTB);
            }
        }
        [HttpPost]
        public ActionResult Booking(BookingTBL bookingTBL)
        {
            using (FishTicketDataEntities db = new FishTicketDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.BookingTBLs.Add(bookingTBL);
                    db.SaveChanges();
                    ViewBag.Message = "Ticket Booking  Sucessfuly";
                    ModelState.Clear();
                }
                return View(bookingTBL);
            }
        }
        [HttpPost]
        public ActionResult Login(UserTB userTB)
        {
            using (FishTicketDataEntities db = new FishTicketDataEntities())
            {
                if (ModelState.IsValid)
                {
                    var obj = db.UserTBs.Where(a => a.email.Equals(userTB.userName) && a.pass.Equals(userTB.pass)).FirstOrDefault();
                    if (obj != null)
                    {
                        //Session["UserID"] = obj.UserId.ToString();
                        //Session["UserName"] = obj.email.ToString();
                        return RedirectToAction("Home/Booking");
                    }
                    ModelState.Clear();
                }
                return View(userTB);
                
            }
        }
    }
}
