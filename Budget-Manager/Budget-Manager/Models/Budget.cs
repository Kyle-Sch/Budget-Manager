using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Manager.Models {
    public class Budget {
        public int BudgetId { get; set; }
        private string imgBudgetId = "";
        public string ImgBudgetId {
            get {
                return imgBudgetId;
            }
            set {
                imgBudgetId = value.ToLower() + ".jpg";
            }
        }
        public string BudgetCategory { get; set; }
        public bool IsActive { get; set; }
        public bool PostSuccess { get; set; }

        public IList<Budget> Results { get; set; }

        public static List<SelectListItem> BudgetCategories = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "During School", Value = "duringschool" },
            new SelectListItem() { Text = "Employed Full Time", Value = "ftemployed" },
            new SelectListItem() { Text = "Before Vacation", Value = "vacation" },
            };
        public static Dictionary<string,int> BudgetIds = new Dictionary<string, int>()
         {
            { "duringschool", 1 },
            { "ftemployed", 2 },
            { "vacation", 3 },
            };
    }
}
