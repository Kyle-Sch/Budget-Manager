using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;

namespace Budget_Manager.Controllers {
    public class ExpenseController : Controller {
        IExpenseDal expenseDAL;

        public ExpenseController(IExpenseDal expenseDAL) {
            this.expenseDAL = expenseDAL;
        }

        public IActionResult Index(int budgetId) {
            ExpensePost ePost = new ExpensePost();
            ePost.Results = expenseDAL.GetAllPosts(budgetId);
            return View(ePost);
        }
        public IActionResult BudgetSelect(BudgetPost bPost) {
            return RedirectToAction("Index", "Income", bPost.BudgetId);
        }
        [HttpGet]
        public IActionResult NewExpense() {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewExpense(ExpensePost ePost) {
            try {
                expenseDAL.SaveNewPost(ePost);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Expense", ePost);
        }

        public IActionResult RemoveExpense(ExpensePost ePost) {
            try {
                expenseDAL.RemovePost(ePost);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Income", ePost.BudgetId);
        }
    }
}