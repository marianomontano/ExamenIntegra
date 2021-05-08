﻿using Integra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace Integra.Controllers
{
    public class ClientesController : Controller
    {
        IntegraDb db = new IntegraDb();

        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = db.Clientes.ToList();
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = db.Clientes.Find(id);
            if(cliente == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
			}

            return View(cliente);
        }

		// GET: Clientes/Create
		public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if(!ModelState.IsValid)
				{
                    return View(cliente);
				}

                db.Clientes.Add(cliente);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = db.Clientes.Find(id);

            if(cliente == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
			}

            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                var clienteviejo = db.Clientes.Find(id);

                if(clienteviejo == null)
				{
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
				}
				if (!ModelState.IsValid)
				{
                    return View(cliente);
				}

                clienteviejo = cliente;
                db.Entry(clienteviejo).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
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