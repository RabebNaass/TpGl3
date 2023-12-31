﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MembershiptypeController : Controller
    {

        private readonly AppDbContext _db;

        public MembershiptypeController(AppDbContext db)
        { _db = db; }

        // GET: MembershiptypeController
        public ActionResult Index()
        {
            List<Membershiptype> member = _db.Membershiptypes.ToList();
            return View(member);
        }

        // GET: MembershiptypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MembershiptypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembershiptypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Membershiptype m)
        {

            m.Id = new Guid();
            _db.Membershiptypes.Add(m);
            _db.SaveChanges();


            return RedirectToAction(nameof(Index));


        }




        // GET: MembershiptypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MembershiptypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembershiptypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MembershiptypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}