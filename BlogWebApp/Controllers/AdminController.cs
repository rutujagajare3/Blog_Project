﻿using BlogWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi;
using WebApplicationApi.Controllers;
using WebApplicationApi.Models;

namespace BlogWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            
                IEnumerable<Admin> adminlist;
                HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("AdminInfoes").Result;
                adminlist = response.Content.ReadAsAsync<IEnumerable<Admin>>().Result;
                return View(adminlist);
            }
            [HttpGet]
            public ActionResult Login()
            {
                return View(new Admin());

            }

            [HttpPost]
            public ActionResult Login(Admin admin)
            {
                if (ModelState.IsValid)
                {
                    if ((admin.EmailId == "admin@gmail.com") && (admin.Password == "9090"))
                    {

                        return RedirectToAction("Index", "Employee");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Either username and password incorrect!!!");
                        return View(admin);
                    }
                }
                else { return View(admin); }
            }
            public IActionResult Logout()
            {
                return RedirectToAction("Login", "Admin");
            }

        }
    }