using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LyftRecorder.DAL;
using LyftRecorder.Models;

namespace LyftRecorder.Controllers {
    public class FormController : Controller {
        IFormDal formDAL;

        public FormController(IFormDal formDAL) {
            this.formDAL = formDAL;
        }

        public IActionResult Index(FormPost forumz) {
            forumz.Results = formDAL.GetAllPosts();
            return View(forumz);
        }
        [HttpGet]
        public IActionResult NewRide() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewRide(FormPost forums) {
            try {
                formDAL.SaveNewPost(forums);
                forums.PostSuccess = true;
            }
            catch (NullReferenceException) {
                forums.PostSuccess = false;
            }
            return RedirectToAction("Index", "Forum", forums);
        }
        public IActionResult Index() {
            return View();
        }
    }
}