﻿using Budget_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Manager.DAL {
    public interface IBudgetDal {
        List<BudgetPost> GetAllPosts();
        bool SaveNewPost(BudgetPost post);
        bool RemovePost(BudgetPost post);
    }
}
