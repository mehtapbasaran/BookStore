﻿
using BookStore.DataAccess.IMainRepository;
using BookStore.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        #region Variables
        private readonly IUnitOfWork _uow; 
        #endregion

        #region Constructor
        public CategoryController(IUnitOfWork uow)
        {
            _uow = uow;
        } 
        #endregion

        #region Actions
        public IActionResult Index()
        {
            return View();
        } 
        #endregion

        #region API CALLS
        public IActionResult GetAll()
        {
            var allObj = _uow.Category.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var deleteData = _uow.Category.Get(id);
            if (deleteData == null)
                return Json(new { success = false, message = "Data Not Found!" });

            _uow.Category.Remove(deleteData);
            _uow.Save();
            return Json(new { success = true, message = "Delete Operation Successfully" });
        }

        #endregion

        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            Category cat = new Category();
            if (id == null)
            {
                
                return View(cat);
            }

            cat = _uow.Category.Get((int)id);
            if (cat != null)
            {
                return View(cat);
            }
            return NotFound();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    //Create
                    _uow.Category.Add(category);
                }
                else
                {
                    //Update
                    _uow.Category.Update(category);
                }
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
