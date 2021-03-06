﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Manager.Models {
    public class IncomePost {
        public int IncomeId { get; set; }
        public int BudgetId { get; set; }
        [Required]
        public string IncomeDescription { get; set; }
        [Required]
        public decimal IncomeAmount { get; set; }
        public string IncomeCategory { get; set; }
        public bool IsActive { get; set; }

        public IList<IncomePost> Results { get; set; }

        public static List<SelectListItem> IncomeCategories = new List<SelectListItem>()
       {
            new SelectListItem() { Text = "Primary", Value = "Primary" },
            new SelectListItem() { Text = "Secondary", Value = "Secondary" },
            new SelectListItem() { Text = "Miscellaneous", Value = "Miscellaneous" },
            };
    }
}
