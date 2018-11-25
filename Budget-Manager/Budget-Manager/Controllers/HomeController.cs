using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.Models;
using Budget_Manager.DAL;
using Budget_Manager.Extensions;

namespace Budget_Manager.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }
        public IActionResult Results() {
            ExpenseSqlDal expenseSql = new ExpenseSqlDal(@"Data Source=.\SQLEXPRESS;Initial Catalog=Budget-Manager;Integrated Security=True");
            List<ExpensePost> eList = expenseSql.GetAllPosts(GetTempBudgetID());
            decimal totalExpenses = 0;
            foreach (var expense in eList) {
                totalExpenses += expense.ExpenseAmount;
            }
            IncomeSqlDal incomeSql = new IncomeSqlDal(@"Data Source=.\SQLEXPRESS;Initial Catalog=Budget-Manager;Integrated Security=True");
            List<IncomePost> iList = incomeSql.GetAllPosts(GetTempBudgetID());
            decimal totalIncome = 0;
            foreach (var income in iList) {
                totalIncome += income.IncomeAmount;
            }
            decimal difference = totalIncome - totalExpenses;
            List<decimal> result = new List<decimal> { totalExpenses, totalIncome, difference };
            return View(result);
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
