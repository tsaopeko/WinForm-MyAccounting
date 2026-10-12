using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyAccounting.Data;
using MyAccounting.Models;

namespace MyAccounting
{
    public partial class AccountingForm : Form
    {
        private AccountRepository _repository = new AccountRepository();
        // 保存目前選取資料的Id
        private int _selectedId;
        public AccountingForm()
        {
            InitializeComponent();
            dgvAccounting.AutoGenerateColumns = false;
        }

        private void AccountingForm_Load(object sender, EventArgs e)
        {
            // 畫面載入時, 將資料一併輸出到dgv上
            LoadAccountData();
        }
        /// <summary>
        /// 取的所有資料顯示在DataGridView上
        /// </summary>
        private void LoadAccountData()
        { 
            DataTable dt = _repository.GetAll();

            dgvAccounting.DataSource = dt;
        }
        private void ClearInput()
        { 
            dtpDate.Value = DateTime.Now;
            cbType.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            txtAmount.Text = string.Empty;
            txtRemark.Text = string.Empty;
            _selectedId = 0;   
        }
        /// <summary>
        /// 點選新增按鈕
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // 驗證金額是不是正確格式
            if (int.TryParse(txtAmount.Text, out int amount) == false)
            {
                MessageBox.Show("請輸入正確的金額!");
                return;
            }

            try
            {
                AccountRecord record = new AccountRecord();

                record.RecordDate = dtpDate.Value;
                record.Type = cbType.Text;
                record.Category = cbCategory.Text;
                record.Amount = amount;
                record.Remark = txtRemark.Text;

                // 取得新增的那筆資料的Id
                int newId = _repository.Create(record);

                // 透過id找到那筆資料, 更新顯示到dgv上
                dgvAccounting.DataSource = _repository.GetById(newId);
                // 清空輸入框, 回復預設值
                ClearInput();
                MessageBox.Show("新增成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"新增資料時發生錯誤:\n{ex.Message}");
            }
        }
        /// <summary>
        /// 點擊dgv畫面上的資料兩下把資料帶入到上方輸入框
        /// </summary>
        private void dgvAccounting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                _selectedId = Convert.ToInt32(dgvAccounting.Rows[e.RowIndex].Cells["colId"].Value);

                DataTable dt = _repository.GetById(_selectedId);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("找不到這筆資料!");
                    return;
                }
                DataRow dr = dt.Rows[0];
                dtpDate.Value = Convert.ToDateTime(dr["RecordDate"]);
                cbType.Text = dr["Type"].ToString();
                cbCategory.Text = dr["Category"].ToString();
                txtAmount.Text = dr["Amount"].ToString();
                txtRemark.Text = dr["Remark"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"取得資料時發生錯誤:\n{ex.Message}");
            }
        }
        /// <summary>
        /// 點選更新按鈕
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 先判斷有沒有選中資料
            if (_selectedId == 0)
            {
                MessageBox.Show("請先選擇要修改的資料");
                return;
            }
            // 驗證金額是不是正確格式
            if(int.TryParse(txtAmount.Text, out int amount) == false)
            {
                MessageBox.Show("請輸入正確的金額");
                return;
            }

            try
            {
                AccountRecord record = new AccountRecord();

                record.Id = _selectedId;
                record.RecordDate = dtpDate.Value;
                record.Type = cbType.Text;
                record.Category = cbCategory.Text;
                record.Amount = amount;
                record.Remark = txtRemark.Text;

                _repository.Update(record);
                dgvAccounting.DataSource = _repository.GetById(_selectedId);
                MessageBox.Show("資料更新成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"資料更新時發生錯誤:\n{ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 先判斷有沒有選中資料
            if (_selectedId == 0)
            {
                MessageBox.Show("請先選擇要刪除的資料!");
                return;
            }
            // 跳出確認視窗
            DialogResult result = MessageBox.Show("確定要刪除這筆資料?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                _repository.Delete(_selectedId);
                LoadAccountData();
                // 刪除成功之後, 要把id恢復
                _selectedId = 0;
                // 將輸出欄位清除還原
                ClearInput();
                MessageBox.Show("刪除資料成功!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"刪除資料時發生錯誤:\n{ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SearchForm searchForm = new SearchForm())
            { 
                DialogResult result = searchForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    dgvAccounting.DataSource = searchForm.SearchResult;
                }
                else if (result == DialogResult.Cancel)
                {
                    LoadAccountData();
                }
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            LoadAccountData();
        }

        #region 設定按鈕UI
        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.FromArgb(45, 45, 65);
            btnCreate.ForeColor = Color.White;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.White;
            btnCreate.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(45, 45, 65);
            btnUpdate.ForeColor = Color.White;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(45, 45, 65);
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(45, 45, 65);
            btnSearch.ForeColor = Color.White;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.White;
            btnSearch.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnGetAll_MouseEnter(object sender, EventArgs e)
        {
            btnGetAll.BackColor = Color.FromArgb(45, 45, 65);
            btnGetAll.ForeColor = Color.White;
        }

        private void btnGetAll_MouseLeave(object sender, EventArgs e)
        {
            btnGetAll.BackColor = Color.White;
            btnGetAll.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(45, 45, 65);
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.FromArgb(51, 51, 51);
        }
        #endregion
    }
}
