using MyAccounting.Data;
using MyAccounting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class CalendarForm : Form
    {
        private CalendarRepository _repository = new CalendarRepository();
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            UpdateSelectedDate(monthCalendar1.SelectionStart);
            LoadScheduleByDate(monthCalendar1.SelectionStart);
        }
        /// <summary>
        /// 新增行程控件
        /// </summary>
        /// <param name="record">行程資料</param>
        private void AddScheduleCard(CalendarRecord record)
        {
            Panel pnlScheduleItem = new Panel
            {
                Height = 100,
                Width = flpScheduleList.ClientSize.Width,
                Margin = new Padding(0, 0, 0, 12),
                Padding = new Padding(15, 0, 15, 15),
                BackColor = Color.Transparent,
                Tag = record // 透過Tag得知當前是哪一筆資料
            };

            Label lbScheduleTime = new Label
            {
                Name = "lbScheduleTime",
                Text = record.EventTime,
                Font = new Font("Microsoft JhengHei UI", 10, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 12)
            };

            Label lbScheduleName = new Label
            {
                Name = "lbScheduleName",
                Text = record.Title,
                Font = new Font("Microsoft JhengHei UI", 12, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 37)
            };

            Label lbScheduleDescription = new Label
            {
                Name = "lbScheduleDescription",
                Text = record.Description,
                Font = new Font("Microsoft JhengHei UI", 9),
                AutoSize = true,
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 66)
            };

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem editItem = new ToolStripMenuItem("編輯");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("刪除");
            contextMenu.Items.Add(editItem);
            contextMenu.Items.Add(deleteItem);
            deleteItem.Tag = pnlScheduleItem;   // 透過Tag可以抓取到是哪一個pnl
            editItem.Tag = pnlScheduleItem; // 透過Tag可以抓取到是哪一個pnl
            deleteItem.Click += DeleteSchedule_Click;
            editItem.Click += UpdateSchedule_Click;

            Button btnScheduleMenu = new Button
            {
                Text = "⋮",
                Font = new Font("Microsoft JhengHei UI", 14),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(40, 40),
                Cursor = Cursors.Hand,
                TabStop = false,
                Location = new Point(pnlScheduleItem.Width - 45, 10),
                Tag = contextMenu // 透過Tag得知當前是哪一個按鈕
            };
            btnScheduleMenu.FlatAppearance.BorderSize = 0;
            btnScheduleMenu.Click += ScheduleMenu_Click;

            pnlScheduleItem.Controls.Add(lbScheduleTime);
            pnlScheduleItem.Controls.Add(lbScheduleName);
            pnlScheduleItem.Controls.Add(lbScheduleDescription);
            pnlScheduleItem.Controls.Add(btnScheduleMenu);

            flpScheduleList.Controls.Add(pnlScheduleItem);

            // 建立控件的時候更新顯示畫面
            UpdateScheduleEmptyState();
        }
        /// <summary>
        /// 更新顯示的畫面
        /// </summary>
        private void UpdateScheduleEmptyState()
        {
            if (flpScheduleList.Controls.Count == 0)
            { 
                flpScheduleList.Visible = false;
                pnlEmptySchedule.Visible = true;
            }
            else
            {
                flpScheduleList.Visible = true;
                pnlEmptySchedule.Visible = false;
            }
        }
        /// <summary>
        /// 點選新增行程+按鈕
        /// </summary>
        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            using (CalendarAddForm addForm = new CalendarAddForm(null))
            { 
                if (addForm.ShowDialog() == DialogResult.OK)
                { 
                    CalendarRecord record = addForm.Record;

                    record.EventDate = monthCalendar1.SelectionStart;

                    _repository.Create(record);

                    LoadScheduleByDate(record.EventDate);
                }
            }
        }
        /// <summary>
        /// 點選刪除行程的按鈕
        /// </summary>
        private void DeleteSchedule_Click(Object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            Panel panel = menuItem.Tag as Panel;

            CalendarRecord record = panel.Tag as CalendarRecord;

            DialogResult result = MessageBox.Show($"確定要刪除「{record.Title}」嗎?", "刪除行程", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            _repository.Delete(record.Id);

            LoadScheduleByDate(record.EventDate);
        }
        /// <summary>
        /// 點選⋮按鈕
        /// </summary>
        private void ScheduleMenu_Click(object sender, EventArgs e)
        { 
            Button button = sender as Button;

            ContextMenuStrip contextMenu = button.Tag as ContextMenuStrip;

            contextMenu.Show(button, new Point(0, button.Height));
        }
        /// <summary>
        /// 點選編輯行程的按鈕
        /// </summary>
        private void UpdateSchedule_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            Panel panel = menuItem.Tag as Panel;

            CalendarRecord record = panel.Tag as CalendarRecord;

            using (CalendarAddForm editForm = new CalendarAddForm(record))
            {
                if(editForm.ShowDialog() == DialogResult.OK)
                {
                    _repository.Update(record);

                    LoadScheduleByDate(record.EventDate);
                }
            }
        }
        /// <summary>
        /// 選擇月曆上的日期同步跟新畫面資訊
        /// </summary>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateSelectedDate(e.Start);
            LoadScheduleByDate(e.Start);
        }
        /// <summary>
        /// 重新整理行程
        /// </summary>
        /// <param name="date">月曆日期</param>
        private void LoadScheduleByDate(DateTime date)
        {
            flpScheduleList.Controls.Clear();

            DataTable dt = _repository.GetByDate(date);
            
            foreach (DataRow dr in dt.Rows)
            {
                CalendarRecord record = new CalendarRecord
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    EventDate = Convert.ToDateTime(dr["EventDate"]),
                    EventTime = dr["EventTime"].ToString(),
                    Title = dr["Title"].ToString(),
                    Description = dr["Description"].ToString()
                };

                AddScheduleCard(record);
            }

            UpdateScheduleEmptyState();
        }
        /// <summary>
        /// 更新標題上的日期
        /// </summary>
        /// <param name="date">月曆日期</param>
        private void UpdateSelectedDate(DateTime date)
        {
            lbSelectedDate.Text = date.ToString("M月d日");
            lbSelectedDay.Text = date.ToString("dddd");
        }

        private void btnAddSchedule_MouseEnter(object sender, EventArgs e)
        {
            btnAddSchedule.BackColor = Color.FromArgb(45, 45, 65);
            btnAddSchedule.ForeColor = Color.White;
        }

        private void btnAddSchedule_MouseLeave(object sender, EventArgs e)
        {
            btnAddSchedule.BackColor = Color.White;
            btnAddSchedule.ForeColor = Color.FromArgb(51, 51, 51);
        }
    }
}
