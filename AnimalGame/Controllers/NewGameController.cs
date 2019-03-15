using AnimalGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimalGame.Controllers
{
    public class NewGameController : Controller
    {

        private AnimalGameGroupEntities db = new AnimalGameGroupEntities();

        // GET: NewGame
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTOGame currentGame)
        {
            if (ModelState.IsValid)
            {

                db.Games.Add(currentGame.GameRound);
                db.SaveChanges();

                currentGame.CurrentPlayer.Game_Id = currentGame.GameRound.ID;
                db.Players.Add(currentGame.CurrentPlayer);
                db.SaveChanges();

                //string publicId = currentGame.GameRound.PublicId;
                DTOGameSession session = new DTOGameSession(currentGame);

                return View("~/Views/GameSession/index.cshtml", session);



            }
            else return new HttpStatusCodeResult(404);
        }

        public ActionResult Join()
        {
            return View();
        }

        // GET: NewGame/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: NewGame/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: NewGame/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewGame/Edit/5
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

        // GET: NewGame/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewGame/Delete/5
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
