using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budget_Manager.DAL;
using Budget_Manager.Models;

namespace LyftRecorder.Controllers {
    public class IncomeController : Controller {
        IIncomeDal incomeDAL;

        public IncomeController(IIncomeDal incomeDAL) {
            this.incomeDAL = incomeDAL;
        }

        public IActionResult Index(IncomePost iPost) {
            iPost.Results = incomeDAL.GetAllPosts();
            return View(iPost);
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
                iPost.PostSuccess = true;
            }
            catch (NullReferenceException) {
                iPost.PostSuccess = false;
            }
            return RedirectToAction("Index", "Income", iPost);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveIncome(IncomePost iPost) {
            try {
                incomeDAL.SaveNewPost(iPost);
                iPost.PostSuccess = true;
            }
            catch (NullReferenceException) {
                iPost.PostSuccess = false;
            }
            return RedirectToAction("Index", "Income", iPost);
        }
    }
}