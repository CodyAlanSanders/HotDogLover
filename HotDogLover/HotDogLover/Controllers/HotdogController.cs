﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotDogLover.Controllers
{
    public class HotdogController : Controller
    {
        // GET: Hotdog
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hotdog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hotdog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotdog/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hotdog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hotdog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hotdog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hotdog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}