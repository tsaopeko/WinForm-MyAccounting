using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MyAccounting.Data;

namespace MyAccounting
{
    public partial class HomeForm : Form
    {
        private AccountRepository _repository = new AccountRepository();
        private CalendarRepository _cRepository = new CalendarRepository();
        public HomeForm()
        {
            InitializeComponent();
        }
        private void SetRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            SetRoundedPanel(pnlTodayTodo, 15);
            SetRoundedPanel(pnlTodayExpense, 15);
            SetRoundedPanel(pnlWeekExpense, 15);

            SetRoundedPanel(pnlMonthIncome, 15);
            SetRoundedPanel(pnlMonthExpense, 15);
            SetRoundedPanel(pnlMonthBalance, 15);

            LoadTodayExpense();
            LoadWeekExpense();
            LoadMonthExpense();
            LoadMonthIncome();
            LoadMonthBalance();
            LoadTodayTodo();
        }
        /// <summary>
        /// 獲取總金額
        /// </summary>
        /// <param name="startDate">開始日期</param>
        /// <param name="endDate">結束日期</param>
        /// <param name="type">類型</param>
        /// <returns>總金額</returns>
        private int GetTotalAmount(DateTime startDate, DateTime endDate, string type)
        {
            DataTable dt = _repository.GetAll();

            DataRow[] rows = dt.Select($"RecordDate >= #{startDate:yyyy-MM-dd}# AND " + $"RecordDate < #{endDate:yyyy-MM-dd}# AND " + $"Type = '{type}'");
            int total = 0;
            foreach (DataRow row in rows)
            {
                total += Convert.ToInt32(row["Amount"]);
            }

            return total;
        }
        /// <summary>
        /// 顯示今日花費
        /// </summary>
        private void LoadTodayExpense()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            lbTodayExpenseValue.Text = $"${GetTotalAmount(today, tomorrow, "支出").ToString()}";
        }
        /// <summary>
        /// 顯示當週花費
        /// </summary>
        private void LoadWeekExpense()
        {
            DateTime today = DateTime.Today;
            int daysFromMonday = (Convert.ToInt32(today.DayOfWeek) + 6) % 7;
            DateTime weekStart = today.AddDays(-daysFromMonday);
            DateTime nextWeekStart = weekStart.AddDays(7);

            lbWeekExpenseValue.Text = $"${GetTotalAmount(weekStart, nextWeekStart, "支出").ToString()}";
        }
        /// <summary>
        /// 顯示當月花費
        /// </summary>
        private void LoadMonthExpense()
        {
            DateTime monthStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime nextMonthStart = monthStart.AddMonths(1);

            lbMonthExpenseValue.Text = $"${GetTotalAmount(monthStart, nextMonthStart, "支出").ToString()}";
        }
        /// <summary>
        /// 顯示當月收入
        /// </summary>
        private void LoadMonthIncome()
        {
            DateTime monthStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime nextMonthStart = monthStart.AddMonths(1);

            lbMonthIncomeValue.Text = $"${GetTotalAmount(monthStart, nextMonthStart, "收入").ToString()}";
        }
        /// <summary>
        /// 顯示當月餘額
        /// </summary>
        private void LoadMonthBalance()
        {
            DateTime monthStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime nextMonthStart = monthStart.AddMonths(1);

            lbMonthBalanceValue.Text = $"${(GetTotalAmount(monthStart, nextMonthStart, "收入")- GetTotalAmount(monthStart, nextMonthStart, "支出")).ToString()}";
        }

        private void LoadTodayTodo()
        {
            DataTable dt = _cRepository.GetByDate(DateTime.Today);

            if(dt.Rows.Count == 0)
            {
                lbTodoValue.Text = "今日沒有行程";
            }
            else
            {
                lbTodoValue.Text = string.Join(Environment.NewLine, dt.AsEnumerable().Select(row => row["Title"].ToString()));
            }
        }
    }
}
