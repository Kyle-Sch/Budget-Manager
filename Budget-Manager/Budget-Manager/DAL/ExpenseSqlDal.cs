using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Budget_Manager.Models;

namespace Budget_Manager.DAL {
    public class ExpenseSqlDal : IExpenseDal {
        private string ConnString;

        public ExpenseSqlDal(string connString) {
            ConnString = connString;
        }

        private const string GET_ALL_Expenses_SQL = "SELECT * from Expense where BudgetId = @BudgetId";
        private const string Insert_Expense_SQL = "INSERT INTO Expense " +
            "VALUES (@ExpenseDescription, @ExpenseCategory, @ExpenseAmount, BudgetID, 'true');";
        private const string Remove_Expense_SQL = "Update Expense set IsActive = 'false' " +
            "where ExpenseId = @ExpenseId;";

        public List<ExpensePost> GetAllPosts(int budgetId) {
            List<ExpensePost> posts = new List<ExpensePost>();

            using (SqlConnection conn = new SqlConnection(ConnString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(GET_ALL_Expenses_SQL, conn);

                cmd.Parameters.AddWithValue("@BudgetID", budgetId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    ExpensePost temp = new ExpensePost();
                    temp.ExpenseId = Convert.ToInt32(reader["ExpenseId"]);
                    temp.BudgetId = Convert.ToInt32(reader["BudgetId"]);
                    temp.ExpenseDescription = Convert.ToString(reader["ExpenseDescription"]);
                    temp.ExpenseCategory = Convert.ToString(reader["ExpenseCategory"]);
                    temp.ExpenseAmount = Convert.ToDecimal(reader["ExpenseAmount"]);
                    temp.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    if (temp.IsActive) {
                        posts.Add(temp);
                    }
                }
                return posts;
            }
        }

        public bool SaveNewPost(ExpensePost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Insert_Expense_SQL, conn);
                    cmd.Parameters.AddWithValue("@ExpenseDescription", post.ExpenseDescription);
                    cmd.Parameters.AddWithValue("@ExpenseCategory", post.ExpenseCategory);
                    cmd.Parameters.AddWithValue("@ExpenseAmount", post.ExpenseAmount);
                    cmd.Parameters.AddWithValue("@BudgetID", post.BudgetId);

                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            catch (SqlException) {
                return false;
            }

        }
        public bool RemovePost(ExpensePost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Remove_Expense_SQL, conn);
                    cmd.Parameters.AddWithValue("@ExpenseId", post.ExpenseId);

                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            catch (SqlException) {
                return false;
            }
        }
    }
}
