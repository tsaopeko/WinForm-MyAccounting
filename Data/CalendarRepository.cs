using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyAccounting.Models;

namespace MyAccounting.Data
{
    public class CalendarRepository
    {
        /// <summary>
        /// 查詢特定日期的行程
        /// </summary>
        /// <param name="date">月曆日期</param>
        /// <returns>特定日期的行程, 用DataTable型別保存</returns>
        public DataTable GetByDate(DateTime date)
        {
            string sql = @"
                          SELECT Id, EventDate, EventTime, Title, Description
                          FROM Calendar
                          WHERE EventDate = @EventDate
                          ORDER BY EventTime
                          ";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EventDate", date);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// 新增一筆行程
        /// </summary>
        public void Create(CalendarRecord record)
        {
            string sql = @"INSERT INTO Calendar
                           (EventDate, EventTime, Title, Description)
                           VALUES
                           (@EventDate, @EventTime, @Title, @Description)
                          ";
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EventDate", record.EventDate);
                    cmd.Parameters.AddWithValue("@EventTime", record.EventTime);
                    cmd.Parameters.AddWithValue("@Title", record.Title);
                    cmd.Parameters.AddWithValue("@Description", record.Description);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 編輯一筆行程
        /// </summary>
        public void Update(CalendarRecord record)
        {
            string sql = @"UPDATE Calendar
                           SET
                           EventDate = @EventDate, EventTime = @EventTime, Title = @Title, Description = @Description
                           WHERE Id = @Id
                          ";
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", record.Id);
                    cmd.Parameters.AddWithValue("@EventDate", record.EventDate);
                    cmd.Parameters.AddWithValue("@EventTime", record.EventTime);
                    cmd.Parameters.AddWithValue("@Title", record.Title);
                    cmd.Parameters.AddWithValue("@Description", record.Description);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            string sql = @"
                          DELETE FROM Calendar
                          WHERE Id = @Id
                          ";
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
