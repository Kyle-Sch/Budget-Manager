﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;

namespace LyftRecorder.Controllers {
    public class ExpenseController : Controller {
        IExpenseDal expenseDAL;

        public ExpenseController(IExpenseDal expenseDAL) {
            this.expenseDAL = expenseDAL;
        }

        public IActionResult Index() {
            return View();
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
                ePost.PostSuccess = true;
            }
            catch (NullReferenceException) {
                ePost.PostSuccess = false;
            }
            return RedirectToAction("Index", "Expense", ePost);
        }
    }
}