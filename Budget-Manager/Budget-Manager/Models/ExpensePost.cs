using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Manager.Models {
    public class ExpensePost {
        public int ExpenseId { get; set; }
        public string ExpenseDescription { get; set; }
        public string ExpenseCategory { get; set; }
        public decimal ExpenseAmount { get; set; }
        public bool IsActive { get; set; }
        public int GroupId { get; set; }
        public bool PostSuccess { get; set; }

        public IList<ExpensePost> Results { get; set; }

        public static List<SelectListItem> ExpenseCategories = new List<SelectListItem>()
       {
            new SelectListItem() { Text = "Vehicle Gas", Value = "VGas" },
            new SelectListItem() { Text = "Food", Value = "Food" },
            new SelectListItem() { Text = "Car Insurance", Value = "CarInsurance" },
            new SelectListItem() { Text = "Student Loans", Value = "Student Loans" },
            new SelectListItem() { Text = "Health Insurance", Value = "HealthInsurance" },
            new SelectListItem() { Text = "Dental Insurance", Value = "DentalInsurance" },
            new SelectListItem() { Text = "Rent", Value = "Rent" },
            new SelectListItem() { Text = "Home Gas", Value = "HGas" },
            new SelectListItem() { Text = "Home Electricity", Value = "HElectric" },
            new SelectListItem() { Text = "Home Water", Value = "HWater" },
            new SelectListItem() { Text = "Misc", Value = "Misc" },
        };
    }
}
