﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace unit5.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet("/register")]
        public ActionResult RegisterDoctorView()
        {

           
            return View();
        }

        [HttpGet("/casulity")]
        public ActionResult CasualityView()
        {
            return View();

        }

        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registration/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registration/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}