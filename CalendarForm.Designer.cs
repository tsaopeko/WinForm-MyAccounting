namespace MyAccounting
{
    partial class CalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlCalendarCard = new System.Windows.Forms.Panel();
            this.lbCalendarSubtitle = new System.Windows.Forms.Label();
            this.lbCalendarTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlScheduleList = new System.Windows.Forms.Panel();
            this.flpScheduleList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEmptySchedule = new System.Windows.Forms.Panel();
            this.lbEmptyDescription = new System.Windows.Forms.Label();
            this.lbEmptyTitle = new System.Windows.Forms.Label();
            this.pnlContentHeader = new System.Windows.Forms.Panel();
            this.lbScheduleTitle = new System.Windows.Forms.Label();
            this.lbSelectedDay = new System.Windows.Forms.Label();
            this.lbSelectedDate = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCalendarCard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlScheduleList.SuspendLayout();
            this.pnlEmptySchedule.SuspendLayout();
            this.pnlContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbTitle.Size = new System.Drawing.Size(111, 50);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "行事曆";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCalendarCard
            // 
            this.pnlCalendarCard.BackColor = System.Drawing.Color.White;
            this.pnlCalendarCard.Controls.Add(this.lbCalendarSubtitle);
            this.pnlCalendarCard.Controls.Add(this.lbCalendarTitle);
            this.pnlCalendarCard.Controls.Add(this.monthCalendar1);
            this.pnlCalendarCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCalendarCard.Location = new System.Drawing.Point(0, 50);
            this.pnlCalendarCard.Name = "pnlCalendarCard";
            this.pnlCalendarCard.Size = new System.Drawing.Size(240, 561);
            this.pnlCalendarCard.TabIndex = 1;
            // 
            // lbCalendarSubtitle
            // 
            this.lbCalendarSubtitle.AutoSize = true;
            this.lbCalendarSubtitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCalendarSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbCalendarSubtitle.Location = new System.Drawing.Point(14, 58);
            this.lbCalendarSubtitle.Name = "lbCalendarSubtitle";
            this.lbCalendarSubtitle.Size = new System.Drawing.Size(127, 15);
            this.lbCalendarSubtitle.TabIndex = 2;
            this.lbCalendarSubtitle.Text = "選擇日期查看當日行程";
            // 
            // lbCalendarTitle
            // 
            this.lbCalendarTitle.AutoSize = true;
            this.lbCalendarTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCalendarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbCalendarTitle.Location = new System.Drawing.Point(12, 19);
            this.lbCalendarTitle.Name = "lbCalendarTitle";
            this.lbCalendarTitle.Size = new System.Drawing.Size(56, 28);
            this.lbCalendarTitle.TabIndex = 1;
            this.lbCalendarTitle.Text = "月曆";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 110);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.pnlScheduleList);
            this.pnlContent.Controls.Add(this.pnlContentHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(744, 561);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlScheduleList
            // 
            this.pnlScheduleList.AutoScroll = true;
            this.pnlScheduleList.Controls.Add(this.flpScheduleList);
            this.pnlScheduleList.Controls.Add(this.pnlEmptySchedule);
            this.pnlScheduleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScheduleList.Location = new System.Drawing.Point(0, 110);
            this.pnlScheduleList.Name = "pnlScheduleList";
            this.pnlScheduleList.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlScheduleList.Size = new System.Drawing.Size(744, 451);
            this.pnlScheduleList.TabIndex = 6;
            // 
            // flpScheduleList
            // 
            this.flpScheduleList.BackColor = System.Drawing.Color.White;
            this.flpScheduleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpScheduleList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpScheduleList.Location = new System.Drawing.Point(20, 10);
            this.flpScheduleList.Name = "flpScheduleList";
            this.flpScheduleList.Size = new System.Drawing.Size(704, 431);
            this.flpScheduleList.TabIndex = 5;
            this.flpScheduleList.WrapContents = false;
            // 
            // pnlEmptySchedule
            // 
            this.pnlEmptySchedule.BackColor = System.Drawing.Color.White;
            this.pnlEmptySchedule.Controls.Add(this.lbEmptyDescription);
            this.pnlEmptySchedule.Controls.Add(this.lbEmptyTitle);
            this.pnlEmptySchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmptySchedule.Location = new System.Drawing.Point(20, 10);
            this.pnlEmptySchedule.Name = "pnlEmptySchedule";
            this.pnlEmptySchedule.Size = new System.Drawing.Size(704, 431);
            this.pnlEmptySchedule.TabIndex = 5;
            this.pnlEmptySchedule.Visible = false;
            // 
            // lbEmptyDescription
            // 
            this.lbEmptyDescription.AutoSize = true;
            this.lbEmptyDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEmptyDescription.Location = new System.Drawing.Point(192, 171);
            this.lbEmptyDescription.Name = "lbEmptyDescription";
            this.lbEmptyDescription.Size = new System.Drawing.Size(202, 15);
            this.lbEmptyDescription.TabIndex = 1;
            this.lbEmptyDescription.Text = "點擊「＋ 新增行程」建立第一筆行程";
            this.lbEmptyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEmptyTitle
            // 
            this.lbEmptyTitle.AutoSize = true;
            this.lbEmptyTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEmptyTitle.Location = new System.Drawing.Point(218, 122);
            this.lbEmptyTitle.Name = "lbEmptyTitle";
            this.lbEmptyTitle.Size = new System.Drawing.Size(124, 24);
            this.lbEmptyTitle.TabIndex = 0;
            this.lbEmptyTitle.Text = "今日沒有行程";
            this.lbEmptyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContentHeader
            // 
            this.pnlContentHeader.BackColor = System.Drawing.Color.White;
            this.pnlContentHeader.Controls.Add(this.lbScheduleTitle);
            this.pnlContentHeader.Controls.Add(this.lbSelectedDay);
            this.pnlContentHeader.Controls.Add(this.lbSelectedDate);
            this.pnlContentHeader.Controls.Add(this.btnAddSchedule);
            this.pnlContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContentHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlContentHeader.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pnlContentHeader.Name = "pnlContentHeader";
            this.pnlContentHeader.Size = new System.Drawing.Size(744, 110);
            this.pnlContentHeader.TabIndex = 5;
            // 
            // lbScheduleTitle
            // 
            this.lbScheduleTitle.AutoSize = true;
            this.lbScheduleTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbScheduleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbScheduleTitle.Location = new System.Drawing.Point(21, 70);
            this.lbScheduleTitle.Name = "lbScheduleTitle";
            this.lbScheduleTitle.Size = new System.Drawing.Size(86, 24);
            this.lbScheduleTitle.TabIndex = 2;
            this.lbScheduleTitle.Text = "今日行程";
            // 
            // lbSelectedDay
            // 
            this.lbSelectedDay.AutoSize = true;
            this.lbSelectedDay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSelectedDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbSelectedDay.Location = new System.Drawing.Point(139, 23);
            this.lbSelectedDay.Name = "lbSelectedDay";
            this.lbSelectedDay.Size = new System.Drawing.Size(57, 20);
            this.lbSelectedDay.TabIndex = 1;
            this.lbSelectedDay.Text = "星期四";
            // 
            // lbSelectedDate
            // 
            this.lbSelectedDate.AutoSize = true;
            this.lbSelectedDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSelectedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbSelectedDate.Location = new System.Drawing.Point(20, 15);
            this.lbSelectedDate.Name = "lbSelectedDate";
            this.lbSelectedDate.Size = new System.Drawing.Size(95, 28);
            this.lbSelectedDate.TabIndex = 0;
            this.lbSelectedDate.Text = "10月8號";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddSchedule.Location = new System.Drawing.Point(621, 64);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(120, 40);
            this.btnAddSchedule.TabIndex = 3;
            this.btnAddSchedule.Text = "新增行程+";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            this.btnAddSchedule.MouseEnter += new System.EventHandler(this.btnAddSchedule_MouseEnter);
            this.btnAddSchedule.MouseLeave += new System.EventHandler(this.btnAddSchedule_MouseLeave);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlCalendarCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCalendarCard.ResumeLayout(false);
            this.pnlCalendarCard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlScheduleList.ResumeLayout(false);
            this.pnlEmptySchedule.ResumeLayout(false);
            this.pnlEmptySchedule.PerformLayout();
            this.pnlContentHeader.ResumeLayout(false);
            this.pnlContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlCalendarCard;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lbCalendarSubtitle;
        private System.Windows.Forms.Label lbCalendarTitle;
        private System.Windows.Forms.Label lbSelectedDate;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Label lbScheduleTitle;
        private System.Windows.Forms.Label lbSelectedDay;
        private System.Windows.Forms.Panel pnlContentHeader;
        private System.Windows.Forms.Panel pnlScheduleList;
        private System.Windows.Forms.FlowLayoutPanel flpScheduleList;
        private System.Windows.Forms.Panel pnlEmptySchedule;
        private System.Windows.Forms.Label lbEmptyDescription;
        private System.Windows.Forms.Label lbEmptyTitle;
    }
}