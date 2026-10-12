using MyAccounting.Models;
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
    public partial class CalendarAddForm : Form
    {
        public CalendarRecord Record { get; private set; }
        public CalendarAddForm(CalendarRecord record)
        {
            InitializeComponent();

            Record = record;
            if(Record != null)
            {
                dtpTime.Value = DateTime.Parse(record.EventTime);
                txtScheduleName.Text = record.Title;
                txtDescription.Text = record.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtScheduleName.Text))
            {
                MessageBox.Show("請輸入行程名稱");
                return;
            }
            if (Record == null)
            {
                Record = new CalendarRecord
                { 
                    EventTime = dtpTime.Value.ToShortTimeString(),
                    Title = txtScheduleName.Text,
                    Description = txtDescription.Text
                };
            }
            else
            {
                Record.EventTime = dtpTime.Value.ToShortTimeString();
                Record.Title = txtScheduleName.Text;
                Record.Description = txtDescription.Text;
            }
            
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScheduleName.Text = string.Empty;
            txtDescription.Text= string.Empty;
            dtpTime.Value = DateTime.Now;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 80, 80);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(30, 30, 47);
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(45, 45, 65);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(30, 30, 47);
        }
    }
}
