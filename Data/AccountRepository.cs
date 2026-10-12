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
    public class AccountRepository
    {
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns>DataTable資料類型返回所有資料</returns>
        public DataTable GetAll()
        {
            string sql = @"SELECT Id, RecordDate, Type, Category, Amount, Remark
                           FROM Account";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                { 
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="record"></param>
        /// <returns>新增那一筆資料的Id</returns>
        public int Create(AccountRecord record)
        {
            string sql = @"INSERT INTO Account
                           (RecordDate, Type, Category, Amount, Remark)
                           VALUES
                           (@RecordDate, @Type, @Category, @Amount, @Remark)
                           SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RecordDate", record.RecordDate);
                    cmd.Parameters.AddWithValue("@Type", record.Type);
                    cmd.Parameters.AddWithValue("@Category", record.Category);
                    cmd.Parameters.AddWithValue("@Amount", record.Amount);
                    cmd.Parameters.AddWithValue("@Remark", record.Remark);

                    conn.Open();
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    return newId;
                }
            }
        }
        /// <summary>
        /// 透過Id搜尋那一筆資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns>符合id的那一筆資料</returns>
        public DataTable GetById(int id)
        {
            string sql = @"SELECT Id, RecordDate, Type, Category, Amount, Remark
                           FROM Account
                           WHERE Id = @Id";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Id", id);

                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="record"></param>
        public void Update(AccountRecord record)
        {
            string sql = @"UPDATE Account
                           SET RecordDate = @RecordDate,
                               Type = @Type,
                               Category = @Category,
                               Amount = @Amount,
                               Remark = @Remark
                           WHERE Id = @Id";
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", record.Id);
                    cmd.Parameters.AddWithValue("@RecordDate", record.RecordDate);
                    cmd.Parameters.AddWithValue("@Type", record.Type);
                    cmd.Parameters.AddWithValue("@Category", record.Category);
                    cmd.Parameters.AddWithValue("@Amount", record.Amount);
                    cmd.Parameters.AddWithValue("@Remark", record.Remark);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">選取的那筆資料id</param>
        public void Delete(int id)
        {
            string sql = @"DELETE FROM Account
                           WHERE Id = @Id";
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
        /// <summary>
        /// 查詢條件資料
        /// </summary>
        /// <param name="startDate">開始時間</param>
        /// <param name="endDate">結束時間</param>
        /// <param name="type">類型</param>
        /// <param name="category">分類</param>
        /// <returns>條件查詢完的資料</returns>
        public DataTable GetDataByDateRange(DateTime startDate, DateTime endDate, string type, string category)
        {
            string sql = @"SELECT Id, RecordDate, Type, Category, Amount, Remark
                           FROM Account
                           WHERE RecordDate >= @StartDate
                           AND RecordDate <= @EndDate
                           AND Category = @Category
                          ";

            if(type != "全部")
            {
                sql += " AND Type = @Type ";
            }

            sql += "ORDER BY RecordDate";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new DbConnection().GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@Category", category);

                    if (type != "全部")
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Type", type);
                    }

                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
