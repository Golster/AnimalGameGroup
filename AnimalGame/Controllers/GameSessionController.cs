using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimalGame.Controllers
{
    public class GameSessionController : Controller
    {
        // GET: GameSession
        public ActionResult Index()
        {
            return View();
        }

        // GET: GameSession/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameSession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameSession/Create
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

        // GET: GameSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameSession/Edit/5
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

        // GET: GameSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameSession/Delete/5
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
