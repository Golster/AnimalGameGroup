using AnimalGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimalGame.Controllers
{
    public class GameResultController : Controller
    {
        // GET: GameResult
        public ActionResult Index()
        {

            DTOGameResult result = new DTOGameResult();

            return View(result);
        }

        // GET: GameResult/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameResult/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameResult/Create
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

        // GET: GameResult/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameResult/Edit/5
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

        // GET: GameResult/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameResult/Delete/5
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
