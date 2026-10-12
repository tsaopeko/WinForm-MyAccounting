using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class MainForm : Form
    {
        private Button _selectedButton;
        #region 設定拖移視窗
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            SelectButton(btnAccounting);
            ShowForm(new AccountingForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            if (_selectedButton != btnHome)
            { 
                btnHome.BackColor = Color.FromArgb(30, 30, 47);
            }
        }
        /// <summary>
        /// 將原本選取的按鈕恢復, 新的選取按鈕變成選取顏色
        /// </summary>
        /// <param name="button">按鈕</param>
        private void SelectButton(Button button)
        {
            if (_selectedButton != null)
            {
                _selectedButton.BackColor = Color.FromArgb(30, 30, 47);
            }

            _selectedButton = button;

            _selectedButton.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectButton(btnHome);
            ShowForm(new HomeForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectButton(btnHome);
            ShowForm(new HomeForm());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            SelectButton(btnCalendar);
            ShowForm(new CalendarForm());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            SelectButton(btnStatistics);
            ShowForm(new StatisticsForm());
        }
        #region 設定按鈕樣式
        private void btnAccounting_MouseEnter(object sender, EventArgs e)
        {
            btnAccounting.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnAccounting_MouseLeave(object sender, EventArgs e)
        {
            if (_selectedButton != btnAccounting)
            {
                btnAccounting.BackColor = Color.FromArgb(30, 30, 47);
            }
        }

        private void btnCalendar_MouseEnter(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnCalendar_MouseLeave(object sender, EventArgs e)
        {
            if (_selectedButton != btnCalendar)
            {
                btnCalendar.BackColor = Color.FromArgb(30, 30, 47);
            }
        }
        private void btnStatistics_MouseEnter(object sender, EventArgs e)
        {
            btnStatistics.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnStatistics_MouseLeave(object sender, EventArgs e)
        {
            if (_selectedButton != btnStatistics)
            {
                btnStatistics.BackColor = Color.FromArgb(30, 30, 47);
            }
        }
        private void btnMinmize_MouseEnter(object sender, EventArgs e)
        {
            btnMinmize.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnMinmize_MouseLeave(object sender, EventArgs e)
        {
            btnMinmize.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 80, 80);
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(30, 30, 47);
            btnClose.ForeColor = Color.White;
        }
        #endregion
        /// <summary>
        /// 將其他form放到pnl裡面
        /// </summary>
        /// <param name="form"></param>
        private void ShowForm(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(form);
            form.Show();
        }
    }
}
