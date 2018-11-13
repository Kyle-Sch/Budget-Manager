using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LyftRecorder.Models;

namespace LyftRecorder.DAL {
    public class FormSqlDal : IFormDal {
        private string ConnString;

        public FormSqlDal(string connString) {
            ConnString = connString;
        }

        public List<FormPost> GetAllPosts() {
            List<FormPost> posts = new List<FormPost>();

            using (SqlConnection conn = new SqlConnection(ConnString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Rides", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    FormPost temp = new FormPost();
                    temp.PickupTime = Convert.ToDateTime(reader["PickupTime"]);
                    temp.DropOffTime = Convert.ToDateTime(reader["DropoffTime"]);
                    temp.PassengerCancelled = Convert.ToBoolean(reader["PassengerCancelled"]);
                    temp.DriverCancelled = Convert.ToBoolean(reader["DriverCancelled"]);
                    temp.RideDistance = Convert.ToDecimal(reader["RideDistance"]);
                    temp.RidePrice = Convert.ToDecimal(reader["RidePrice"]);
                    temp.Tips = Convert.ToDecimal(reader["Tips"]);
                    temp.RideEarnings = temp.RidePrice + temp.Tips;
                    temp.RideDuration = temp.DropOffTime - temp.PickupTime.TimeOfDay;
                    posts.Add(temp);
                }
                return posts;
            }
        }

        public bool SaveNewPost(FormPost post) {
            try {
                using (SqlConnection conn = new SqlConnection(ConnString)) {
                    conn.Open();

                    string sql = $"INSERT INTO Rides VALUES (@PickupTime, @DropOffTime, @PassengerCancelled, @DriverCancelled, @RideDistance, @RidePrice, @Tips);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@PickupTime", post.PickupTime);
                    cmd.Parameters.AddWithValue("@DropOffTime", post.DropOffTime);
                    cmd.Parameters.AddWithValue("@PassengerCancelled", post.PassengerCancelled);
                    cmd.Parameters.AddWithValue("@DriverCancelled", post.DriverCancelled);
                    cmd.Parameters.AddWithValue("@RideDistance", post.RideDistance);
                    cmd.Parameters.AddWithValue("@RidePrice", post.RidePrice);
                    cmd.Parameters.AddWithValue("@Tips", post.Tips);

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
