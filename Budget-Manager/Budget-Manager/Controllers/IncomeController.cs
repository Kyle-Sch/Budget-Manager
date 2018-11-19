using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;

namespace Budget_Manager.Controllers {
    public class IncomeController : Controller {
        IIncomeDal incomeDAL;

        public IncomeController(IIncomeDal incomeDAL) {
            this.incomeDAL = incomeDAL;
        }

        public IActionResult Index(int budgetId) {
            IncomePost iPost = new IncomePost();
            iPost.Results = incomeDAL.GetAllPosts(budgetId);
            return View(iPost);
        }
        public IActionResult BudgetSelect(BudgetPost bPost) {
            return RedirectToAction("Index", "Income", bPost.BudgetId);
        }
        [HttpGet]
        public IActionResult NewIncome() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewIncome(IncomePost iPost) {
            try {
                incomeDAL.SaveNewPost(iPost);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Income", iPost.BudgetId);
        }

        public IActionResult RemoveIncome(IncomePost iPost) {
            try {
                incomeDAL.RemovePost(iPost);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Income", iPost.BudgetId);
        }
    }
}