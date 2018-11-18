using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Budget_Manager.Models;

namespace Budget_Manager.DAL {
    public class BudgetSqlDal : IBudgetDal {
        private string ConnString;

        public BudgetSqlDal(string connString) {
            ConnString = connString;
        }

        private const string GET_ALL_Budgets_SQL = "SELECT * from Budget";
        private const string Insert_Budget_SQL = "INSERT INTO Budget VALUES (@BudgetName, @BudgetCategory, @IsActive);";
        private const string Remove_Budgets_SQL = "UPDATE Budget SET IsActive = @IsActive, WHERE BudgetId = @BudgetId;";


        public List<BudgetPost> GetAllPosts() {
            List<BudgetPost> posts = new List<BudgetPost>();

            using (SqlConnection conn = new SqlConnection(ConnString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(GET_ALL_Budgets_SQL, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) { 
                    BudgetPost temp = new BudgetPost();
                    temp.BudgetId = Convert.ToInt32(reader["BudgetId"]);
                    temp.BudgetCategory = Convert.ToString(reader["BudgetCategory"]);
                    temp.BudgetName = Convert.ToString(reader["BudgetName"]);
                    temp.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    if (temp.IsActive) {
                        posts.Add(temp);
                    }
                }
                return posts;
            }
        }

        public bool SaveNewPost(BudgetPost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Insert_Budget_SQL, conn);
                    cmd.Parameters.AddWithValue("@BudgetName", post.BudgetName);
                    cmd.Parameters.AddWithValue("@BudgetCategory", post.BudgetCategory);
                    cmd.Parameters.AddWithValue("@IsActive", true);

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
        public bool RemovePost(BudgetPost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Insert_Budget_SQL, conn);
                    cmd.Parameters.AddWithValue("@BudgetId", post.BudgetId);
                    cmd.Parameters.AddWithValue("@IsActive", false);

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
