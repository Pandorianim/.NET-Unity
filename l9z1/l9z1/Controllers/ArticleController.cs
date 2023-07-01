using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using l9z1.DataContext;
using l9z1.ViewModels;

namespace l9z1.Controllers
{
    public class ArticleController : Controller
    {
        // remeber the context for an action
        private IArticlesContextL _dataContext;

        // injection of IDataContext 
        public ArticleController(IArticlesContextL dataContext)
        {
            this._dataContext = dataContext;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            return View(_dataContext.GetArticles());// addded parameter
        }

        public ActionResult AnotherIndex() // new action added manually
        {
            return View(_dataContext.GetArticles()); 
        }
        //[Route("newDetails/{id}", Name ="newDetailsRoute")]
        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_dataContext.GetArticle(id)); // added parameter
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article artic) // change of parameter, data binding
        {
            try
            {
                if (ModelState.IsValid)                // added
                    _dataContext.AddArticle(artic);  // added
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dataContext.GetArticle(id)); // added parameter
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Article artic) // change the second parameter
        {

            try
            {
                if (ModelState.IsValid)
                {
                    artic.Id = id; // added
                    _dataContext.UpdateArticle(artic); //added
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_dataContext.GetArticle(id)); // zmiana
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) //musi być inny nagłowek metody, zostaje
        {
            try
            {
                _dataContext.RemoveArticle(id); // zmiana
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
