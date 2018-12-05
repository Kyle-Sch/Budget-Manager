using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;
using Budget_Manager.Extensions;

namespace Budget_Manager.Controllers {
    public class IncomeController : Controller {
        IIncomeDal incomeDAL;

        public IncomeController(IIncomeDal incomeDAL) {
            this.incomeDAL = incomeDAL;
        }

        public IActionResult Index(){
            IncomePost iPost = new IncomePost();
            iPost.Results = incomeDAL.GetAllPosts(GetTempBudgetID());
            return View(iPost);
        }
        
        [HttpGet]
        public IActionResult NewIncome() {
            IncomePost newIncome = new IncomePost();
            newIncome.BudgetId = GetTempBudgetID();
            return View(newIncome);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewIncome(IncomePost income) {
            try {
                incomeDAL.SaveNewPost(income);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Income");
        }

        public IActionResult RemoveIncome(IncomePost income) {
            try {
                incomeDAL.RemovePost(income);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Income");
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