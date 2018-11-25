using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;
using Budget_Manager.Extensions;

namespace Budget_Manager.Controllers {
    public class ExpenseController : Controller {
        IExpenseDal expenseDAL;

        public ExpenseController(IExpenseDal expenseDAL) {
            this.expenseDAL = expenseDAL;
        }

        public IActionResult Index() {
            ExpensePost ePost = new ExpensePost();
            ePost.Results = expenseDAL.GetAllPosts(GetTempBudgetID());
            return View(ePost);
        }
        //public IActionResult BudgetSelect(BudgetPost bPost) {
        //    return RedirectToAction("Index", "Expense", GetTempBudgetID());
        //}
        [HttpGet]
        public IActionResult NewExpense() {
            ExpensePost newpost = new ExpensePost();
            newpost.BudgetId = GetTempBudgetID();
            return View(newpost);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewExpense(ExpensePost post) {
            try {
                expenseDAL.SaveNewPost(post);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Expense");
        }

        public IActionResult RemoveExpense(ExpensePost post) {
            try {
                expenseDAL.RemovePost(post);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Expense");
        }

        const string TEMP_SESSION_ID = "Budget_Id";

        private int GetTempBudgetID() {
            int id = Convert.ToInt32(HttpContext.Session.Get<string>(TEMP_SESSION_ID));

             if (id < 0) {

                id = 0;
                HttpContext.Session.Set(TEMP_SESSION_ID, id);
            }
            return id;
        }
    }
}