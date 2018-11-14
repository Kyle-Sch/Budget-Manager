using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Budget_Manager.Models;

namespace Budget_Manager.DAL {
    public class IncomeSqlDal : IIncomeDal {
        private string ConnString;

        public IncomeSqlDal(string connString) {
            ConnString = connString;
        }

        public List<IncomePost> GetAllPosts() {
            List<IncomePost> posts = new List<IncomePost>();

            using (SqlConnection conn = new SqlConnection(ConnString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Income_Streams", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    IncomePost temp = new IncomePost();
                    temp.IncomeId = Convert.ToInt32(reader["IncomeId"]);
                    temp.BudgetDescription = Convert.ToString(reader["BudgetDescription"]);
                    temp.IncomeDescription = Convert.ToString(reader["IncomeDescription"]);
                    temp.IncomeAmount = Convert.ToInt32(reader["IncomeAmount"]);
                    temp.IncomeCategory = Convert.ToString(reader["IncomeCategory"]);
                    temp.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    posts.Add(temp);
                }
                return posts;
            }
        }

        public bool SaveNewPost(IncomePost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    string sql = $"INSERT INTO Income_Streams VALUES (@BudgetDescription, @IncomeDescription, @IncomeAmount" +
                        $", @IncomeCategory, @IsActive);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@BudgetDescription", post.BudgetDescription);
                    cmd.Parameters.AddWithValue("@IncomeDescription", post.IncomeDescription);
                    cmd.Parameters.AddWithValue("@IncomeAmount", post.IncomeAmount);
                    cmd.Parameters.AddWithValue("@IncomeCategory", post.IncomeCategory);
                    cmd.Parameters.AddWithValue("@IsActive", post.IsActive);

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
