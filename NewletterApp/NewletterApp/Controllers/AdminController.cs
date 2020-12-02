﻿using NewletterApp.Models;
using NewletterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewletterApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();

                var signups = (from c in db.SignUps
                               where c.Removed == null 
                               select c).ToList();
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {

                    var signupVm = new SignupVm();
                    signupVm.ID = signup.ID;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.Email;
                    signupVms.Add(signupVm);

                }
                return View(signupVms);
            }
        }
        public ActionResult Unsubscribe(int ID)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(ID);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}