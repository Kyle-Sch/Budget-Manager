using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;

namespace LyftRecorder.Controllers {
    public class BudgetController : Controller {
        IBudgetDal budgetDAL;

        public BudgetController(IBudgetDal budgetDAL) {
            this.budgetDAL = budgetDAL;
        }

        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public IActionResult NewBudget() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewBudget(Budget bPost) {
            try {
                bPost.BudgetId = Budget.BudgetIds[bPost.BudgetCategory];
                bPost.ImgBudgetId = 
                budgetDAL.SaveNewPost(bPost);
                bPost.PostSuccess = true;
            }
            catch (NullReferenceException) {
                bPost.PostSuccess = false;
            }
            return RedirectToAction("Index", "Expense", bPost);
        }
    }
}