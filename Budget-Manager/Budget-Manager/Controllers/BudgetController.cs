using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;

namespace Budget_Manager.Controllers {
    public class BudgetController : Controller {
        IBudgetDal budgetDAL;

        public BudgetController(IBudgetDal budgetDAL) {
            this.budgetDAL = budgetDAL;
        }

        public IActionResult Index(BudgetPost bPost) {
            bPost.Results = budgetDAL.GetAllPosts();
            return View(bPost);
        }

        public IActionResult BudgetSelect(BudgetPost bPost) {

            return View(bPost);
        }

        public IActionResult Remove(BudgetPost bPost) {
            budgetDAL.RemovePost(bPost);
            return RedirectToAction("Index", "Budget", bPost);
        }

        [HttpGet]
        public IActionResult NewBudget() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewBudget(BudgetPost bPost) {
            try {
                bPost.ImgBudgetId = bPost.BudgetCategory;
                budgetDAL.SaveNewPost(bPost);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Budget", bPost);
        }
    }
}