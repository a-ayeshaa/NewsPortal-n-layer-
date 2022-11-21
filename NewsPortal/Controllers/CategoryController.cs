using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View(CategoryService.GetCategory());
        }

        public ActionResult Details(int id)
        {
            return View(CategoryService.GetCategory(id));
        }

        public ActionResult Delete(int id)
        {
            CategoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }

        public ActionResult Add(CategoryDTO c)
        {
            CategoryService.AddCategory(c);
            return RedirectToAction("Index");
        }
    }
}