﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: ProdutosController
        public ActionResult Index()
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto(1, "Cadeira", 100.00));
            lista.Add(new Produto(1, "Mesa", 200.00));
            lista.Add(new Produto(1, "Fogão", 300.00));
            lista.Add(new Produto(1, "Geladeira", 400.00));
            lista.Add(new Produto(1, "TV", 500.00));
            lista.Add(new Produto(1, "Sofá", 600.00));
            lista.Add(new Produto(1, "Guarda-Roupas", 700.00));
            lista.Add(new Produto(1, "Estante", 800.00));
            lista.Add(new Produto(1, "Armário", 900.00));
            lista.Add(new Produto(1, "Cama", 1000.00));
            return View(lista);
        }

        // GET: ProdutosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProdutosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutosController/Edit/5
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

        // GET: ProdutosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutosController/Delete/5
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
