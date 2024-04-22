using Alarma.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alarma.Controllers
{
    public class AlarmasController : Controller
    {
        // GET: Alarmas
        public ActionResult Index()
        {
            using (DbModelss context = new DbModelss())
            {
                return View(context.Alarmass.ToList());
            }
        }

        // GET: Alarma/Details/5
        public ActionResult Details(int id)
        {
            using (DbModelss context = new DbModelss())
            {
                return View(context.Alarmass.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Alarma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alarma/Create
        [HttpPost]
        public ActionResult Create(Alarmass alarmass)
        {
            try
            {
                using (DbModelss context = new DbModelss())
                {
                    context.Alarmass.Add(alarmass);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alarma/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModelss context = new DbModelss())
            {
                return View(context.Alarmass.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Alarma/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alarmass alarmass)
        {
            try
            {
                using (DbModelss context = new DbModelss())
                {
                    context.Entry(alarmass).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Alarma/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModelss context = new DbModelss())
            {
                return View(context.Alarmass.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Alarma/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModelss context = new DbModelss())
                {
                    Alarmass alarm = context.Alarmass.Where(XmlReadMode => XmlReadMode.id == id).FirstOrDefault();
                    context.Alarmass.Remove(alarm);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
