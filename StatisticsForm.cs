using MyAccounting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class StatisticsForm : Form
    {
        AccountRepository _repository = new AccountRepository();
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            RefreshStatistics();
        }

        private void LoadMonthlyChart(DataTable dt)
        {
            chartMonthly.Series["IncomeSeries"].Points.Clear();
            chartMonthly.Series["ExpenseSeries"].Points.Clear();

            int year = DateTime.Now.Year;

            for (int month = 1; month <= 12; month++)
            {
                DateTime startDate = new DateTime(year, month, 1);
                DateTime endDate = startDate.AddMonths(1);

                DataRow[] incomeRows = dt.Select($"RecordDate >= #{startDate:yyyy-MM-dd}# AND RecordDate < #{endDate:yyyy-MM-dd}# AND Type = '收入'");

                DataRow[] expenseRows = dt.Select($"RecordDate >= #{startDate:yyyy-MM-dd}# AND RecordDate < #{endDate:yyyy-MM-dd}# AND Type = '支出'");

                int incomeTotal = 0;
                int expenseTotal = 0;

                foreach (DataRow row in incomeRows)
                {
                    incomeTotal += Convert.ToInt32(row["Amount"]);
                }

                foreach (DataRow row in expenseRows)
                {
                    expenseTotal += Convert.ToInt32(row["Amount"]);
                }

                chartMonthly.Series["IncomeSeries"].Points.AddXY($"{month}月", incomeTotal);
                chartMonthly.Series["ExpenseSeries"].Points.AddXY($"{month}月", expenseTotal);
            }
        }

        private void LoadCategoryChart(DataTable dt)
        {
            chartCategory.Series["CategorySeries"].Points.Clear();

            DataRow[] expenseRows = dt.Select("Type = '支出'");

            if (expenseRows.Length == 0)
            {
                return;
            }

            Dictionary<string, int> categoryTotals = new Dictionary<string, int>();

            foreach(DataRow row in expenseRows)
            {
                string category = row["Category"].ToString();
                int amount = Convert.ToInt32(row["Amount"]);

                if(categoryTotals.ContainsKey(category))
                {
                    categoryTotals[category] += amount;
                }
                else
                {
                    categoryTotals.Add(category, amount);
                }    
            }

            foreach(KeyValuePair<string, int> item in categoryTotals)
            {
                chartCategory.Series["CategorySeries"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void RefreshStatistics()
        {
            DataTable dt = _repository.GetAll();

            LoadMonthlyChart(dt);
            LoadCategoryChart(dt);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStatistics();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(45, 45, 65);
            btnRefresh.ForeColor = Color.White;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.White;
            btnRefresh.ForeColor = Color.FromArgb(51, 51, 51);
        }
    }
}
