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

        public IActionResult Index(BudgetPost bPost) {
            return View();
        }

        [HttpGet]
        public IActionResult NewExpense(BudgetPost bPost) {

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
    }
}