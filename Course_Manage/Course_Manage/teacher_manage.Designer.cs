/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/11/26
 * 时间: 22:58
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Course_Manage
{
	partial class teacher_manage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher_manage));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_info = new System.Windows.Forms.Panel();
			this.btn_updataTInfo = new System.Windows.Forms.Button();
			this.txt_tdepartment = new System.Windows.Forms.TextBox();
			this.lb_depart = new System.Windows.Forms.Label();
			this.txt_thealth = new System.Windows.Forms.TextBox();
			this.lb_health = new System.Windows.Forms.Label();
			this.txt_tacademic = new System.Windows.Forms.TextBox();
			this.lb_academic = new System.Windows.Forms.Label();
			this.txt_tage = new System.Windows.Forms.TextBox();
			this.lb_age = new System.Windows.Forms.Label();
			this.txt_tname = new System.Windows.Forms.TextBox();
			this.lb_name = new System.Windows.Forms.Label();
			this.txt_tdegree = new System.Windows.Forms.TextBox();
			this.lb_degree = new System.Windows.Forms.Label();
			this.txt_tgender = new System.Windows.Forms.TextBox();
			this.lb_gender = new System.Windows.Forms.Label();
			this.txt_tid = new System.Windows.Forms.TextBox();
			this.lb_id = new System.Windows.Forms.Label();
			this.panel_course = new System.Windows.Forms.Panel();
			this.txt_Cscore = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Ctime = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Cclass = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_Tcourse = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel_score = new System.Windows.Forms.Panel();
			this.btn_new = new System.Windows.Forms.Button();
			this.btn_updataDatagv = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_number = new System.Windows.Forms.ToolStripTextBox();
			this.tsbtn_idsearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_name = new System.Windows.Forms.ToolStripTextBox();
			this.tsbtn_namesearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_class = new System.Windows.Forms.ToolStripComboBox();
			this.tsbtn_classsearch = new System.Windows.Forms.ToolStripButton();
			this.datagv_score = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslRole = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tssl_quitlogin = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.panel_info.SuspendLayout();
			this.panel_course.SuspendLayout();
			this.panel_score.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_score)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.个人信息ToolStripMenuItem,
									this.课程管理ToolStripMenuItem,
									this.成绩管理ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(630, 28);
			this.menuStrip1.TabIndex = 1;
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
			// 成绩管理ToolStripMenuItem
			// 
			this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
			this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.成绩管理ToolStripMenuItem.Text = "成绩管理";
			this.成绩管理ToolStripMenuItem.Click += new System.EventHandler(this.成绩管理ToolStripMenuItemClick);
			// 
			// panel_info
			// 
			this.panel_info.Controls.Add(this.btn_updataTInfo);
			this.panel_info.Controls.Add(this.txt_tdepartment);
			this.panel_info.Controls.Add(this.lb_depart);
			this.panel_info.Controls.Add(this.txt_thealth);
			this.panel_info.Controls.Add(this.lb_health);
			this.panel_info.Controls.Add(this.txt_tacademic);
			this.panel_info.Controls.Add(this.lb_academic);
			this.panel_info.Controls.Add(this.txt_tage);
			this.panel_info.Controls.Add(this.lb_age);
			this.panel_info.Controls.Add(this.txt_tname);
			this.panel_info.Controls.Add(this.lb_name);
			this.panel_info.Controls.Add(this.txt_tdegree);
			this.panel_info.Controls.Add(this.lb_degree);
			this.panel_info.Controls.Add(this.txt_tgender);
			this.panel_info.Controls.Add(this.lb_gender);
			this.panel_info.Controls.Add(this.txt_tid);
			this.panel_info.Controls.Add(this.lb_id);
			this.panel_info.Location = new System.Drawing.Point(0, 31);
			this.panel_info.Name = "panel_info";
			this.panel_info.Size = new System.Drawing.Size(630, 371);
			this.panel_info.TabIndex = 2;
			// 
			// btn_updataTInfo
			// 
			this.btn_updataTInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_updataTInfo.Location = new System.Drawing.Point(458, 274);
			this.btn_updataTInfo.Name = "btn_updataTInfo";
			this.btn_updataTInfo.Size = new System.Drawing.Size(83, 34);
			this.btn_updataTInfo.TabIndex = 18;
			this.btn_updataTInfo.Text = "保  存";
			this.btn_updataTInfo.UseVisualStyleBackColor = true;
			this.btn_updataTInfo.Click += new System.EventHandler(this.Btn_updataTInfoClick);
			// 
			// txt_tdepartment
			// 
			this.txt_tdepartment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tdepartment.Location = new System.Drawing.Point(121, 198);
			this.txt_tdepartment.Name = "txt_tdepartment";
			this.txt_tdepartment.ReadOnly = true;
			this.txt_tdepartment.Size = new System.Drawing.Size(157, 26);
			this.txt_tdepartment.TabIndex = 15;
			// 
			// lb_depart
			// 
			this.lb_depart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_depart.Location = new System.Drawing.Point(37, 201);
			this.lb_depart.Name = "lb_depart";
			this.lb_depart.Size = new System.Drawing.Size(100, 23);
			this.lb_depart.TabIndex = 14;
			this.lb_depart.Text = "所属院系：";
			// 
			// txt_thealth
			// 
			this.txt_thealth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_thealth.Location = new System.Drawing.Point(384, 198);
			this.txt_thealth.Name = "txt_thealth";
			this.txt_thealth.Size = new System.Drawing.Size(157, 26);
			this.txt_thealth.TabIndex = 17;
			// 
			// lb_health
			// 
			this.lb_health.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_health.Location = new System.Drawing.Point(300, 205);
			this.lb_health.Name = "lb_health";
			this.lb_health.Size = new System.Drawing.Size(100, 23);
			this.lb_health.TabIndex = 16;
			this.lb_health.Text = "健康状况：";
			// 
			// txt_tacademic
			// 
			this.txt_tacademic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tacademic.Location = new System.Drawing.Point(384, 138);
			this.txt_tacademic.Name = "txt_tacademic";
			this.txt_tacademic.ReadOnly = true;
			this.txt_tacademic.Size = new System.Drawing.Size(157, 26);
			this.txt_tacademic.TabIndex = 13;
			// 
			// lb_academic
			// 
			this.lb_academic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_academic.Location = new System.Drawing.Point(300, 145);
			this.lb_academic.Name = "lb_academic";
			this.lb_academic.Size = new System.Drawing.Size(100, 23);
			this.lb_academic.TabIndex = 12;
			this.lb_academic.Text = "职    称：";
			// 
			// txt_tage
			// 
			this.txt_tage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tage.Location = new System.Drawing.Point(384, 78);
			this.txt_tage.Name = "txt_tage";
			this.txt_tage.Size = new System.Drawing.Size(157, 26);
			this.txt_tage.TabIndex = 9;
			// 
			// lb_age
			// 
			this.lb_age.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_age.Location = new System.Drawing.Point(300, 85);
			this.lb_age.Name = "lb_age";
			this.lb_age.Size = new System.Drawing.Size(100, 23);
			this.lb_age.TabIndex = 8;
			this.lb_age.Text = "年    龄：";
			// 
			// txt_tname
			// 
			this.txt_tname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tname.Location = new System.Drawing.Point(384, 22);
			this.txt_tname.Name = "txt_tname";
			this.txt_tname.Size = new System.Drawing.Size(157, 26);
			this.txt_tname.TabIndex = 6;
			// 
			// lb_name
			// 
			this.lb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_name.Location = new System.Drawing.Point(300, 29);
			this.lb_name.Name = "lb_name";
			this.lb_name.Size = new System.Drawing.Size(100, 23);
			this.lb_name.TabIndex = 5;
			this.lb_name.Text = "姓    名：";
			// 
			// txt_tdegree
			// 
			this.txt_tdegree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tdegree.Location = new System.Drawing.Point(121, 138);
			this.txt_tdegree.Name = "txt_tdegree";
			this.txt_tdegree.ReadOnly = true;
			this.txt_tdegree.Size = new System.Drawing.Size(157, 26);
			this.txt_tdegree.TabIndex = 11;
			// 
			// lb_degree
			// 
			this.lb_degree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_degree.Location = new System.Drawing.Point(37, 141);
			this.lb_degree.Name = "lb_degree";
			this.lb_degree.Size = new System.Drawing.Size(100, 23);
			this.lb_degree.TabIndex = 10;
			this.lb_degree.Text = "学    历：";
			// 
			// txt_tgender
			// 
			this.txt_tgender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tgender.Location = new System.Drawing.Point(121, 78);
			this.txt_tgender.Name = "txt_tgender";
			this.txt_tgender.Size = new System.Drawing.Size(157, 26);
			this.txt_tgender.TabIndex = 7;
			// 
			// lb_gender
			// 
			this.lb_gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_gender.Location = new System.Drawing.Point(37, 85);
			this.lb_gender.Name = "lb_gender";
			this.lb_gender.Size = new System.Drawing.Size(100, 23);
			this.lb_gender.TabIndex = 31;
			this.lb_gender.Text = "姓    别：";
			// 
			// txt_tid
			// 
			this.txt_tid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_tid.Location = new System.Drawing.Point(121, 22);
			this.txt_tid.Name = "txt_tid";
			this.txt_tid.ReadOnly = true;
			this.txt_tid.Size = new System.Drawing.Size(157, 26);
			this.txt_tid.TabIndex = 4;
			// 
			// lb_id
			// 
			this.lb_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_id.Location = new System.Drawing.Point(37, 29);
			this.lb_id.Name = "lb_id";
			this.lb_id.Size = new System.Drawing.Size(100, 23);
			this.lb_id.TabIndex = 3;
			this.lb_id.Text = "工    号：";
			// 
			// panel_course
			// 
			this.panel_course.Controls.Add(this.txt_Cscore);
			this.panel_course.Controls.Add(this.label1);
			this.panel_course.Controls.Add(this.txt_Ctime);
			this.panel_course.Controls.Add(this.label6);
			this.panel_course.Controls.Add(this.txt_Cclass);
			this.panel_course.Controls.Add(this.label7);
			this.panel_course.Controls.Add(this.txt_Tcourse);
			this.panel_course.Controls.Add(this.label8);
			this.panel_course.Location = new System.Drawing.Point(0, 31);
			this.panel_course.Name = "panel_course";
			this.panel_course.Size = new System.Drawing.Size(630, 371);
			this.panel_course.TabIndex = 19;
			// 
			// txt_Cscore
			// 
			this.txt_Cscore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_Cscore.Location = new System.Drawing.Point(214, 243);
			this.txt_Cscore.Name = "txt_Cscore";
			this.txt_Cscore.ReadOnly = true;
			this.txt_Cscore.Size = new System.Drawing.Size(246, 26);
			this.txt_Cscore.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(130, 250);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 26;
			this.label1.Text = "学    分：";
			// 
			// txt_Ctime
			// 
			this.txt_Ctime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_Ctime.Location = new System.Drawing.Point(214, 175);
			this.txt_Ctime.Name = "txt_Ctime";
			this.txt_Ctime.ReadOnly = true;
			this.txt_Ctime.Size = new System.Drawing.Size(246, 26);
			this.txt_Ctime.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(130, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 24;
			this.label6.Text = "时    间：";
			// 
			// txt_Cclass
			// 
			this.txt_Cclass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_Cclass.Location = new System.Drawing.Point(214, 105);
			this.txt_Cclass.Name = "txt_Cclass";
			this.txt_Cclass.ReadOnly = true;
			this.txt_Cclass.Size = new System.Drawing.Size(246, 26);
			this.txt_Cclass.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(130, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "教    室：";
			// 
			// txt_Tcourse
			// 
			this.txt_Tcourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_Tcourse.Location = new System.Drawing.Point(214, 38);
			this.txt_Tcourse.Name = "txt_Tcourse";
			this.txt_Tcourse.ReadOnly = true;
			this.txt_Tcourse.Size = new System.Drawing.Size(246, 26);
			this.txt_Tcourse.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(130, 45);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "所授课程：";
			// 
			// panel_score
			// 
			this.panel_score.Controls.Add(this.btn_new);
			this.panel_score.Controls.Add(this.btn_updataDatagv);
			this.panel_score.Controls.Add(this.toolStrip1);
			this.panel_score.Controls.Add(this.datagv_score);
			this.panel_score.Location = new System.Drawing.Point(0, 31);
			this.panel_score.Name = "panel_score";
			this.panel_score.Size = new System.Drawing.Size(630, 371);
			this.panel_score.TabIndex = 28;
			// 
			// btn_new
			// 
			this.btn_new.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_new.Location = new System.Drawing.Point(372, 314);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(88, 36);
			this.btn_new.TabIndex = 32;
			this.btn_new.Text = "刷  新";
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.Btn_newClick);
			// 
			// btn_updataDatagv
			// 
			this.btn_updataDatagv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_updataDatagv.Location = new System.Drawing.Point(495, 314);
			this.btn_updataDatagv.Name = "btn_updataDatagv";
			this.btn_updataDatagv.Size = new System.Drawing.Size(88, 36);
			this.btn_updataDatagv.TabIndex = 31;
			this.btn_updataDatagv.Text = "保  存";
			this.btn_updataDatagv.UseVisualStyleBackColor = true;
			this.btn_updataDatagv.Click += new System.EventHandler(this.Btn_datagvOkClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel1,
									this.tstb_number,
									this.tsbtn_idsearch,
									this.toolStripSeparator1,
									this.toolStripLabel2,
									this.tstb_name,
									this.tsbtn_namesearch,
									this.toolStripSeparator2,
									this.toolStripLabel3,
									this.tstb_class,
									this.tsbtn_classsearch});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(630, 25);
			this.toolStrip1.TabIndex = 29;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel1.Text = "学号查询";
			// 
			// tstb_number
			// 
			this.tstb_number.BackColor = System.Drawing.SystemColors.Window;
			this.tstb_number.Name = "tstb_number";
			this.tstb_number.Size = new System.Drawing.Size(120, 25);
			// 
			// tsbtn_idsearch
			// 
			this.tsbtn_idsearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_idsearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_idsearch.Image")));
			this.tsbtn_idsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_idsearch.Name = "tsbtn_idsearch";
			this.tsbtn_idsearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_idsearch.Text = "toolStripButton1";
			this.tsbtn_idsearch.Click += new System.EventHandler(this.Tsbtn_idsearchClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel2.Text = "姓名查询";
			// 
			// tstb_name
			// 
			this.tstb_name.Name = "tstb_name";
			this.tstb_name.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbtn_namesearch
			// 
			this.tsbtn_namesearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_namesearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_namesearch.Image")));
			this.tsbtn_namesearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_namesearch.Name = "tsbtn_namesearch";
			this.tsbtn_namesearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_namesearch.Text = "toolStripButton1";
			this.tsbtn_namesearch.Click += new System.EventHandler(this.Tsbtn_namesearchClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel3.Text = "班级查询";
			// 
			// tstb_class
			// 
			this.tstb_class.Name = "tstb_class";
			this.tstb_class.Size = new System.Drawing.Size(121, 25);
			// 
			// tsbtn_classsearch
			// 
			this.tsbtn_classsearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_classsearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_classsearch.Image")));
			this.tsbtn_classsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_classsearch.Name = "tsbtn_classsearch";
			this.tsbtn_classsearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_classsearch.Text = "toolStripButton2";
			this.tsbtn_classsearch.Click += new System.EventHandler(this.Tsbtn_classsearchClick);
			// 
			// datagv_score
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagv_score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.datagv_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagv_score.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagv_score.DefaultCellStyle = dataGridViewCellStyle4;
			this.datagv_score.Location = new System.Drawing.Point(25, 45);
			this.datagv_score.Name = "datagv_score";
			this.datagv_score.RowTemplate.Height = 23;
			this.datagv_score.Size = new System.Drawing.Size(558, 250);
			this.datagv_score.TabIndex = 30;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "s_number";
			this.Column1.Frozen = true;
			this.Column1.HeaderText = "学号";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 120;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "s_name";
			this.Column2.Frozen = true;
			this.Column2.HeaderText = "姓名";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "s_major";
			this.Column3.Frozen = true;
			this.Column3.HeaderText = "班级";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 160;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "s_score";
			this.Column4.Frozen = true;
			this.Column4.HeaderText = "分数";
			this.Column4.Name = "Column4";
			this.Column4.Width = 120;
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
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsslUser,
									this.tsslRole,
									this.tsslTime,
									this.tsslDate,
									this.tssl_quitlogin});
			this.statusStrip1.Location = new System.Drawing.Point(0, 409);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(630, 25);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tssl_quitlogin
			// 
			this.tssl_quitlogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tssl_quitlogin.Name = "tssl_quitlogin";
			this.tssl_quitlogin.Size = new System.Drawing.Size(73, 20);
			this.tssl_quitlogin.Text = "退出登录";
			this.tssl_quitlogin.Click += new System.EventHandler(this.Tssl_quitloginClick);
			// 
			// teacher_manage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 434);
			this.Controls.Add(this.panel_score);
			this.Controls.Add(this.panel_course);
			this.Controls.Add(this.panel_info);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "teacher_manage";
			this.Text = "教师管理系统";
			this.Load += new System.EventHandler(this.Teacher_manageLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel_info.ResumeLayout(false);
			this.panel_info.PerformLayout();
			this.panel_course.ResumeLayout(false);
			this.panel_course.PerformLayout();
			this.panel_score.ResumeLayout(false);
			this.panel_score.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_score)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel tssl_quitlogin;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Button btn_new;
		private System.Windows.Forms.Button btn_updataDatagv;
		private System.Windows.Forms.ToolStripButton tsbtn_classsearch;
		private System.Windows.Forms.ToolStripComboBox tstb_class;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripButton tsbtn_namesearch;
		private System.Windows.Forms.ToolStripTextBox tstb_name;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbtn_idsearch;
		private System.Windows.Forms.ToolStripTextBox tstb_number;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView datagv_score;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_Tcourse;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_Cclass;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_Ctime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Cscore;
		private System.Windows.Forms.Panel panel_score;
		private System.Windows.Forms.Panel panel_course;
		private System.Windows.Forms.Panel panel_info;
		private System.Windows.Forms.Button btn_updataTInfo;
		private System.Windows.Forms.Label lb_depart;
		private System.Windows.Forms.TextBox txt_tdepartment;
		private System.Windows.Forms.Label lb_health;
		private System.Windows.Forms.TextBox txt_thealth;
		private System.Windows.Forms.Label lb_academic;
		private System.Windows.Forms.TextBox txt_tacademic;
		private System.Windows.Forms.Label lb_age;
		private System.Windows.Forms.TextBox txt_tage;
		private System.Windows.Forms.Label lb_name;
		private System.Windows.Forms.TextBox txt_tname;
		private System.Windows.Forms.Label lb_degree;
		private System.Windows.Forms.TextBox txt_tdegree;
		private System.Windows.Forms.Label lb_gender;
		private System.Windows.Forms.TextBox txt_tgender;
		private System.Windows.Forms.TextBox txt_tid;
		private System.Windows.Forms.Label lb_id;
		private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.ToolStripStatusLabel tsslDate;
		private System.Windows.Forms.ToolStripStatusLabel tsslTime;
		public System.Windows.Forms.ToolStripStatusLabel tsslRole;
		private System.Windows.Forms.ToolStripStatusLabel tsslUser;
		private System.Windows.Forms.StatusStrip statusStrip1;
		
	}
}
