using Budget_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Manager.DAL {
    public interface IExpenseDal {
        List<ExpensePost> GetAllPosts(int budgetId);
        bool SaveNewPost(ExpensePost post);
        bool RemovePost(ExpensePost post);
    }
}
