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

        public List<Budget> GetAllPosts() {
            List<Budget> posts = new List<Budget>();

            using (SqlConnection conn = new SqlConnection(ConnString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Budget", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    Budget temp = new Budget();
                    temp.BudgetId = Convert.ToInt32(reader["BudgetId"]);
                    temp.BudgetCategory = Convert.ToString(reader["BudgetName"]);
                    temp.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    
                    posts.Add(temp);
                }
                return posts;
            }
        }

        public bool SaveNewPost(Budget post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    string sql = $"INSERT INTO Budget VALUES (@BudgetId, @BudgetName, @IsActive);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@BudgetId", post.BudgetId);
                    cmd.Parameters.AddWithValue("@BudgetName", post.BudgetCategory);
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
            catch (SqlException ) {
                return false;
            }
        }
    }
}
