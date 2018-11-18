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

        private const string GET_ALL_Income_Streams_SQL = "SELECT * from Income";
        private const string Insert_Income_SQL = "INSERT INTO Income VALUES(@BudgetID, " +
            "@IncomeDescription, @IncomeAmount, @IncomeCategory, @IsActive);";
        private const string Remove_Income_SQL = "Update Income set IsActive = @IsActive " +
            "where IncomeId = @IncomeId;";

        public List<IncomePost> GetAllPosts() {
            List<IncomePost> posts = new List<IncomePost>();

            using (SqlConnection conn = new SqlConnection(ConnString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(GET_ALL_Income_Streams_SQL, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    IncomePost temp = new IncomePost();
                    temp.IncomeId = Convert.ToInt32(reader["IncomeId"]);
                    temp.BudgetId = Convert.ToInt32(reader["BudgetId"]); temp.IncomeDescription = Convert.ToString(reader["IncomeDescription"]);
                    temp.IncomeAmount = Convert.ToInt32(reader["IncomeAmount"]);
                    temp.IncomeCategory = Convert.ToString(reader["IncomeCategory"]);
                    temp.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    if (temp.IsActive) {
                        posts.Add(temp);
                    }
                }
                return posts;
            }
        }

        public bool SaveNewPost(IncomePost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Insert_Income_SQL, conn);
                    cmd.Parameters.AddWithValue("@BudgetID", post.BudgetId);
                    cmd.Parameters.AddWithValue("@IncomeDescription", post.IncomeDescription);
                    cmd.Parameters.AddWithValue("@IncomeAmount", post.IncomeAmount);
                    cmd.Parameters.AddWithValue("@IncomeCategory", post.IncomeCategory);
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
        public bool RemovePost(IncomePost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Remove_Income_SQL, conn);
                    cmd.Parameters.AddWithValue("@IncomeId", post.IncomeId);
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