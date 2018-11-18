using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Manager.Models {
    public class ExpensePost {
        public int ExpenseId { get; set; }
        public int BudgetId { get; set; }
        public string ExpenseDescription { get; set; }
        public string ExpenseCategory { get; set; }
        public decimal ExpenseAmount { get; set; }
        public bool IsActive { get; set; }
        public int GroupId { get; set; }
        public bool PostSuccess { get; set; }

        public IList<ExpensePost> Results { get; set; }

        public static List<SelectListItem> ExpenseCategories = new List<SelectListItem>()
       {
            new SelectListItem() { Text = "Vehicle Gas", Value = "gas" },
            new SelectListItem() { Text = "Food", Value = "food" },
            new SelectListItem() { Text = "Car Insurance", Value = "carinsurance" },
            new SelectListItem() { Text = "Student Loans", Value = "studentloans" },
            new SelectListItem() { Text = "Health Insurance", Value = "healthinsurance" },
            new SelectListItem() { Text = "Dental Insurance", Value = "dentalinsurance" },
            new SelectListItem() { Text = "Rent", Value = "rent" },
            new SelectListItem() { Text = "Utilities", Value = "utilities" },
            new SelectListItem() { Text = "Emergency Fund", Value = "emergencyfund" },
            new SelectListItem() { Text = "Entertainment", Value = "entertainment" },
        };
    }
}
