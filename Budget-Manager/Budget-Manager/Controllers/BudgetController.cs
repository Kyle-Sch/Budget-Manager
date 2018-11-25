using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;
using Budget_Manager.Extensions;

namespace Budget_Manager.Controllers {
    public class BudgetController : Controller {
        IBudgetDal budgetDAL;

        public BudgetController(IBudgetDal budgetDAL) {
            this.budgetDAL = budgetDAL;
        }

        public IActionResult Index() {
            BudgetPost bPost = new BudgetPost();
            bPost.Results = budgetDAL.GetAllPosts();
            return View(bPost);
        }

        public IActionResult BudgetSelect(BudgetPost bPost) {

            SetTempCategory(bPost.BudgetId);
            return View(bPost);
        }

        public IActionResult Remove(BudgetPost bPost) {
            budgetDAL.RemovePost(bPost);
            return RedirectToAction("Index", "Budget");
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
                SetTempCategory(bPost.BudgetId);
            }
            catch (NullReferenceException) {
                throw;
            }
            return RedirectToAction("Index", "Budget");
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
        private void SetTempCategory(int id) {

            HttpContext.Session.Set(TEMP_SESSION_ID, id);

        }
    }
}