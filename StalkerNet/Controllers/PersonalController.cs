using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StalkerNet.Models;

namespace StalkerNet.Controllers
{
    public class PersonalController : Controller
    {
        List<Person> people;

        public PersonalController()
        {
            people = new List<Person>
            {
                new Person() { id=0, firstname = "G", middlename = "Scott", lastname = "Madeira", cell = "4124180163", relationship = "dad", familyId = 0 },
                new Person() { id=1, firstname="Jean" , middlename="E" , lastname="Madeira" , cell="4125551122" , relationship="mom" , familyId=0 },
                new Person() { id=2, firstname="Nick" , middlename="A" , lastname="Madeira" , cell="4125559988" , relationship="son" , familyId=0 },
                new Person() { id=3, firstname="John" , middlename="M" , lastname="Madeira" , cell="4125551234" , relationship="son" , familyId=0 },
                new Person() { id=4, firstname="Chris" , middlename="T" , lastname="Madeira" , cell="4125556758" , relationship="son" , familyId=0 },
                new Person() { id=5, firstname="Jimmy" , middlename="J" , lastname="Johns" , cell="6075556758" , relationship="dad" , familyId=1 },
                new Person() { id=6, firstname="Stacey" , middlename="H" , lastname="Johns" , cell="6075556757" , relationship="mom" , familyId=1 },
                new Person() { id=7, firstname="Ian" , middlename="F" , lastname="Johns" , cell="6075552257" , relationship="son" , familyId=1 },
                new Person() { id=8, firstname="Avery" , middlename="K" , lastname="Johns" , cell="6075534757" , relationship="daughter" , familyId=1 },
                new Person() { id=9, firstname="Roy" , middlename="F" , lastname="Ellis" , cell="9035534757" , relationship="dad" , familyId=2 },
                new Person() { id=10, firstname="Michelle" , middlename="" , lastname="Ellis" , cell="9035531947" , relationship="mom" , familyId=2 },
                new Person() { id=11, firstname="Bernie" , middlename="S" , lastname="Braddock" , cell="8145534757" , relationship="mom" , familyId=3 },
                new Person() { id=12, firstname="Mark" , middlename="P" , lastname="Anderson" , cell="3025534757" , relationship="son" , familyId=3 }
            };

        }

        // GET: Personal
        public ActionResult Index()
        {
            return View(people);
        }

        // GET: Personal/Details/5
        public ActionResult Details(int id)
        {
            var p = people[id];
            return View(p);
        }

        // GET: Personal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personal/Create
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

        // GET: Personal/Edit/5
        public ActionResult Edit(int id)
        {
            var p = people[id];
            return View(p);
        }

        // POST: Personal/Edit/5
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

        // GET: Personal/Delete/5
        public ActionResult Delete(int id)
        {
            var p = people[id];
            return View(p);
        }

        // POST: Personal/Delete/5
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
