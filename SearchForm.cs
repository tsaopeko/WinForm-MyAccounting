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
    public partial class SearchForm : Form
    {
        public DataTable SearchResult { get; private set; }
        private AccountRepository _repository = new AccountRepository();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show("開始時間不能晚於結束時間!");
                return;
            }
            try
            {
                SearchResult = _repository.GetDataByDateRange(dtpStartDate.Value.Date, dtpEndDate.Value.Date, cbType.Text, cbCategory.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查詢資料時發生錯誤:\n{ex.Message}");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cbType.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 80, 80);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(30, 30, 47);
        }
    }
}
