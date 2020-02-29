/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/12/1
 * 时间: 16:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Course_Manage
{
	partial class student_manager
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslRole = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssl_quitlogin = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel_info = new System.Windows.Forms.Panel();
			this.txt_sroom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_quitChoose = new System.Windows.Forms.Button();
			this.txt_smark = new System.Windows.Forms.TextBox();
			this.lb_mark = new System.Windows.Forms.Label();
			this.txt_stime = new System.Windows.Forms.TextBox();
			this.lb_time = new System.Windows.Forms.Label();
			this.txt_sscore = new System.Windows.Forms.TextBox();
			this.lb_academic = new System.Windows.Forms.Label();
			this.txt_sclass = new System.Windows.Forms.TextBox();
			this.lb_age = new System.Windows.Forms.Label();
			this.txt_sname = new System.Windows.Forms.TextBox();
			this.lb_name = new System.Windows.Forms.Label();
			this.txt_scourse = new System.Windows.Forms.TextBox();
			this.lb_degree = new System.Windows.Forms.Label();
			this.txt_sdepart = new System.Windows.Forms.TextBox();
			this.lb_gender = new System.Windows.Forms.Label();
			this.txt_sid = new System.Windows.Forms.TextBox();
			this.lb_id = new System.Windows.Forms.Label();
			this.panel_course = new System.Windows.Forms.Panel();
			this.btn_new = new System.Windows.Forms.Button();
			this.btn_chooseCourse = new System.Windows.Forms.Button();
			this.datagv_course = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel_info.SuspendLayout();
			this.panel_course.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_course)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.个人信息ToolStripMenuItem,
									this.课程管理ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(843, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 个人信息ToolStripMenuItem
			// 
			this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
			this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.个人信息ToolStripMenuItem.Text = "基本信息";
			this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItemClick);
			// 
			// 课程管理ToolStripMenuItem
			// 
			this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
			this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.课程管理ToolStripMenuItem.Text = "课程管理";
			this.课程管理ToolStripMenuItem.Click += new System.EventHandler(this.课程管理ToolStripMenuItemClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsslUser,
									this.tsslRole,
									this.tsslTime,
									this.tsslDate,
									this.tssl_quitlogin});
			this.statusStrip1.Location = new System.Drawing.Point(0, 451);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(843, 25);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslUser
			// 
			this.tsslUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tsslUser.Name = "tsslUser";
			this.tsslUser.Size = new System.Drawing.Size(121, 20);
			this.tsslUser.Text = "当前登录用户：";
			// 
			// tsslRole
			// 
			this.tsslRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tsslRole.Name = "tsslRole";
			this.tsslRole.Size = new System.Drawing.Size(0, 20);
			// 
			// tsslTime
			// 
			this.tsslTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tsslTime.Name = "tsslTime";
			this.tsslTime.Size = new System.Drawing.Size(121, 20);
			this.tsslTime.Text = "当前系统时间：";
			// 
			// tsslDate
			// 
			this.tsslDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tsslDate.Name = "tsslDate";
			this.tsslDate.Size = new System.Drawing.Size(0, 20);
			// 
			// tssl_quitlogin
			// 
			this.tssl_quitlogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tssl_quitlogin.Name = "tssl_quitlogin";
			this.tssl_quitlogin.Size = new System.Drawing.Size(73, 20);
			this.tssl_quitlogin.Text = "退出登录";
			this.tssl_quitlogin.Click += new System.EventHandler(this.Tssl_quitloginClick);
			// 
			// panel_info
			// 
			this.panel_info.Controls.Add(this.txt_sroom);
			this.panel_info.Controls.Add(this.label1);
			this.panel_info.Controls.Add(this.btn_quitChoose);
			this.panel_info.Controls.Add(this.txt_smark);
			this.panel_info.Controls.Add(this.lb_mark);
			this.panel_info.Controls.Add(this.txt_stime);
			this.panel_info.Controls.Add(this.lb_time);
			this.panel_info.Controls.Add(this.txt_sscore);
			this.panel_info.Controls.Add(this.lb_academic);
			this.panel_info.Controls.Add(this.txt_sclass);
			this.panel_info.Controls.Add(this.lb_age);
			this.panel_info.Controls.Add(this.txt_sname);
			this.panel_info.Controls.Add(this.lb_name);
			this.panel_info.Controls.Add(this.txt_scourse);
			this.panel_info.Controls.Add(this.lb_degree);
			this.panel_info.Controls.Add(this.txt_sdepart);
			this.panel_info.Controls.Add(this.lb_gender);
			this.panel_info.Controls.Add(this.txt_sid);
			this.panel_info.Controls.Add(this.lb_id);
			this.panel_info.Location = new System.Drawing.Point(0, 31);
			this.panel_info.Name = "panel_info";
			this.panel_info.Size = new System.Drawing.Size(832, 411);
			this.panel_info.TabIndex = 4;
			// 
			// txt_sroom
			// 
			this.txt_sroom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sroom.Location = new System.Drawing.Point(460, 237);
			this.txt_sroom.Name = "txt_sroom";
			this.txt_sroom.ReadOnly = true;
			this.txt_sroom.Size = new System.Drawing.Size(157, 26);
			this.txt_sroom.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(376, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "课程教室：";
			// 
			// btn_quitChoose
			// 
			this.btn_quitChoose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_quitChoose.Location = new System.Drawing.Point(529, 348);
			this.btn_quitChoose.Name = "btn_quitChoose";
			this.btn_quitChoose.Size = new System.Drawing.Size(88, 36);
			this.btn_quitChoose.TabIndex = 18;
			this.btn_quitChoose.Text = "退  选";
			this.btn_quitChoose.UseVisualStyleBackColor = true;
			this.btn_quitChoose.Click += new System.EventHandler(this.Btn_quitChooseClick);
			// 
			// txt_smark
			// 
			this.txt_smark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_smark.Location = new System.Drawing.Point(155, 307);
			this.txt_smark.Name = "txt_smark";
			this.txt_smark.ReadOnly = true;
			this.txt_smark.Size = new System.Drawing.Size(157, 26);
			this.txt_smark.TabIndex = 17;
			// 
			// lb_mark
			// 
			this.lb_mark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_mark.Location = new System.Drawing.Point(71, 310);
			this.lb_mark.Name = "lb_mark";
			this.lb_mark.Size = new System.Drawing.Size(100, 23);
			this.lb_mark.TabIndex = 16;
			this.lb_mark.Text = "成    绩：";
			// 
			// txt_stime
			// 
			this.txt_stime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_stime.Location = new System.Drawing.Point(155, 240);
			this.txt_stime.Name = "txt_stime";
			this.txt_stime.ReadOnly = true;
			this.txt_stime.Size = new System.Drawing.Size(157, 26);
			this.txt_stime.TabIndex = 15;
			// 
			// lb_time
			// 
			this.lb_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_time.Location = new System.Drawing.Point(71, 243);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(100, 23);
			this.lb_time.TabIndex = 14;
			this.lb_time.Text = "课程时间：";
			// 
			// txt_sscore
			// 
			this.txt_sscore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sscore.Location = new System.Drawing.Point(460, 170);
			this.txt_sscore.Name = "txt_sscore";
			this.txt_sscore.ReadOnly = true;
			this.txt_sscore.Size = new System.Drawing.Size(157, 26);
			this.txt_sscore.TabIndex = 13;
			// 
			// lb_academic
			// 
			this.lb_academic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_academic.Location = new System.Drawing.Point(376, 177);
			this.lb_academic.Name = "lb_academic";
			this.lb_academic.Size = new System.Drawing.Size(100, 23);
			this.lb_academic.TabIndex = 13;
			this.lb_academic.Text = "学    分：";
			// 
			// txt_sclass
			// 
			this.txt_sclass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sclass.Location = new System.Drawing.Point(460, 101);
			this.txt_sclass.Name = "txt_sclass";
			this.txt_sclass.ReadOnly = true;
			this.txt_sclass.Size = new System.Drawing.Size(157, 26);
			this.txt_sclass.TabIndex = 10;
			// 
			// lb_age
			// 
			this.lb_age.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_age.Location = new System.Drawing.Point(376, 108);
			this.lb_age.Name = "lb_age";
			this.lb_age.Size = new System.Drawing.Size(100, 23);
			this.lb_age.TabIndex = 9;
			this.lb_age.Text = "班    级：";
			// 
			// txt_sname
			// 
			this.txt_sname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sname.Location = new System.Drawing.Point(460, 35);
			this.txt_sname.Name = "txt_sname";
			this.txt_sname.ReadOnly = true;
			this.txt_sname.Size = new System.Drawing.Size(157, 26);
			this.txt_sname.TabIndex = 6;
			// 
			// lb_name
			// 
			this.lb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_name.Location = new System.Drawing.Point(376, 42);
			this.lb_name.Name = "lb_name";
			this.lb_name.Size = new System.Drawing.Size(100, 23);
			this.lb_name.TabIndex = 5;
			this.lb_name.Text = "姓    名：";
			// 
			// txt_scourse
			// 
			this.txt_scourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_scourse.Location = new System.Drawing.Point(155, 170);
			this.txt_scourse.Name = "txt_scourse";
			this.txt_scourse.ReadOnly = true;
			this.txt_scourse.Size = new System.Drawing.Size(157, 26);
			this.txt_scourse.TabIndex = 12;
			// 
			// lb_degree
			// 
			this.lb_degree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_degree.Location = new System.Drawing.Point(71, 173);
			this.lb_degree.Name = "lb_degree";
			this.lb_degree.Size = new System.Drawing.Size(100, 23);
			this.lb_degree.TabIndex = 11;
			this.lb_degree.Text = "已选课程：";
			// 
			// txt_sdepart
			// 
			this.txt_sdepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sdepart.Location = new System.Drawing.Point(155, 101);
			this.txt_sdepart.Name = "txt_sdepart";
			this.txt_sdepart.ReadOnly = true;
			this.txt_sdepart.Size = new System.Drawing.Size(157, 26);
			this.txt_sdepart.TabIndex = 8;
			// 
			// lb_gender
			// 
			this.lb_gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_gender.Location = new System.Drawing.Point(71, 108);
			this.lb_gender.Name = "lb_gender";
			this.lb_gender.Size = new System.Drawing.Size(100, 23);
			this.lb_gender.TabIndex = 7;
			this.lb_gender.Text = "所属院系：";
			// 
			// txt_sid
			// 
			this.txt_sid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sid.Location = new System.Drawing.Point(155, 35);
			this.txt_sid.Name = "txt_sid";
			this.txt_sid.ReadOnly = true;
			this.txt_sid.Size = new System.Drawing.Size(157, 26);
			this.txt_sid.TabIndex = 4;
			// 
			// lb_id
			// 
			this.lb_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_id.Location = new System.Drawing.Point(71, 42);
			this.lb_id.Name = "lb_id";
			this.lb_id.Size = new System.Drawing.Size(100, 23);
			this.lb_id.TabIndex = 3;
			this.lb_id.Text = "学    号：";
			// 
			// panel_course
			// 
			this.panel_course.Controls.Add(this.btn_new);
			this.panel_course.Controls.Add(this.btn_chooseCourse);
			this.panel_course.Controls.Add(this.datagv_course);
			this.panel_course.Location = new System.Drawing.Point(0, 31);
			this.panel_course.Name = "panel_course";
			this.panel_course.Size = new System.Drawing.Size(832, 411);
			this.panel_course.TabIndex = 21;
			// 
			// btn_new
			// 
			this.btn_new.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_new.Location = new System.Drawing.Point(573, 348);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(88, 36);
			this.btn_new.TabIndex = 32;
			this.btn_new.Text = "刷  新";
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.Btn_newClick);
			// 
			// btn_chooseCourse
			// 
			this.btn_chooseCourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_chooseCourse.Location = new System.Drawing.Point(730, 348);
			this.btn_chooseCourse.Name = "btn_chooseCourse";
			this.btn_chooseCourse.Size = new System.Drawing.Size(88, 36);
			this.btn_chooseCourse.TabIndex = 31;
			this.btn_chooseCourse.Text = "选  择";
			this.btn_chooseCourse.UseVisualStyleBackColor = true;
			this.btn_chooseCourse.Click += new System.EventHandler(this.Btn_chooseCourseClick);
			// 
			// datagv_course
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagv_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.datagv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagv_course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column6,
									this.Column3,
									this.Column2,
									this.Column5,
									this.Column4,
									this.Column7});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagv_course.DefaultCellStyle = dataGridViewCellStyle2;
			this.datagv_course.Location = new System.Drawing.Point(12, 13);
			this.datagv_course.Name = "datagv_course";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagv_course.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.datagv_course.RowTemplate.Height = 23;
			this.datagv_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagv_course.Size = new System.Drawing.Size(806, 280);
			this.datagv_course.TabIndex = 30;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "course_name";
			this.Column1.Frozen = true;
			this.Column1.HeaderText = "课程名称";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 120;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "course_choose";
			this.Column6.Frozen = true;
			this.Column6.HeaderText = "已选人数";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "course_class";
			this.Column3.Frozen = true;
			this.Column3.HeaderText = "课程教室";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "course_time";
			this.Column2.Frozen = true;
			this.Column2.HeaderText = "课程时间";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "course_score";
			this.Column5.Frozen = true;
			this.Column5.HeaderText = "课程学分";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "t_name";
			this.Column4.Frozen = true;
			this.Column4.HeaderText = "授课老师";
			this.Column4.Name = "Column4";
			this.Column4.Width = 120;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "class_people";
			this.Column7.Frozen = true;
			this.Column7.HeaderText = "可选人数";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// student_manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 476);
			this.Controls.Add(this.panel_course);
			this.Controls.Add(this.panel_info);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "student_manager";
			this.Text = "学生管理系统";
			this.Load += new System.EventHandler(this.Student_managerLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel_info.ResumeLayout(false);
			this.panel_info.PerformLayout();
			this.panel_course.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.datagv_course)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel tssl_quitlogin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_sroom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView datagv_course;
		private System.Windows.Forms.Button btn_chooseCourse;
		private System.Windows.Forms.Button btn_new;
		private System.Windows.Forms.Panel panel_course;
		private System.Windows.Forms.Label lb_mark;
		private System.Windows.Forms.TextBox txt_smark;
		private System.Windows.Forms.Button btn_quitChoose;
		private System.Windows.Forms.Label lb_id;
		private System.Windows.Forms.TextBox txt_sid;
		private System.Windows.Forms.Label lb_gender;
		private System.Windows.Forms.TextBox txt_sdepart;
		private System.Windows.Forms.Label lb_degree;
		private System.Windows.Forms.TextBox txt_scourse;
		private System.Windows.Forms.Label lb_name;
		private System.Windows.Forms.TextBox txt_sname;
		private System.Windows.Forms.Label lb_age;
		private System.Windows.Forms.TextBox txt_sclass;
		private System.Windows.Forms.Label lb_academic;
		private System.Windows.Forms.TextBox txt_sscore;
		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.TextBox txt_stime;
		private System.Windows.Forms.Panel panel_info;
		public System.Windows.Forms.ToolStripStatusLabel tsslDate;
		private System.Windows.Forms.ToolStripStatusLabel tsslTime;
		public System.Windows.Forms.ToolStripStatusLabel tsslRole;
		private System.Windows.Forms.ToolStripStatusLabel tsslUser;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;

	}
}
