/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/12/1
 * 时间: 22:15
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Course_Manage
{
	partial class admin_manage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_manage));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslRole = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssl_quitlogin = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.教师信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.管理课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.教室管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加教室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.教室信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_sInfo = new System.Windows.Forms.Panel();
			this.btn_StuNew = new System.Windows.Forms.Button();
			this.btn_LookStuInfo = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_StuNumber = new System.Windows.Forms.ToolStripTextBox();
			this.tsbtn_StuIdSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_StuName = new System.Windows.Forms.ToolStripTextBox();
			this.tsbtn_StuNameSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.tscb_StuDepart = new System.Windows.Forms.ToolStripComboBox();
			this.tsbtn_StuDepartSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.tscb_StuClass = new System.Windows.Forms.ToolStripComboBox();
			this.tsbtn_StuClassSearch = new System.Windows.Forms.ToolStripButton();
			this.datagv_sInfo = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_SelectedStuInfo = new System.Windows.Forms.Panel();
			this.btn_StuReturn = new System.Windows.Forms.Button();
			this.cb_sclass = new System.Windows.Forms.ComboBox();
			this.cb_sdepart = new System.Windows.Forms.ComboBox();
			this.txt_sroom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_UpdateStuInfo = new System.Windows.Forms.Button();
			this.txt_smark = new System.Windows.Forms.TextBox();
			this.lb_mark = new System.Windows.Forms.Label();
			this.txt_stime = new System.Windows.Forms.TextBox();
			this.lb_time = new System.Windows.Forms.Label();
			this.txt_sscore = new System.Windows.Forms.TextBox();
			this.lb_academic = new System.Windows.Forms.Label();
			this.lb_age = new System.Windows.Forms.Label();
			this.txt_sname = new System.Windows.Forms.TextBox();
			this.lb_name = new System.Windows.Forms.Label();
			this.txt_scourse = new System.Windows.Forms.TextBox();
			this.lb_degree = new System.Windows.Forms.Label();
			this.lb_gender = new System.Windows.Forms.Label();
			this.txt_sid = new System.Windows.Forms.TextBox();
			this.lb_id = new System.Windows.Forms.Label();
			this.panel_AddStu = new System.Windows.Forms.Panel();
			this.txt_AddStuPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_AddStuAccount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_AddStuInfo = new System.Windows.Forms.Button();
			this.cb_AddStuClass = new System.Windows.Forms.ComboBox();
			this.cb_AddStuDepart = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_AddStuName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_AddStuNumber = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panel_TeaInfo = new System.Windows.Forms.Panel();
			this.btn_TeaNew = new System.Windows.Forms.Button();
			this.btn_TeaLookInfo = new System.Windows.Forms.Button();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_TeaNumber = new System.Windows.Forms.ToolStripTextBox();
			this.tsbtn_TeaNumberSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			this.tstb_TeaName = new System.Windows.Forms.ToolStripTextBox();
			this.tsbtn_TeaNameSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
			this.tscbn_TeaDepart = new System.Windows.Forms.ToolStripComboBox();
			this.tsbtn_TeaDepartSearch = new System.Windows.Forms.ToolStripButton();
			this.DataGv_TeaInfo = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_TeaLookInfo = new System.Windows.Forms.Panel();
			this.btn_UpdateTeaInfo = new System.Windows.Forms.Button();
			this.txt_TeaAcademic = new System.Windows.Forms.TextBox();
			this.cb_TeaBeDepart = new System.Windows.Forms.ComboBox();
			this.txt_TeaCourseClass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_returnTeaGvInfo = new System.Windows.Forms.Button();
			this.txt_TeaCourseTime = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_TeaScore = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_TName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_TeaCourse = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txt_TeaNumber = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.panel_AddTeaInfo = new System.Windows.Forms.Panel();
			this.txt_AddTeaCourseScore = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txt_AddTeaCourseRoom = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txt_AddTeaCourseTime = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txt_AddTeaPass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_AddTeaAccount = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.btn_AddTeaInfo = new System.Windows.Forms.Button();
			this.cb_AddTeaCourse = new System.Windows.Forms.ComboBox();
			this.cb_AddTeaDepart = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txt_AddTeaName = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txt_AddTeaNumber = new System.Windows.Forms.TextBox();
			this.txtbox4 = new System.Windows.Forms.Label();
			this.panel_CourseInfo = new System.Windows.Forms.Panel();
			this.btn_CourseNew = new System.Windows.Forms.Button();
			this.btn_CourseLookInfo = new System.Windows.Forms.Button();
			this.dataGv_CourseInfo = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_CourseLookInfo = new System.Windows.Forms.Panel();
			this.btn_UpdateCourseInfo = new System.Windows.Forms.Button();
			this.txt_CourseTime = new System.Windows.Forms.TextBox();
			this.cb_CourseType = new System.Windows.Forms.ComboBox();
			this.cb_CourseRoom = new System.Windows.Forms.ComboBox();
			this.txt_CourseChoose = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.btn_ReturnClassInfo = new System.Windows.Forms.Button();
			this.txt_CourseInclu = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txt_CourseTea = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.txt_CourseScore = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.txt_CourseName = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.panel_AddCourse = new System.Windows.Forms.Panel();
			this.txt_AddCourseTeaNumber = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.cb_AddCourseTeaName = new System.Windows.Forms.ComboBox();
			this.label34 = new System.Windows.Forms.Label();
			this.cb_AddCourseTeaDepart = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txt_AddCourseTime = new System.Windows.Forms.TextBox();
			this.cb_AddCourseType = new System.Windows.Forms.ComboBox();
			this.cb_AddCourseRoom = new System.Windows.Forms.ComboBox();
			this.btn_AddCourse = new System.Windows.Forms.Button();
			this.txt_AddCourseInclu = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.txt_AddCourseScore = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.txt_AddCourseName = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.panel_ClassInfo = new System.Windows.Forms.Panel();
			this.btn_NewClass = new System.Windows.Forms.Button();
			this.btn_LookClassInfo = new System.Windows.Forms.Button();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
			this.tscb_ClassType = new System.Windows.Forms.ToolStripComboBox();
			this.tsbtn_ClassTypeSearch = new System.Windows.Forms.ToolStripButton();
			this.DataGv_ClassInfo = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_ClassInfoLook = new System.Windows.Forms.Panel();
			this.txt_ClassSelectNumber = new System.Windows.Forms.TextBox();
			this.btn_UpdateClassInfo = new System.Windows.Forms.Button();
			this.txt_ClassSelectTime = new System.Windows.Forms.TextBox();
			this.cb_ClassSelectType = new System.Windows.Forms.ComboBox();
			this.btn_ReturnGvClass = new System.Windows.Forms.Button();
			this.txt_ClassSelectPeople = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.txt_ClassSelectTea = new System.Windows.Forms.TextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.txt_ClassSelectName = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.panel_AddClassInfo = new System.Windows.Forms.Panel();
			this.txt_AddClassNumber = new System.Windows.Forms.TextBox();
			this.cb_AddClassType = new System.Windows.Forms.ComboBox();
			this.btn_AddClass = new System.Windows.Forms.Button();
			this.txt_AddClassPeople = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel_sInfo.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_sInfo)).BeginInit();
			this.panel_SelectedStuInfo.SuspendLayout();
			this.panel_AddStu.SuspendLayout();
			this.panel_TeaInfo.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGv_TeaInfo)).BeginInit();
			this.panel_TeaLookInfo.SuspendLayout();
			this.panel_AddTeaInfo.SuspendLayout();
			this.panel_CourseInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGv_CourseInfo)).BeginInit();
			this.panel_CourseLookInfo.SuspendLayout();
			this.panel_AddCourse.SuspendLayout();
			this.panel_ClassInfo.SuspendLayout();
			this.toolStrip3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGv_ClassInfo)).BeginInit();
			this.panel_ClassInfoLook.SuspendLayout();
			this.panel_AddClassInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsslUser,
									this.tsslRole,
									this.tsslTime,
									this.tsslDate,
									this.tssl_quitlogin});
			this.statusStrip1.Location = new System.Drawing.Point(0, 496);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(879, 25);
			this.statusStrip1.TabIndex = 2;
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
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.学生管理ToolStripMenuItem,
									this.教师管理ToolStripMenuItem,
									this.课程管理ToolStripMenuItem,
									this.教室管理ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(879, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 学生管理ToolStripMenuItem
			// 
			this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.添加学生ToolStripMenuItem,
									this.学生信息管理ToolStripMenuItem});
			this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
			this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.学生管理ToolStripMenuItem.Text = "学生管理";
			// 
			// 添加学生ToolStripMenuItem
			// 
			this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
			this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.添加学生ToolStripMenuItem.Text = "添加学生";
			this.添加学生ToolStripMenuItem.Click += new System.EventHandler(this.添加学生ToolStripMenuItemClick);
			// 
			// 学生信息管理ToolStripMenuItem
			// 
			this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
			this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
			this.学生信息管理ToolStripMenuItem.Click += new System.EventHandler(this.学生信息管理ToolStripMenuItemClick);
			// 
			// 教师管理ToolStripMenuItem
			// 
			this.教师管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.添加教师ToolStripMenuItem,
									this.教师信息管理ToolStripMenuItem});
			this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
			this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.教师管理ToolStripMenuItem.Text = "教师管理";
			// 
			// 添加教师ToolStripMenuItem
			// 
			this.添加教师ToolStripMenuItem.Name = "添加教师ToolStripMenuItem";
			this.添加教师ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.添加教师ToolStripMenuItem.Text = "添加教师";
			this.添加教师ToolStripMenuItem.Click += new System.EventHandler(this.添加教师ToolStripMenuItemClick);
			// 
			// 教师信息管理ToolStripMenuItem
			// 
			this.教师信息管理ToolStripMenuItem.Name = "教师信息管理ToolStripMenuItem";
			this.教师信息管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.教师信息管理ToolStripMenuItem.Text = "教师信息管理";
			this.教师信息管理ToolStripMenuItem.Click += new System.EventHandler(this.教师信息管理ToolStripMenuItemClick);
			// 
			// 课程管理ToolStripMenuItem
			// 
			this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.添加课程ToolStripMenuItem,
									this.管理课程ToolStripMenuItem});
			this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
			this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.课程管理ToolStripMenuItem.Text = "课程管理";
			// 
			// 添加课程ToolStripMenuItem
			// 
			this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
			this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.添加课程ToolStripMenuItem.Text = "添加课程";
			this.添加课程ToolStripMenuItem.Click += new System.EventHandler(this.添加课程ToolStripMenuItemClick);
			// 
			// 管理课程ToolStripMenuItem
			// 
			this.管理课程ToolStripMenuItem.Name = "管理课程ToolStripMenuItem";
			this.管理课程ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.管理课程ToolStripMenuItem.Text = "管理课程";
			this.管理课程ToolStripMenuItem.Click += new System.EventHandler(this.管理课程ToolStripMenuItemClick);
			// 
			// 教室管理ToolStripMenuItem
			// 
			this.教室管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.添加教室ToolStripMenuItem,
									this.教室信息管理ToolStripMenuItem});
			this.教室管理ToolStripMenuItem.Name = "教室管理ToolStripMenuItem";
			this.教室管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.教室管理ToolStripMenuItem.Text = "教室管理";
			// 
			// 添加教室ToolStripMenuItem
			// 
			this.添加教室ToolStripMenuItem.Name = "添加教室ToolStripMenuItem";
			this.添加教室ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.添加教室ToolStripMenuItem.Text = "添加教室";
			this.添加教室ToolStripMenuItem.Click += new System.EventHandler(this.添加教室ToolStripMenuItemClick);
			// 
			// 教室信息管理ToolStripMenuItem
			// 
			this.教室信息管理ToolStripMenuItem.Name = "教室信息管理ToolStripMenuItem";
			this.教室信息管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.教室信息管理ToolStripMenuItem.Text = "教室信息管理";
			this.教室信息管理ToolStripMenuItem.Click += new System.EventHandler(this.教室信息管理ToolStripMenuItemClick);
			// 
			// panel_sInfo
			// 
			this.panel_sInfo.Controls.Add(this.btn_StuNew);
			this.panel_sInfo.Controls.Add(this.btn_LookStuInfo);
			this.panel_sInfo.Controls.Add(this.toolStrip1);
			this.panel_sInfo.Controls.Add(this.datagv_sInfo);
			this.panel_sInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_sInfo.Name = "panel_sInfo";
			this.panel_sInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_sInfo.TabIndex = 29;
			// 
			// btn_StuNew
			// 
			this.btn_StuNew.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_StuNew.Location = new System.Drawing.Point(601, 336);
			this.btn_StuNew.Name = "btn_StuNew";
			this.btn_StuNew.Size = new System.Drawing.Size(88, 36);
			this.btn_StuNew.TabIndex = 32;
			this.btn_StuNew.Text = "刷  新";
			this.btn_StuNew.UseVisualStyleBackColor = true;
			this.btn_StuNew.Click += new System.EventHandler(this.Btn_StuNewClick);
			// 
			// btn_LookStuInfo
			// 
			this.btn_LookStuInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_LookStuInfo.Location = new System.Drawing.Point(759, 336);
			this.btn_LookStuInfo.Name = "btn_LookStuInfo";
			this.btn_LookStuInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_LookStuInfo.TabIndex = 31;
			this.btn_LookStuInfo.Text = "查  看";
			this.btn_LookStuInfo.UseVisualStyleBackColor = true;
			this.btn_LookStuInfo.Click += new System.EventHandler(this.Btn_LookStuInfoClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel1,
									this.tstb_StuNumber,
									this.tsbtn_StuIdSearch,
									this.toolStripSeparator1,
									this.toolStripLabel2,
									this.tstb_StuName,
									this.tsbtn_StuNameSearch,
									this.toolStripSeparator2,
									this.toolStripLabel4,
									this.tscb_StuDepart,
									this.tsbtn_StuDepartSearch,
									this.toolStripSeparator3,
									this.toolStripLabel3,
									this.tscb_StuClass,
									this.tsbtn_StuClassSearch});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(868, 25);
			this.toolStrip1.TabIndex = 29;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel1.Text = "学号查询";
			// 
			// tstb_StuNumber
			// 
			this.tstb_StuNumber.BackColor = System.Drawing.SystemColors.Window;
			this.tstb_StuNumber.Name = "tstb_StuNumber";
			this.tstb_StuNumber.Size = new System.Drawing.Size(120, 25);
			// 
			// tsbtn_StuIdSearch
			// 
			this.tsbtn_StuIdSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_StuIdSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_StuIdSearch.Image")));
			this.tsbtn_StuIdSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_StuIdSearch.Name = "tsbtn_StuIdSearch";
			this.tsbtn_StuIdSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_StuIdSearch.Text = "查询";
			this.tsbtn_StuIdSearch.Click += new System.EventHandler(this.Tsbtn_StuIdSearchClick);
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
			// tstb_StuName
			// 
			this.tstb_StuName.Name = "tstb_StuName";
			this.tstb_StuName.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbtn_StuNameSearch
			// 
			this.tsbtn_StuNameSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_StuNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_StuNameSearch.Image")));
			this.tsbtn_StuNameSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_StuNameSearch.Name = "tsbtn_StuNameSearch";
			this.tsbtn_StuNameSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_StuNameSearch.Text = "查询";
			this.tsbtn_StuNameSearch.Click += new System.EventHandler(this.Tsbtn_StuNameSearchClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel4.Text = "院系查询";
			// 
			// tscb_StuDepart
			// 
			this.tscb_StuDepart.Name = "tscb_StuDepart";
			this.tscb_StuDepart.Size = new System.Drawing.Size(121, 25);
			// 
			// tsbtn_StuDepartSearch
			// 
			this.tsbtn_StuDepartSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_StuDepartSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_StuDepartSearch.Image")));
			this.tsbtn_StuDepartSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_StuDepartSearch.Name = "tsbtn_StuDepartSearch";
			this.tsbtn_StuDepartSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_StuDepartSearch.Text = "查询";
			this.tsbtn_StuDepartSearch.Click += new System.EventHandler(this.Tsbtn_StuDepartSearchClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel3.Text = "班级查询";
			// 
			// tscb_StuClass
			// 
			this.tscb_StuClass.Name = "tscb_StuClass";
			this.tscb_StuClass.Size = new System.Drawing.Size(121, 25);
			this.tscb_StuClass.Click += new System.EventHandler(this.Tscb_StuClassClick);
			// 
			// tsbtn_StuClassSearch
			// 
			this.tsbtn_StuClassSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_StuClassSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_StuClassSearch.Image")));
			this.tsbtn_StuClassSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_StuClassSearch.Name = "tsbtn_StuClassSearch";
			this.tsbtn_StuClassSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_StuClassSearch.Text = "查询";
			this.tsbtn_StuClassSearch.Click += new System.EventHandler(this.Tsbtn_StuClassSearchClick);
			// 
			// datagv_sInfo
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagv_sInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.datagv_sInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagv_sInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column5,
									this.Column3,
									this.Column4,
									this.Column6});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagv_sInfo.DefaultCellStyle = dataGridViewCellStyle2;
			this.datagv_sInfo.Location = new System.Drawing.Point(23, 37);
			this.datagv_sInfo.Name = "datagv_sInfo";
			this.datagv_sInfo.RowTemplate.Height = 23;
			this.datagv_sInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datagv_sInfo.Size = new System.Drawing.Size(824, 257);
			this.datagv_sInfo.TabIndex = 30;
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
			// Column5
			// 
			this.Column5.DataPropertyName = "d_name";
			this.Column5.Frozen = true;
			this.Column5.HeaderText = "所属院系";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 135;
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
			this.Column4.DataPropertyName = "s_course";
			this.Column4.Frozen = true;
			this.Column4.HeaderText = "已选课程";
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "s_score";
			this.Column6.Frozen = true;
			this.Column6.HeaderText = "分数";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// panel_SelectedStuInfo
			// 
			this.panel_SelectedStuInfo.Controls.Add(this.btn_StuReturn);
			this.panel_SelectedStuInfo.Controls.Add(this.cb_sclass);
			this.panel_SelectedStuInfo.Controls.Add(this.cb_sdepart);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_sroom);
			this.panel_SelectedStuInfo.Controls.Add(this.label1);
			this.panel_SelectedStuInfo.Controls.Add(this.btn_UpdateStuInfo);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_smark);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_mark);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_stime);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_time);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_sscore);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_academic);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_age);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_sname);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_name);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_scourse);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_degree);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_gender);
			this.panel_SelectedStuInfo.Controls.Add(this.txt_sid);
			this.panel_SelectedStuInfo.Controls.Add(this.lb_id);
			this.panel_SelectedStuInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_SelectedStuInfo.Name = "panel_SelectedStuInfo";
			this.panel_SelectedStuInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_SelectedStuInfo.TabIndex = 30;
			// 
			// btn_StuReturn
			// 
			this.btn_StuReturn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_StuReturn.Location = new System.Drawing.Point(627, 362);
			this.btn_StuReturn.Name = "btn_StuReturn";
			this.btn_StuReturn.Size = new System.Drawing.Size(88, 36);
			this.btn_StuReturn.TabIndex = 23;
			this.btn_StuReturn.Text = "返  回";
			this.btn_StuReturn.UseVisualStyleBackColor = true;
			this.btn_StuReturn.Click += new System.EventHandler(this.Btn_StuReturnClick);
			// 
			// cb_sclass
			// 
			this.cb_sclass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_sclass.FormattingEnabled = true;
			this.cb_sclass.Location = new System.Drawing.Point(558, 102);
			this.cb_sclass.Name = "cb_sclass";
			this.cb_sclass.Size = new System.Drawing.Size(205, 24);
			this.cb_sclass.TabIndex = 22;
			this.cb_sclass.Click += new System.EventHandler(this.Cb_sclassClick);
			// 
			// cb_sdepart
			// 
			this.cb_sdepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_sdepart.FormattingEnabled = true;
			this.cb_sdepart.Location = new System.Drawing.Point(205, 102);
			this.cb_sdepart.Name = "cb_sdepart";
			this.cb_sdepart.Size = new System.Drawing.Size(205, 24);
			this.cb_sdepart.TabIndex = 21;
			// 
			// txt_sroom
			// 
			this.txt_sroom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sroom.Location = new System.Drawing.Point(558, 238);
			this.txt_sroom.Name = "txt_sroom";
			this.txt_sroom.ReadOnly = true;
			this.txt_sroom.Size = new System.Drawing.Size(205, 26);
			this.txt_sroom.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(474, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "课程教室：";
			// 
			// btn_UpdateStuInfo
			// 
			this.btn_UpdateStuInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_UpdateStuInfo.Location = new System.Drawing.Point(486, 362);
			this.btn_UpdateStuInfo.Name = "btn_UpdateStuInfo";
			this.btn_UpdateStuInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_UpdateStuInfo.TabIndex = 18;
			this.btn_UpdateStuInfo.Text = "修  改";
			this.btn_UpdateStuInfo.UseVisualStyleBackColor = true;
			this.btn_UpdateStuInfo.Click += new System.EventHandler(this.Btn_UpdateStuInfoClick);
			// 
			// txt_smark
			// 
			this.txt_smark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_smark.Location = new System.Drawing.Point(205, 308);
			this.txt_smark.Name = "txt_smark";
			this.txt_smark.ReadOnly = true;
			this.txt_smark.Size = new System.Drawing.Size(205, 26);
			this.txt_smark.TabIndex = 17;
			// 
			// lb_mark
			// 
			this.lb_mark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_mark.Location = new System.Drawing.Point(121, 311);
			this.lb_mark.Name = "lb_mark";
			this.lb_mark.Size = new System.Drawing.Size(100, 23);
			this.lb_mark.TabIndex = 16;
			this.lb_mark.Text = "成    绩：";
			// 
			// txt_stime
			// 
			this.txt_stime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_stime.Location = new System.Drawing.Point(205, 241);
			this.txt_stime.Name = "txt_stime";
			this.txt_stime.ReadOnly = true;
			this.txt_stime.Size = new System.Drawing.Size(205, 26);
			this.txt_stime.TabIndex = 15;
			// 
			// lb_time
			// 
			this.lb_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_time.Location = new System.Drawing.Point(121, 244);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(100, 23);
			this.lb_time.TabIndex = 14;
			this.lb_time.Text = "课程时间：";
			// 
			// txt_sscore
			// 
			this.txt_sscore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sscore.Location = new System.Drawing.Point(558, 171);
			this.txt_sscore.Name = "txt_sscore";
			this.txt_sscore.ReadOnly = true;
			this.txt_sscore.Size = new System.Drawing.Size(205, 26);
			this.txt_sscore.TabIndex = 13;
			// 
			// lb_academic
			// 
			this.lb_academic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_academic.Location = new System.Drawing.Point(474, 178);
			this.lb_academic.Name = "lb_academic";
			this.lb_academic.Size = new System.Drawing.Size(100, 23);
			this.lb_academic.TabIndex = 13;
			this.lb_academic.Text = "学    分：";
			// 
			// lb_age
			// 
			this.lb_age.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_age.Location = new System.Drawing.Point(474, 109);
			this.lb_age.Name = "lb_age";
			this.lb_age.Size = new System.Drawing.Size(100, 23);
			this.lb_age.TabIndex = 9;
			this.lb_age.Text = "班    级：";
			// 
			// txt_sname
			// 
			this.txt_sname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sname.Location = new System.Drawing.Point(558, 36);
			this.txt_sname.Name = "txt_sname";
			this.txt_sname.ReadOnly = true;
			this.txt_sname.Size = new System.Drawing.Size(205, 26);
			this.txt_sname.TabIndex = 6;
			// 
			// lb_name
			// 
			this.lb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_name.Location = new System.Drawing.Point(474, 43);
			this.lb_name.Name = "lb_name";
			this.lb_name.Size = new System.Drawing.Size(100, 23);
			this.lb_name.TabIndex = 5;
			this.lb_name.Text = "姓    名：";
			// 
			// txt_scourse
			// 
			this.txt_scourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_scourse.Location = new System.Drawing.Point(205, 171);
			this.txt_scourse.Name = "txt_scourse";
			this.txt_scourse.ReadOnly = true;
			this.txt_scourse.Size = new System.Drawing.Size(205, 26);
			this.txt_scourse.TabIndex = 12;
			// 
			// lb_degree
			// 
			this.lb_degree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_degree.Location = new System.Drawing.Point(121, 174);
			this.lb_degree.Name = "lb_degree";
			this.lb_degree.Size = new System.Drawing.Size(100, 23);
			this.lb_degree.TabIndex = 11;
			this.lb_degree.Text = "已选课程：";
			// 
			// lb_gender
			// 
			this.lb_gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_gender.Location = new System.Drawing.Point(121, 109);
			this.lb_gender.Name = "lb_gender";
			this.lb_gender.Size = new System.Drawing.Size(100, 23);
			this.lb_gender.TabIndex = 7;
			this.lb_gender.Text = "所属院系：";
			// 
			// txt_sid
			// 
			this.txt_sid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sid.Location = new System.Drawing.Point(205, 36);
			this.txt_sid.Name = "txt_sid";
			this.txt_sid.ReadOnly = true;
			this.txt_sid.Size = new System.Drawing.Size(205, 26);
			this.txt_sid.TabIndex = 4;
			// 
			// lb_id
			// 
			this.lb_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_id.Location = new System.Drawing.Point(121, 43);
			this.lb_id.Name = "lb_id";
			this.lb_id.Size = new System.Drawing.Size(100, 23);
			this.lb_id.TabIndex = 3;
			this.lb_id.Text = "学    号：";
			// 
			// panel_AddStu
			// 
			this.panel_AddStu.Controls.Add(this.txt_AddStuPass);
			this.panel_AddStu.Controls.Add(this.label2);
			this.panel_AddStu.Controls.Add(this.txt_AddStuAccount);
			this.panel_AddStu.Controls.Add(this.label3);
			this.panel_AddStu.Controls.Add(this.btn_AddStuInfo);
			this.panel_AddStu.Controls.Add(this.cb_AddStuClass);
			this.panel_AddStu.Controls.Add(this.cb_AddStuDepart);
			this.panel_AddStu.Controls.Add(this.label6);
			this.panel_AddStu.Controls.Add(this.txt_AddStuName);
			this.panel_AddStu.Controls.Add(this.label7);
			this.panel_AddStu.Controls.Add(this.label9);
			this.panel_AddStu.Controls.Add(this.txt_AddStuNumber);
			this.panel_AddStu.Controls.Add(this.label10);
			this.panel_AddStu.Location = new System.Drawing.Point(0, 31);
			this.panel_AddStu.Name = "panel_AddStu";
			this.panel_AddStu.Size = new System.Drawing.Size(868, 417);
			this.panel_AddStu.TabIndex = 27;
			// 
			// txt_AddStuPass
			// 
			this.txt_AddStuPass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddStuPass.Location = new System.Drawing.Point(558, 60);
			this.txt_AddStuPass.Name = "txt_AddStuPass";
			this.txt_AddStuPass.Size = new System.Drawing.Size(205, 26);
			this.txt_AddStuPass.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(474, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 26;
			this.label2.Text = "密    码：";
			// 
			// txt_AddStuAccount
			// 
			this.txt_AddStuAccount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddStuAccount.Location = new System.Drawing.Point(205, 60);
			this.txt_AddStuAccount.Name = "txt_AddStuAccount";
			this.txt_AddStuAccount.Size = new System.Drawing.Size(205, 26);
			this.txt_AddStuAccount.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(121, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 24;
			this.label3.Text = "帐    号：";
			// 
			// btn_AddStuInfo
			// 
			this.btn_AddStuInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_AddStuInfo.Location = new System.Drawing.Point(675, 336);
			this.btn_AddStuInfo.Name = "btn_AddStuInfo";
			this.btn_AddStuInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_AddStuInfo.TabIndex = 23;
			this.btn_AddStuInfo.Text = "添  加";
			this.btn_AddStuInfo.UseVisualStyleBackColor = true;
			this.btn_AddStuInfo.Click += new System.EventHandler(this.Btn_AddStuInfoClick);
			// 
			// cb_AddStuClass
			// 
			this.cb_AddStuClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddStuClass.FormattingEnabled = true;
			this.cb_AddStuClass.Location = new System.Drawing.Point(558, 235);
			this.cb_AddStuClass.Name = "cb_AddStuClass";
			this.cb_AddStuClass.Size = new System.Drawing.Size(205, 24);
			this.cb_AddStuClass.TabIndex = 22;
			this.cb_AddStuClass.Click += new System.EventHandler(this.Cb_AddStuClassClick);
			// 
			// cb_AddStuDepart
			// 
			this.cb_AddStuDepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddStuDepart.FormattingEnabled = true;
			this.cb_AddStuDepart.Location = new System.Drawing.Point(205, 235);
			this.cb_AddStuDepart.Name = "cb_AddStuDepart";
			this.cb_AddStuDepart.Size = new System.Drawing.Size(205, 24);
			this.cb_AddStuDepart.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(474, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "班    级：";
			// 
			// txt_AddStuName
			// 
			this.txt_AddStuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddStuName.Location = new System.Drawing.Point(558, 145);
			this.txt_AddStuName.Name = "txt_AddStuName";
			this.txt_AddStuName.Size = new System.Drawing.Size(205, 26);
			this.txt_AddStuName.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(474, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 5;
			this.label7.Text = "姓    名：";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(121, 242);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 7;
			this.label9.Text = "所属院系：";
			// 
			// txt_AddStuNumber
			// 
			this.txt_AddStuNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddStuNumber.Location = new System.Drawing.Point(205, 145);
			this.txt_AddStuNumber.Name = "txt_AddStuNumber";
			this.txt_AddStuNumber.Size = new System.Drawing.Size(205, 26);
			this.txt_AddStuNumber.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(121, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 3;
			this.label10.Text = "学    号：";
			// 
			// panel_TeaInfo
			// 
			this.panel_TeaInfo.Controls.Add(this.btn_TeaNew);
			this.panel_TeaInfo.Controls.Add(this.btn_TeaLookInfo);
			this.panel_TeaInfo.Controls.Add(this.toolStrip2);
			this.panel_TeaInfo.Controls.Add(this.DataGv_TeaInfo);
			this.panel_TeaInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_TeaInfo.Name = "panel_TeaInfo";
			this.panel_TeaInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_TeaInfo.TabIndex = 33;
			// 
			// btn_TeaNew
			// 
			this.btn_TeaNew.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_TeaNew.Location = new System.Drawing.Point(601, 336);
			this.btn_TeaNew.Name = "btn_TeaNew";
			this.btn_TeaNew.Size = new System.Drawing.Size(88, 36);
			this.btn_TeaNew.TabIndex = 32;
			this.btn_TeaNew.Text = "刷  新";
			this.btn_TeaNew.UseVisualStyleBackColor = true;
			this.btn_TeaNew.Click += new System.EventHandler(this.Btn_TeaNewClick);
			// 
			// btn_TeaLookInfo
			// 
			this.btn_TeaLookInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_TeaLookInfo.Location = new System.Drawing.Point(759, 336);
			this.btn_TeaLookInfo.Name = "btn_TeaLookInfo";
			this.btn_TeaLookInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_TeaLookInfo.TabIndex = 31;
			this.btn_TeaLookInfo.Text = "查  看";
			this.btn_TeaLookInfo.UseVisualStyleBackColor = true;
			this.btn_TeaLookInfo.Click += new System.EventHandler(this.Btn_TeaLookInfoClick);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel5,
									this.tstb_TeaNumber,
									this.tsbtn_TeaNumberSearch,
									this.toolStripSeparator4,
									this.toolStripLabel6,
									this.tstb_TeaName,
									this.tsbtn_TeaNameSearch,
									this.toolStripSeparator5,
									this.toolStripLabel7,
									this.tscbn_TeaDepart,
									this.tsbtn_TeaDepartSearch});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(868, 25);
			this.toolStrip2.TabIndex = 29;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel5.Text = "工号查询";
			// 
			// tstb_TeaNumber
			// 
			this.tstb_TeaNumber.BackColor = System.Drawing.SystemColors.Window;
			this.tstb_TeaNumber.Name = "tstb_TeaNumber";
			this.tstb_TeaNumber.Size = new System.Drawing.Size(120, 25);
			// 
			// tsbtn_TeaNumberSearch
			// 
			this.tsbtn_TeaNumberSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_TeaNumberSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_TeaNumberSearch.Image")));
			this.tsbtn_TeaNumberSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_TeaNumberSearch.Name = "tsbtn_TeaNumberSearch";
			this.tsbtn_TeaNumberSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_TeaNumberSearch.Text = "查询";
			this.tsbtn_TeaNumberSearch.Click += new System.EventHandler(this.Tsbtn_TeaNumberSearchClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel6.Text = "姓名查询";
			// 
			// tstb_TeaName
			// 
			this.tstb_TeaName.Name = "tstb_TeaName";
			this.tstb_TeaName.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbtn_TeaNameSearch
			// 
			this.tsbtn_TeaNameSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_TeaNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_TeaNameSearch.Image")));
			this.tsbtn_TeaNameSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_TeaNameSearch.Name = "tsbtn_TeaNameSearch";
			this.tsbtn_TeaNameSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_TeaNameSearch.Text = "查询";
			this.tsbtn_TeaNameSearch.Click += new System.EventHandler(this.Tsbtn_TeaNameSearchClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel7
			// 
			this.toolStripLabel7.Name = "toolStripLabel7";
			this.toolStripLabel7.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel7.Text = "院系查询";
			// 
			// tscbn_TeaDepart
			// 
			this.tscbn_TeaDepart.Name = "tscbn_TeaDepart";
			this.tscbn_TeaDepart.Size = new System.Drawing.Size(121, 25);
			this.tscbn_TeaDepart.Click += new System.EventHandler(this.Tscbn_TeaDepartClick);
			// 
			// tsbtn_TeaDepartSearch
			// 
			this.tsbtn_TeaDepartSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_TeaDepartSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_TeaDepartSearch.Image")));
			this.tsbtn_TeaDepartSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_TeaDepartSearch.Name = "tsbtn_TeaDepartSearch";
			this.tsbtn_TeaDepartSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_TeaDepartSearch.Text = "查询";
			this.tsbtn_TeaDepartSearch.Click += new System.EventHandler(this.Tsbtn_TeaDepartSearchClick);
			// 
			// DataGv_TeaInfo
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGv_TeaInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DataGv_TeaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGv_TeaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn5,
									this.dataGridViewTextBoxColumn6,
									this.Column7});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGv_TeaInfo.DefaultCellStyle = dataGridViewCellStyle4;
			this.DataGv_TeaInfo.Location = new System.Drawing.Point(23, 37);
			this.DataGv_TeaInfo.Name = "DataGv_TeaInfo";
			this.DataGv_TeaInfo.RowTemplate.Height = 23;
			this.DataGv_TeaInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGv_TeaInfo.Size = new System.Drawing.Size(838, 257);
			this.DataGv_TeaInfo.TabIndex = 30;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "t_number";
			this.dataGridViewTextBoxColumn1.Frozen = true;
			this.dataGridViewTextBoxColumn1.HeaderText = "工号";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 120;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "t_name";
			this.dataGridViewTextBoxColumn2.Frozen = true;
			this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "t_department";
			this.dataGridViewTextBoxColumn3.Frozen = true;
			this.dataGridViewTextBoxColumn3.HeaderText = "所属院系";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 170;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "t_course";
			this.dataGridViewTextBoxColumn5.Frozen = true;
			this.dataGridViewTextBoxColumn5.HeaderText = "所授课程";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 170;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "course_class";
			this.dataGridViewTextBoxColumn6.Frozen = true;
			this.dataGridViewTextBoxColumn6.HeaderText = "课程教室";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "course_time";
			this.Column7.Frozen = true;
			this.Column7.HeaderText = "课程时间";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 140;
			// 
			// panel_TeaLookInfo
			// 
			this.panel_TeaLookInfo.Controls.Add(this.btn_UpdateTeaInfo);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TeaAcademic);
			this.panel_TeaLookInfo.Controls.Add(this.cb_TeaBeDepart);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TeaCourseClass);
			this.panel_TeaLookInfo.Controls.Add(this.label4);
			this.panel_TeaLookInfo.Controls.Add(this.btn_returnTeaGvInfo);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TeaCourseTime);
			this.panel_TeaLookInfo.Controls.Add(this.label8);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TeaScore);
			this.panel_TeaLookInfo.Controls.Add(this.label11);
			this.panel_TeaLookInfo.Controls.Add(this.label12);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TName);
			this.panel_TeaLookInfo.Controls.Add(this.label13);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TeaCourse);
			this.panel_TeaLookInfo.Controls.Add(this.label14);
			this.panel_TeaLookInfo.Controls.Add(this.label15);
			this.panel_TeaLookInfo.Controls.Add(this.txt_TeaNumber);
			this.panel_TeaLookInfo.Controls.Add(this.label16);
			this.panel_TeaLookInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_TeaLookInfo.Name = "panel_TeaLookInfo";
			this.panel_TeaLookInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_TeaLookInfo.TabIndex = 34;
			// 
			// btn_UpdateTeaInfo
			// 
			this.btn_UpdateTeaInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_UpdateTeaInfo.Location = new System.Drawing.Point(474, 336);
			this.btn_UpdateTeaInfo.Name = "btn_UpdateTeaInfo";
			this.btn_UpdateTeaInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_UpdateTeaInfo.TabIndex = 23;
			this.btn_UpdateTeaInfo.Text = "修  改";
			this.btn_UpdateTeaInfo.UseVisualStyleBackColor = true;
			this.btn_UpdateTeaInfo.Click += new System.EventHandler(this.Btn_UpdateTeaInfoClick);
			// 
			// txt_TeaAcademic
			// 
			this.txt_TeaAcademic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TeaAcademic.Location = new System.Drawing.Point(558, 102);
			this.txt_TeaAcademic.Name = "txt_TeaAcademic";
			this.txt_TeaAcademic.Size = new System.Drawing.Size(157, 26);
			this.txt_TeaAcademic.TabIndex = 22;
			// 
			// cb_TeaBeDepart
			// 
			this.cb_TeaBeDepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_TeaBeDepart.FormattingEnabled = true;
			this.cb_TeaBeDepart.Location = new System.Drawing.Point(205, 102);
			this.cb_TeaBeDepart.Name = "cb_TeaBeDepart";
			this.cb_TeaBeDepart.Size = new System.Drawing.Size(157, 24);
			this.cb_TeaBeDepart.TabIndex = 21;
			// 
			// txt_TeaCourseClass
			// 
			this.txt_TeaCourseClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TeaCourseClass.Location = new System.Drawing.Point(558, 238);
			this.txt_TeaCourseClass.Name = "txt_TeaCourseClass";
			this.txt_TeaCourseClass.Size = new System.Drawing.Size(157, 26);
			this.txt_TeaCourseClass.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(474, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "课程教室：";
			// 
			// btn_returnTeaGvInfo
			// 
			this.btn_returnTeaGvInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_returnTeaGvInfo.Location = new System.Drawing.Point(627, 336);
			this.btn_returnTeaGvInfo.Name = "btn_returnTeaGvInfo";
			this.btn_returnTeaGvInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_returnTeaGvInfo.TabIndex = 18;
			this.btn_returnTeaGvInfo.Text = "返  回";
			this.btn_returnTeaGvInfo.UseVisualStyleBackColor = true;
			this.btn_returnTeaGvInfo.Click += new System.EventHandler(this.Btn_returnTeaGvInfoClick);
			// 
			// txt_TeaCourseTime
			// 
			this.txt_TeaCourseTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TeaCourseTime.Location = new System.Drawing.Point(205, 241);
			this.txt_TeaCourseTime.Name = "txt_TeaCourseTime";
			this.txt_TeaCourseTime.Size = new System.Drawing.Size(157, 26);
			this.txt_TeaCourseTime.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(121, 244);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "课程时间：";
			// 
			// txt_TeaScore
			// 
			this.txt_TeaScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TeaScore.Location = new System.Drawing.Point(558, 171);
			this.txt_TeaScore.Name = "txt_TeaScore";
			this.txt_TeaScore.Size = new System.Drawing.Size(157, 26);
			this.txt_TeaScore.TabIndex = 13;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.Location = new System.Drawing.Point(474, 178);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 13;
			this.label11.Text = "学    分：";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.Location = new System.Drawing.Point(474, 109);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 9;
			this.label12.Text = "职    称：";
			// 
			// txt_TName
			// 
			this.txt_TName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TName.Location = new System.Drawing.Point(558, 36);
			this.txt_TName.Name = "txt_TName";
			this.txt_TName.ReadOnly = true;
			this.txt_TName.Size = new System.Drawing.Size(157, 26);
			this.txt_TName.TabIndex = 6;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label13.Location = new System.Drawing.Point(474, 43);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 5;
			this.label13.Text = "姓    名：";
			// 
			// txt_TeaCourse
			// 
			this.txt_TeaCourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TeaCourse.Location = new System.Drawing.Point(205, 171);
			this.txt_TeaCourse.Name = "txt_TeaCourse";
			this.txt_TeaCourse.Size = new System.Drawing.Size(157, 26);
			this.txt_TeaCourse.TabIndex = 12;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label14.Location = new System.Drawing.Point(121, 174);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 11;
			this.label14.Text = "所授课程：";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(121, 109);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 7;
			this.label15.Text = "所属院系：";
			// 
			// txt_TeaNumber
			// 
			this.txt_TeaNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_TeaNumber.Location = new System.Drawing.Point(205, 36);
			this.txt_TeaNumber.Name = "txt_TeaNumber";
			this.txt_TeaNumber.ReadOnly = true;
			this.txt_TeaNumber.Size = new System.Drawing.Size(157, 26);
			this.txt_TeaNumber.TabIndex = 4;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(121, 43);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 3;
			this.label16.Text = "工    号：";
			// 
			// panel_AddTeaInfo
			// 
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaCourseScore);
			this.panel_AddTeaInfo.Controls.Add(this.label24);
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaCourseRoom);
			this.panel_AddTeaInfo.Controls.Add(this.label21);
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaCourseTime);
			this.panel_AddTeaInfo.Controls.Add(this.label22);
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaPass);
			this.panel_AddTeaInfo.Controls.Add(this.label5);
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaAccount);
			this.panel_AddTeaInfo.Controls.Add(this.label17);
			this.panel_AddTeaInfo.Controls.Add(this.btn_AddTeaInfo);
			this.panel_AddTeaInfo.Controls.Add(this.cb_AddTeaCourse);
			this.panel_AddTeaInfo.Controls.Add(this.cb_AddTeaDepart);
			this.panel_AddTeaInfo.Controls.Add(this.label18);
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaName);
			this.panel_AddTeaInfo.Controls.Add(this.label19);
			this.panel_AddTeaInfo.Controls.Add(this.label20);
			this.panel_AddTeaInfo.Controls.Add(this.txt_AddTeaNumber);
			this.panel_AddTeaInfo.Controls.Add(this.txtbox4);
			this.panel_AddTeaInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_AddTeaInfo.Name = "panel_AddTeaInfo";
			this.panel_AddTeaInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_AddTeaInfo.TabIndex = 35;
			// 
			// txt_AddTeaCourseScore
			// 
			this.txt_AddTeaCourseScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaCourseScore.Location = new System.Drawing.Point(205, 332);
			this.txt_AddTeaCourseScore.Name = "txt_AddTeaCourseScore";
			this.txt_AddTeaCourseScore.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaCourseScore.TabIndex = 33;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label24.Location = new System.Drawing.Point(121, 339);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(100, 23);
			this.label24.TabIndex = 32;
			this.label24.Text = "授课学分：";
			// 
			// txt_AddTeaCourseRoom
			// 
			this.txt_AddTeaCourseRoom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaCourseRoom.Location = new System.Drawing.Point(558, 254);
			this.txt_AddTeaCourseRoom.Name = "txt_AddTeaCourseRoom";
			this.txt_AddTeaCourseRoom.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaCourseRoom.TabIndex = 31;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label21.Location = new System.Drawing.Point(474, 261);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 23);
			this.label21.TabIndex = 30;
			this.label21.Text = "授课教室：";
			// 
			// txt_AddTeaCourseTime
			// 
			this.txt_AddTeaCourseTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaCourseTime.Location = new System.Drawing.Point(205, 254);
			this.txt_AddTeaCourseTime.Name = "txt_AddTeaCourseTime";
			this.txt_AddTeaCourseTime.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaCourseTime.TabIndex = 29;
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label22.Location = new System.Drawing.Point(121, 261);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(100, 23);
			this.label22.TabIndex = 28;
			this.label22.Text = "授课时间：";
			// 
			// txt_AddTeaPass
			// 
			this.txt_AddTeaPass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaPass.Location = new System.Drawing.Point(558, 37);
			this.txt_AddTeaPass.Name = "txt_AddTeaPass";
			this.txt_AddTeaPass.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaPass.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(474, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "密    码：";
			// 
			// txt_AddTeaAccount
			// 
			this.txt_AddTeaAccount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaAccount.Location = new System.Drawing.Point(205, 37);
			this.txt_AddTeaAccount.Name = "txt_AddTeaAccount";
			this.txt_AddTeaAccount.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaAccount.TabIndex = 25;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label17.Location = new System.Drawing.Point(121, 44);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 24;
			this.label17.Text = "帐    号：";
			// 
			// btn_AddTeaInfo
			// 
			this.btn_AddTeaInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_AddTeaInfo.Location = new System.Drawing.Point(675, 362);
			this.btn_AddTeaInfo.Name = "btn_AddTeaInfo";
			this.btn_AddTeaInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_AddTeaInfo.TabIndex = 23;
			this.btn_AddTeaInfo.Text = "添  加";
			this.btn_AddTeaInfo.UseVisualStyleBackColor = true;
			this.btn_AddTeaInfo.Click += new System.EventHandler(this.Btn_AddTeaInfoClick);
			// 
			// cb_AddTeaCourse
			// 
			this.cb_AddTeaCourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddTeaCourse.FormattingEnabled = true;
			this.cb_AddTeaCourse.Location = new System.Drawing.Point(558, 181);
			this.cb_AddTeaCourse.Name = "cb_AddTeaCourse";
			this.cb_AddTeaCourse.Size = new System.Drawing.Size(205, 24);
			this.cb_AddTeaCourse.TabIndex = 22;
			// 
			// cb_AddTeaDepart
			// 
			this.cb_AddTeaDepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddTeaDepart.FormattingEnabled = true;
			this.cb_AddTeaDepart.Location = new System.Drawing.Point(205, 181);
			this.cb_AddTeaDepart.Name = "cb_AddTeaDepart";
			this.cb_AddTeaDepart.Size = new System.Drawing.Size(205, 24);
			this.cb_AddTeaDepart.TabIndex = 21;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label18.Location = new System.Drawing.Point(474, 188);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 9;
			this.label18.Text = "所授课程：";
			// 
			// txt_AddTeaName
			// 
			this.txt_AddTeaName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaName.Location = new System.Drawing.Point(558, 106);
			this.txt_AddTeaName.Name = "txt_AddTeaName";
			this.txt_AddTeaName.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaName.TabIndex = 6;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label19.Location = new System.Drawing.Point(474, 113);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 23);
			this.label19.TabIndex = 5;
			this.label19.Text = "姓    名：";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label20.Location = new System.Drawing.Point(121, 188);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 23);
			this.label20.TabIndex = 7;
			this.label20.Text = "所属院系：";
			// 
			// txt_AddTeaNumber
			// 
			this.txt_AddTeaNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddTeaNumber.Location = new System.Drawing.Point(205, 106);
			this.txt_AddTeaNumber.Name = "txt_AddTeaNumber";
			this.txt_AddTeaNumber.Size = new System.Drawing.Size(205, 26);
			this.txt_AddTeaNumber.TabIndex = 4;
			// 
			// txtbox4
			// 
			this.txtbox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtbox4.Location = new System.Drawing.Point(121, 113);
			this.txtbox4.Name = "txtbox4";
			this.txtbox4.Size = new System.Drawing.Size(100, 23);
			this.txtbox4.TabIndex = 3;
			this.txtbox4.Text = "工    号：";
			// 
			// panel_CourseInfo
			// 
			this.panel_CourseInfo.Controls.Add(this.btn_CourseNew);
			this.panel_CourseInfo.Controls.Add(this.btn_CourseLookInfo);
			this.panel_CourseInfo.Controls.Add(this.dataGv_CourseInfo);
			this.panel_CourseInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_CourseInfo.Name = "panel_CourseInfo";
			this.panel_CourseInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_CourseInfo.TabIndex = 37;
			// 
			// btn_CourseNew
			// 
			this.btn_CourseNew.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_CourseNew.Location = new System.Drawing.Point(601, 336);
			this.btn_CourseNew.Name = "btn_CourseNew";
			this.btn_CourseNew.Size = new System.Drawing.Size(88, 36);
			this.btn_CourseNew.TabIndex = 32;
			this.btn_CourseNew.Text = "刷  新";
			this.btn_CourseNew.UseVisualStyleBackColor = true;
			this.btn_CourseNew.Click += new System.EventHandler(this.Btn_CourseNewClick);
			// 
			// btn_CourseLookInfo
			// 
			this.btn_CourseLookInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_CourseLookInfo.Location = new System.Drawing.Point(759, 336);
			this.btn_CourseLookInfo.Name = "btn_CourseLookInfo";
			this.btn_CourseLookInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_CourseLookInfo.TabIndex = 31;
			this.btn_CourseLookInfo.Text = "查  看";
			this.btn_CourseLookInfo.UseVisualStyleBackColor = true;
			this.btn_CourseLookInfo.Click += new System.EventHandler(this.Btn_CourseLookInfoClick);
			// 
			// dataGv_CourseInfo
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGv_CourseInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGv_CourseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGv_CourseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn9,
									this.dataGridViewTextBoxColumn10,
									this.dataGridViewTextBoxColumn11,
									this.Column8,
									this.dataGridViewTextBoxColumn7,
									this.dataGridViewTextBoxColumn8});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGv_CourseInfo.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGv_CourseInfo.Location = new System.Drawing.Point(12, 19);
			this.dataGv_CourseInfo.Name = "dataGv_CourseInfo";
			this.dataGv_CourseInfo.RowTemplate.Height = 23;
			this.dataGv_CourseInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGv_CourseInfo.Size = new System.Drawing.Size(849, 275);
			this.dataGv_CourseInfo.TabIndex = 30;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "course_name";
			this.dataGridViewTextBoxColumn4.Frozen = true;
			this.dataGridViewTextBoxColumn4.HeaderText = "课程名称";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "course_choose";
			this.dataGridViewTextBoxColumn9.Frozen = true;
			this.dataGridViewTextBoxColumn9.HeaderText = "已选择人数";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 120;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "course_class";
			this.dataGridViewTextBoxColumn10.Frozen = true;
			this.dataGridViewTextBoxColumn10.HeaderText = "课程教室";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "course_time";
			this.dataGridViewTextBoxColumn11.Frozen = true;
			this.dataGridViewTextBoxColumn11.HeaderText = "课程时间";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 140;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "course_score";
			this.Column8.Frozen = true;
			this.Column8.HeaderText = "课程学分";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "t_name";
			this.dataGridViewTextBoxColumn7.Frozen = true;
			this.dataGridViewTextBoxColumn7.HeaderText = "授课教师";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "class_people";
			this.dataGridViewTextBoxColumn8.Frozen = true;
			this.dataGridViewTextBoxColumn8.HeaderText = "课程容量";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// panel_CourseLookInfo
			// 
			this.panel_CourseLookInfo.Controls.Add(this.btn_UpdateCourseInfo);
			this.panel_CourseLookInfo.Controls.Add(this.txt_CourseTime);
			this.panel_CourseLookInfo.Controls.Add(this.cb_CourseType);
			this.panel_CourseLookInfo.Controls.Add(this.cb_CourseRoom);
			this.panel_CourseLookInfo.Controls.Add(this.txt_CourseChoose);
			this.panel_CourseLookInfo.Controls.Add(this.label23);
			this.panel_CourseLookInfo.Controls.Add(this.btn_ReturnClassInfo);
			this.panel_CourseLookInfo.Controls.Add(this.txt_CourseInclu);
			this.panel_CourseLookInfo.Controls.Add(this.label26);
			this.panel_CourseLookInfo.Controls.Add(this.txt_CourseTea);
			this.panel_CourseLookInfo.Controls.Add(this.label27);
			this.panel_CourseLookInfo.Controls.Add(this.label28);
			this.panel_CourseLookInfo.Controls.Add(this.label29);
			this.panel_CourseLookInfo.Controls.Add(this.txt_CourseScore);
			this.panel_CourseLookInfo.Controls.Add(this.label30);
			this.panel_CourseLookInfo.Controls.Add(this.label31);
			this.panel_CourseLookInfo.Controls.Add(this.txt_CourseName);
			this.panel_CourseLookInfo.Controls.Add(this.label32);
			this.panel_CourseLookInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_CourseLookInfo.Name = "panel_CourseLookInfo";
			this.panel_CourseLookInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_CourseLookInfo.TabIndex = 38;
			// 
			// btn_UpdateCourseInfo
			// 
			this.btn_UpdateCourseInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_UpdateCourseInfo.Location = new System.Drawing.Point(474, 329);
			this.btn_UpdateCourseInfo.Name = "btn_UpdateCourseInfo";
			this.btn_UpdateCourseInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_UpdateCourseInfo.TabIndex = 25;
			this.btn_UpdateCourseInfo.Text = "修  改";
			this.btn_UpdateCourseInfo.UseVisualStyleBackColor = true;
			this.btn_UpdateCourseInfo.Click += new System.EventHandler(this.Btn_UpdateCourseInfoClick);
			// 
			// txt_CourseTime
			// 
			this.txt_CourseTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_CourseTime.Location = new System.Drawing.Point(558, 100);
			this.txt_CourseTime.Name = "txt_CourseTime";
			this.txt_CourseTime.Size = new System.Drawing.Size(157, 26);
			this.txt_CourseTime.TabIndex = 24;
			// 
			// cb_CourseType
			// 
			this.cb_CourseType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_CourseType.FormattingEnabled = true;
			this.cb_CourseType.Location = new System.Drawing.Point(558, 36);
			this.cb_CourseType.Name = "cb_CourseType";
			this.cb_CourseType.Size = new System.Drawing.Size(157, 24);
			this.cb_CourseType.TabIndex = 23;
			// 
			// cb_CourseRoom
			// 
			this.cb_CourseRoom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_CourseRoom.FormattingEnabled = true;
			this.cb_CourseRoom.Location = new System.Drawing.Point(205, 102);
			this.cb_CourseRoom.Name = "cb_CourseRoom";
			this.cb_CourseRoom.Size = new System.Drawing.Size(157, 24);
			this.cb_CourseRoom.TabIndex = 21;
			this.cb_CourseRoom.Click += new System.EventHandler(this.Cb_CourseRoomClick);
			// 
			// txt_CourseChoose
			// 
			this.txt_CourseChoose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_CourseChoose.Location = new System.Drawing.Point(558, 238);
			this.txt_CourseChoose.Name = "txt_CourseChoose";
			this.txt_CourseChoose.ReadOnly = true;
			this.txt_CourseChoose.Size = new System.Drawing.Size(157, 26);
			this.txt_CourseChoose.TabIndex = 20;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label23.Location = new System.Drawing.Point(474, 241);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(100, 23);
			this.label23.TabIndex = 19;
			this.label23.Text = "已选人数：";
			// 
			// btn_ReturnClassInfo
			// 
			this.btn_ReturnClassInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_ReturnClassInfo.Location = new System.Drawing.Point(627, 329);
			this.btn_ReturnClassInfo.Name = "btn_ReturnClassInfo";
			this.btn_ReturnClassInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_ReturnClassInfo.TabIndex = 18;
			this.btn_ReturnClassInfo.Text = "返  回";
			this.btn_ReturnClassInfo.UseVisualStyleBackColor = true;
			this.btn_ReturnClassInfo.Click += new System.EventHandler(this.Btn_ReturnClassInfoClick);
			// 
			// txt_CourseInclu
			// 
			this.txt_CourseInclu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_CourseInclu.Location = new System.Drawing.Point(205, 241);
			this.txt_CourseInclu.Name = "txt_CourseInclu";
			this.txt_CourseInclu.ReadOnly = true;
			this.txt_CourseInclu.Size = new System.Drawing.Size(157, 26);
			this.txt_CourseInclu.TabIndex = 15;
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label26.Location = new System.Drawing.Point(121, 244);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 23);
			this.label26.TabIndex = 14;
			this.label26.Text = "课程容量：";
			// 
			// txt_CourseTea
			// 
			this.txt_CourseTea.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_CourseTea.Location = new System.Drawing.Point(558, 171);
			this.txt_CourseTea.Name = "txt_CourseTea";
			this.txt_CourseTea.ReadOnly = true;
			this.txt_CourseTea.Size = new System.Drawing.Size(157, 26);
			this.txt_CourseTea.TabIndex = 13;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label27.Location = new System.Drawing.Point(474, 178);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(100, 23);
			this.label27.TabIndex = 13;
			this.label27.Text = "授课教师：";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label28.Location = new System.Drawing.Point(474, 109);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(100, 23);
			this.label28.TabIndex = 9;
			this.label28.Text = "课程时间：";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label29.Location = new System.Drawing.Point(474, 43);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(100, 23);
			this.label29.TabIndex = 5;
			this.label29.Text = "教室类型：";
			// 
			// txt_CourseScore
			// 
			this.txt_CourseScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_CourseScore.Location = new System.Drawing.Point(205, 171);
			this.txt_CourseScore.Name = "txt_CourseScore";
			this.txt_CourseScore.Size = new System.Drawing.Size(157, 26);
			this.txt_CourseScore.TabIndex = 12;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label30.Location = new System.Drawing.Point(121, 174);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(100, 23);
			this.label30.TabIndex = 11;
			this.label30.Text = "课程学分：";
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label31.Location = new System.Drawing.Point(121, 109);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 23);
			this.label31.TabIndex = 7;
			this.label31.Text = "课程教室：";
			// 
			// txt_CourseName
			// 
			this.txt_CourseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_CourseName.Location = new System.Drawing.Point(205, 36);
			this.txt_CourseName.Name = "txt_CourseName";
			this.txt_CourseName.ReadOnly = true;
			this.txt_CourseName.Size = new System.Drawing.Size(157, 26);
			this.txt_CourseName.TabIndex = 4;
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label32.Location = new System.Drawing.Point(121, 43);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(100, 23);
			this.label32.TabIndex = 3;
			this.label32.Text = "课程名称：";
			// 
			// panel_AddCourse
			// 
			this.panel_AddCourse.Controls.Add(this.txt_AddCourseTeaNumber);
			this.panel_AddCourse.Controls.Add(this.label40);
			this.panel_AddCourse.Controls.Add(this.cb_AddCourseTeaName);
			this.panel_AddCourse.Controls.Add(this.label34);
			this.panel_AddCourse.Controls.Add(this.cb_AddCourseTeaDepart);
			this.panel_AddCourse.Controls.Add(this.label25);
			this.panel_AddCourse.Controls.Add(this.txt_AddCourseTime);
			this.panel_AddCourse.Controls.Add(this.cb_AddCourseType);
			this.panel_AddCourse.Controls.Add(this.cb_AddCourseRoom);
			this.panel_AddCourse.Controls.Add(this.btn_AddCourse);
			this.panel_AddCourse.Controls.Add(this.txt_AddCourseInclu);
			this.panel_AddCourse.Controls.Add(this.label33);
			this.panel_AddCourse.Controls.Add(this.label35);
			this.panel_AddCourse.Controls.Add(this.label36);
			this.panel_AddCourse.Controls.Add(this.txt_AddCourseScore);
			this.panel_AddCourse.Controls.Add(this.label37);
			this.panel_AddCourse.Controls.Add(this.label38);
			this.panel_AddCourse.Controls.Add(this.txt_AddCourseName);
			this.panel_AddCourse.Controls.Add(this.label39);
			this.panel_AddCourse.Location = new System.Drawing.Point(0, 31);
			this.panel_AddCourse.Name = "panel_AddCourse";
			this.panel_AddCourse.Size = new System.Drawing.Size(868, 417);
			this.panel_AddCourse.TabIndex = 39;
			// 
			// txt_AddCourseTeaNumber
			// 
			this.txt_AddCourseTeaNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddCourseTeaNumber.Location = new System.Drawing.Point(205, 329);
			this.txt_AddCourseTeaNumber.Name = "txt_AddCourseTeaNumber";
			this.txt_AddCourseTeaNumber.Size = new System.Drawing.Size(157, 26);
			this.txt_AddCourseTeaNumber.TabIndex = 30;
			this.txt_AddCourseTeaNumber.Visible = false;
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label40.Location = new System.Drawing.Point(121, 332);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(100, 23);
			this.label40.TabIndex = 29;
			this.label40.Text = "教师工号：";
			this.label40.Visible = false;
			// 
			// cb_AddCourseTeaName
			// 
			this.cb_AddCourseTeaName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddCourseTeaName.FormattingEnabled = true;
			this.cb_AddCourseTeaName.Location = new System.Drawing.Point(558, 251);
			this.cb_AddCourseTeaName.Name = "cb_AddCourseTeaName";
			this.cb_AddCourseTeaName.Size = new System.Drawing.Size(157, 24);
			this.cb_AddCourseTeaName.TabIndex = 28;
			this.cb_AddCourseTeaName.Click += new System.EventHandler(this.Cb_AddCourseTeaNameClick);
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label34.Location = new System.Drawing.Point(474, 258);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(100, 23);
			this.label34.TabIndex = 27;
			this.label34.Text = "授课教师：";
			// 
			// cb_AddCourseTeaDepart
			// 
			this.cb_AddCourseTeaDepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddCourseTeaDepart.FormattingEnabled = true;
			this.cb_AddCourseTeaDepart.Location = new System.Drawing.Point(205, 251);
			this.cb_AddCourseTeaDepart.Name = "cb_AddCourseTeaDepart";
			this.cb_AddCourseTeaDepart.Size = new System.Drawing.Size(157, 24);
			this.cb_AddCourseTeaDepart.TabIndex = 26;
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label25.Location = new System.Drawing.Point(121, 258);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(100, 23);
			this.label25.TabIndex = 25;
			this.label25.Text = "教师院系：";
			// 
			// txt_AddCourseTime
			// 
			this.txt_AddCourseTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddCourseTime.Location = new System.Drawing.Point(558, 101);
			this.txt_AddCourseTime.Name = "txt_AddCourseTime";
			this.txt_AddCourseTime.Size = new System.Drawing.Size(157, 26);
			this.txt_AddCourseTime.TabIndex = 24;
			// 
			// cb_AddCourseType
			// 
			this.cb_AddCourseType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddCourseType.FormattingEnabled = true;
			this.cb_AddCourseType.Location = new System.Drawing.Point(558, 36);
			this.cb_AddCourseType.Name = "cb_AddCourseType";
			this.cb_AddCourseType.Size = new System.Drawing.Size(157, 24);
			this.cb_AddCourseType.TabIndex = 23;
			// 
			// cb_AddCourseRoom
			// 
			this.cb_AddCourseRoom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddCourseRoom.FormattingEnabled = true;
			this.cb_AddCourseRoom.Location = new System.Drawing.Point(205, 103);
			this.cb_AddCourseRoom.Name = "cb_AddCourseRoom";
			this.cb_AddCourseRoom.Size = new System.Drawing.Size(157, 24);
			this.cb_AddCourseRoom.TabIndex = 21;
			this.cb_AddCourseRoom.Click += new System.EventHandler(this.Cb_AddCourseRoomClick);
			// 
			// btn_AddCourse
			// 
			this.btn_AddCourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_AddCourse.Location = new System.Drawing.Point(627, 329);
			this.btn_AddCourse.Name = "btn_AddCourse";
			this.btn_AddCourse.Size = new System.Drawing.Size(88, 36);
			this.btn_AddCourse.TabIndex = 18;
			this.btn_AddCourse.Text = "添  加";
			this.btn_AddCourse.UseVisualStyleBackColor = true;
			this.btn_AddCourse.Click += new System.EventHandler(this.Btn_AddCourseClick);
			// 
			// txt_AddCourseInclu
			// 
			this.txt_AddCourseInclu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddCourseInclu.Location = new System.Drawing.Point(558, 175);
			this.txt_AddCourseInclu.Name = "txt_AddCourseInclu";
			this.txt_AddCourseInclu.Size = new System.Drawing.Size(157, 26);
			this.txt_AddCourseInclu.TabIndex = 15;
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label33.Location = new System.Drawing.Point(474, 178);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 23);
			this.label33.TabIndex = 14;
			this.label33.Text = "课程容量：";
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label35.Location = new System.Drawing.Point(474, 110);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(100, 23);
			this.label35.TabIndex = 9;
			this.label35.Text = "课程时间：";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label36.Location = new System.Drawing.Point(474, 43);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(100, 23);
			this.label36.TabIndex = 5;
			this.label36.Text = "教室类型：";
			// 
			// txt_AddCourseScore
			// 
			this.txt_AddCourseScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddCourseScore.Location = new System.Drawing.Point(205, 175);
			this.txt_AddCourseScore.Name = "txt_AddCourseScore";
			this.txt_AddCourseScore.Size = new System.Drawing.Size(157, 26);
			this.txt_AddCourseScore.TabIndex = 12;
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label37.Location = new System.Drawing.Point(121, 178);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(100, 23);
			this.label37.TabIndex = 11;
			this.label37.Text = "课程学分：";
			// 
			// label38
			// 
			this.label38.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label38.Location = new System.Drawing.Point(121, 110);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(100, 23);
			this.label38.TabIndex = 7;
			this.label38.Text = "课程教室：";
			// 
			// txt_AddCourseName
			// 
			this.txt_AddCourseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddCourseName.Location = new System.Drawing.Point(205, 36);
			this.txt_AddCourseName.Name = "txt_AddCourseName";
			this.txt_AddCourseName.Size = new System.Drawing.Size(157, 26);
			this.txt_AddCourseName.TabIndex = 4;
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label39.Location = new System.Drawing.Point(121, 43);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(100, 23);
			this.label39.TabIndex = 3;
			this.label39.Text = "课程名称：";
			// 
			// panel_ClassInfo
			// 
			this.panel_ClassInfo.Controls.Add(this.btn_NewClass);
			this.panel_ClassInfo.Controls.Add(this.btn_LookClassInfo);
			this.panel_ClassInfo.Controls.Add(this.toolStrip3);
			this.panel_ClassInfo.Controls.Add(this.DataGv_ClassInfo);
			this.panel_ClassInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_ClassInfo.Name = "panel_ClassInfo";
			this.panel_ClassInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_ClassInfo.TabIndex = 40;
			// 
			// btn_NewClass
			// 
			this.btn_NewClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_NewClass.Location = new System.Drawing.Point(601, 336);
			this.btn_NewClass.Name = "btn_NewClass";
			this.btn_NewClass.Size = new System.Drawing.Size(88, 36);
			this.btn_NewClass.TabIndex = 32;
			this.btn_NewClass.Text = "刷  新";
			this.btn_NewClass.UseVisualStyleBackColor = true;
			this.btn_NewClass.Click += new System.EventHandler(this.Btn_NewClassClick);
			// 
			// btn_LookClassInfo
			// 
			this.btn_LookClassInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_LookClassInfo.Location = new System.Drawing.Point(759, 336);
			this.btn_LookClassInfo.Name = "btn_LookClassInfo";
			this.btn_LookClassInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_LookClassInfo.TabIndex = 31;
			this.btn_LookClassInfo.Text = "查  看";
			this.btn_LookClassInfo.UseVisualStyleBackColor = true;
			this.btn_LookClassInfo.Click += new System.EventHandler(this.Btn_LookClassInfoClick);
			// 
			// toolStrip3
			// 
			this.toolStrip3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel8,
									this.tscb_ClassType,
									this.tsbtn_ClassTypeSearch});
			this.toolStrip3.Location = new System.Drawing.Point(0, 0);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(868, 25);
			this.toolStrip3.TabIndex = 29;
			this.toolStrip3.Text = "toolStrip3";
			// 
			// toolStripLabel8
			// 
			this.toolStripLabel8.Name = "toolStripLabel8";
			this.toolStripLabel8.Size = new System.Drawing.Size(92, 22);
			this.toolStripLabel8.Text = "教室类型查询";
			// 
			// tscb_ClassType
			// 
			this.tscb_ClassType.Name = "tscb_ClassType";
			this.tscb_ClassType.Size = new System.Drawing.Size(121, 25);
			// 
			// tsbtn_ClassTypeSearch
			// 
			this.tsbtn_ClassTypeSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_ClassTypeSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_ClassTypeSearch.Image")));
			this.tsbtn_ClassTypeSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_ClassTypeSearch.Name = "tsbtn_ClassTypeSearch";
			this.tsbtn_ClassTypeSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_ClassTypeSearch.Text = "查询";
			this.tsbtn_ClassTypeSearch.Click += new System.EventHandler(this.Tsbtn_ClassTypeSearchClick);
			// 
			// DataGv_ClassInfo
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGv_ClassInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.DataGv_ClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGv_ClassInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn12,
									this.dataGridViewTextBoxColumn13,
									this.dataGridViewTextBoxColumn14});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGv_ClassInfo.DefaultCellStyle = dataGridViewCellStyle8;
			this.DataGv_ClassInfo.Location = new System.Drawing.Point(23, 37);
			this.DataGv_ClassInfo.Name = "DataGv_ClassInfo";
			this.DataGv_ClassInfo.RowTemplate.Height = 23;
			this.DataGv_ClassInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGv_ClassInfo.Size = new System.Drawing.Size(824, 257);
			this.DataGv_ClassInfo.TabIndex = 30;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "class_number";
			this.dataGridViewTextBoxColumn12.Frozen = true;
			this.dataGridViewTextBoxColumn12.HeaderText = "教室号";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Width = 260;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "class_people";
			this.dataGridViewTextBoxColumn13.Frozen = true;
			this.dataGridViewTextBoxColumn13.HeaderText = "教室容量";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 260;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "class_type";
			this.dataGridViewTextBoxColumn14.Frozen = true;
			this.dataGridViewTextBoxColumn14.HeaderText = "教室类型";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Width = 260;
			// 
			// panel_ClassInfoLook
			// 
			this.panel_ClassInfoLook.Controls.Add(this.txt_ClassSelectNumber);
			this.panel_ClassInfoLook.Controls.Add(this.btn_UpdateClassInfo);
			this.panel_ClassInfoLook.Controls.Add(this.txt_ClassSelectTime);
			this.panel_ClassInfoLook.Controls.Add(this.cb_ClassSelectType);
			this.panel_ClassInfoLook.Controls.Add(this.btn_ReturnGvClass);
			this.panel_ClassInfoLook.Controls.Add(this.txt_ClassSelectPeople);
			this.panel_ClassInfoLook.Controls.Add(this.label42);
			this.panel_ClassInfoLook.Controls.Add(this.txt_ClassSelectTea);
			this.panel_ClassInfoLook.Controls.Add(this.label43);
			this.panel_ClassInfoLook.Controls.Add(this.label44);
			this.panel_ClassInfoLook.Controls.Add(this.label45);
			this.panel_ClassInfoLook.Controls.Add(this.label47);
			this.panel_ClassInfoLook.Controls.Add(this.txt_ClassSelectName);
			this.panel_ClassInfoLook.Controls.Add(this.label48);
			this.panel_ClassInfoLook.Location = new System.Drawing.Point(0, 31);
			this.panel_ClassInfoLook.Name = "panel_ClassInfoLook";
			this.panel_ClassInfoLook.Size = new System.Drawing.Size(868, 417);
			this.panel_ClassInfoLook.TabIndex = 41;
			// 
			// txt_ClassSelectNumber
			// 
			this.txt_ClassSelectNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_ClassSelectNumber.Location = new System.Drawing.Point(558, 60);
			this.txt_ClassSelectNumber.Name = "txt_ClassSelectNumber";
			this.txt_ClassSelectNumber.ReadOnly = true;
			this.txt_ClassSelectNumber.Size = new System.Drawing.Size(157, 26);
			this.txt_ClassSelectNumber.TabIndex = 26;
			// 
			// btn_UpdateClassInfo
			// 
			this.btn_UpdateClassInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_UpdateClassInfo.Location = new System.Drawing.Point(474, 329);
			this.btn_UpdateClassInfo.Name = "btn_UpdateClassInfo";
			this.btn_UpdateClassInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_UpdateClassInfo.TabIndex = 25;
			this.btn_UpdateClassInfo.Text = "修  改";
			this.btn_UpdateClassInfo.UseVisualStyleBackColor = true;
			this.btn_UpdateClassInfo.Click += new System.EventHandler(this.Btn_UpdateClassInfoClick);
			// 
			// txt_ClassSelectTime
			// 
			this.txt_ClassSelectTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_ClassSelectTime.Location = new System.Drawing.Point(558, 144);
			this.txt_ClassSelectTime.Name = "txt_ClassSelectTime";
			this.txt_ClassSelectTime.ReadOnly = true;
			this.txt_ClassSelectTime.Size = new System.Drawing.Size(157, 26);
			this.txt_ClassSelectTime.TabIndex = 24;
			// 
			// cb_ClassSelectType
			// 
			this.cb_ClassSelectType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_ClassSelectType.FormattingEnabled = true;
			this.cb_ClassSelectType.Location = new System.Drawing.Point(205, 60);
			this.cb_ClassSelectType.Name = "cb_ClassSelectType";
			this.cb_ClassSelectType.Size = new System.Drawing.Size(157, 24);
			this.cb_ClassSelectType.TabIndex = 23;
			// 
			// btn_ReturnGvClass
			// 
			this.btn_ReturnGvClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_ReturnGvClass.Location = new System.Drawing.Point(627, 329);
			this.btn_ReturnGvClass.Name = "btn_ReturnGvClass";
			this.btn_ReturnGvClass.Size = new System.Drawing.Size(88, 36);
			this.btn_ReturnGvClass.TabIndex = 18;
			this.btn_ReturnGvClass.Text = "返  回";
			this.btn_ReturnGvClass.UseVisualStyleBackColor = true;
			this.btn_ReturnGvClass.Click += new System.EventHandler(this.Btn_ReturnGvClassClick);
			// 
			// txt_ClassSelectPeople
			// 
			this.txt_ClassSelectPeople.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_ClassSelectPeople.Location = new System.Drawing.Point(205, 251);
			this.txt_ClassSelectPeople.Name = "txt_ClassSelectPeople";
			this.txt_ClassSelectPeople.Size = new System.Drawing.Size(157, 26);
			this.txt_ClassSelectPeople.TabIndex = 15;
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label42.Location = new System.Drawing.Point(121, 254);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(100, 23);
			this.label42.TabIndex = 14;
			this.label42.Text = "教室容量：";
			// 
			// txt_ClassSelectTea
			// 
			this.txt_ClassSelectTea.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_ClassSelectTea.Location = new System.Drawing.Point(558, 247);
			this.txt_ClassSelectTea.Name = "txt_ClassSelectTea";
			this.txt_ClassSelectTea.ReadOnly = true;
			this.txt_ClassSelectTea.Size = new System.Drawing.Size(157, 26);
			this.txt_ClassSelectTea.TabIndex = 13;
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label43.Location = new System.Drawing.Point(474, 254);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(100, 23);
			this.label43.TabIndex = 13;
			this.label43.Text = "授课教师：";
			// 
			// label44
			// 
			this.label44.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label44.Location = new System.Drawing.Point(474, 153);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(100, 23);
			this.label44.TabIndex = 9;
			this.label44.Text = "教室时间：";
			// 
			// label45
			// 
			this.label45.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label45.Location = new System.Drawing.Point(121, 67);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(100, 23);
			this.label45.TabIndex = 5;
			this.label45.Text = "教室类型：";
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label47.Location = new System.Drawing.Point(474, 67);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(100, 23);
			this.label47.TabIndex = 7;
			this.label47.Text = "教室编号：";
			// 
			// txt_ClassSelectName
			// 
			this.txt_ClassSelectName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_ClassSelectName.Location = new System.Drawing.Point(205, 146);
			this.txt_ClassSelectName.Name = "txt_ClassSelectName";
			this.txt_ClassSelectName.ReadOnly = true;
			this.txt_ClassSelectName.Size = new System.Drawing.Size(157, 26);
			this.txt_ClassSelectName.TabIndex = 4;
			// 
			// label48
			// 
			this.label48.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label48.Location = new System.Drawing.Point(121, 153);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(100, 23);
			this.label48.TabIndex = 3;
			this.label48.Text = "课程名称：";
			// 
			// panel_AddClassInfo
			// 
			this.panel_AddClassInfo.Controls.Add(this.txt_AddClassNumber);
			this.panel_AddClassInfo.Controls.Add(this.cb_AddClassType);
			this.panel_AddClassInfo.Controls.Add(this.btn_AddClass);
			this.panel_AddClassInfo.Controls.Add(this.txt_AddClassPeople);
			this.panel_AddClassInfo.Controls.Add(this.label41);
			this.panel_AddClassInfo.Controls.Add(this.label50);
			this.panel_AddClassInfo.Controls.Add(this.label51);
			this.panel_AddClassInfo.Location = new System.Drawing.Point(0, 31);
			this.panel_AddClassInfo.Name = "panel_AddClassInfo";
			this.panel_AddClassInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_AddClassInfo.TabIndex = 42;
			// 
			// txt_AddClassNumber
			// 
			this.txt_AddClassNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddClassNumber.Location = new System.Drawing.Point(558, 76);
			this.txt_AddClassNumber.Name = "txt_AddClassNumber";
			this.txt_AddClassNumber.Size = new System.Drawing.Size(157, 26);
			this.txt_AddClassNumber.TabIndex = 26;
			// 
			// cb_AddClassType
			// 
			this.cb_AddClassType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_AddClassType.FormattingEnabled = true;
			this.cb_AddClassType.Location = new System.Drawing.Point(205, 76);
			this.cb_AddClassType.Name = "cb_AddClassType";
			this.cb_AddClassType.Size = new System.Drawing.Size(157, 24);
			this.cb_AddClassType.TabIndex = 23;
			// 
			// btn_AddClass
			// 
			this.btn_AddClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_AddClass.Location = new System.Drawing.Point(627, 329);
			this.btn_AddClass.Name = "btn_AddClass";
			this.btn_AddClass.Size = new System.Drawing.Size(88, 36);
			this.btn_AddClass.TabIndex = 18;
			this.btn_AddClass.Text = "添  加";
			this.btn_AddClass.UseVisualStyleBackColor = true;
			this.btn_AddClass.Click += new System.EventHandler(this.Btn_AddClassClick);
			// 
			// txt_AddClassPeople
			// 
			this.txt_AddClassPeople.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_AddClassPeople.Location = new System.Drawing.Point(205, 219);
			this.txt_AddClassPeople.Name = "txt_AddClassPeople";
			this.txt_AddClassPeople.Size = new System.Drawing.Size(157, 26);
			this.txt_AddClassPeople.TabIndex = 15;
			// 
			// label41
			// 
			this.label41.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label41.Location = new System.Drawing.Point(121, 222);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(100, 23);
			this.label41.TabIndex = 14;
			this.label41.Text = "教室容量：";
			// 
			// label50
			// 
			this.label50.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label50.Location = new System.Drawing.Point(121, 83);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(100, 23);
			this.label50.TabIndex = 5;
			this.label50.Text = "教室类型：";
			// 
			// label51
			// 
			this.label51.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label51.Location = new System.Drawing.Point(474, 83);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(100, 23);
			this.label51.TabIndex = 7;
			this.label51.Text = "教室编号：";
			// 
			// admin_manage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 521);
			this.Controls.Add(this.panel_AddClassInfo);
			this.Controls.Add(this.panel_ClassInfoLook);
			this.Controls.Add(this.panel_ClassInfo);
			this.Controls.Add(this.panel_AddCourse);
			this.Controls.Add(this.panel_CourseLookInfo);
			this.Controls.Add(this.panel_CourseInfo);
			this.Controls.Add(this.panel_AddTeaInfo);
			this.Controls.Add(this.panel_TeaLookInfo);
			this.Controls.Add(this.panel_TeaInfo);
			this.Controls.Add(this.panel_AddStu);
			this.Controls.Add(this.panel_SelectedStuInfo);
			this.Controls.Add(this.panel_sInfo);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "admin_manage";
			this.Text = "学生选课管理";
			this.Load += new System.EventHandler(this.Admin_manageLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel_sInfo.ResumeLayout(false);
			this.panel_sInfo.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_sInfo)).EndInit();
			this.panel_SelectedStuInfo.ResumeLayout(false);
			this.panel_SelectedStuInfo.PerformLayout();
			this.panel_AddStu.ResumeLayout(false);
			this.panel_AddStu.PerformLayout();
			this.panel_TeaInfo.ResumeLayout(false);
			this.panel_TeaInfo.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGv_TeaInfo)).EndInit();
			this.panel_TeaLookInfo.ResumeLayout(false);
			this.panel_TeaLookInfo.PerformLayout();
			this.panel_AddTeaInfo.ResumeLayout(false);
			this.panel_AddTeaInfo.PerformLayout();
			this.panel_CourseInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGv_CourseInfo)).EndInit();
			this.panel_CourseLookInfo.ResumeLayout(false);
			this.panel_CourseLookInfo.PerformLayout();
			this.panel_AddCourse.ResumeLayout(false);
			this.panel_AddCourse.PerformLayout();
			this.panel_ClassInfo.ResumeLayout(false);
			this.panel_ClassInfo.PerformLayout();
			this.toolStrip3.ResumeLayout(false);
			this.toolStrip3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGv_ClassInfo)).EndInit();
			this.panel_ClassInfoLook.ResumeLayout(false);
			this.panel_ClassInfoLook.PerformLayout();
			this.panel_AddClassInfo.ResumeLayout(false);
			this.panel_AddClassInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.TextBox txt_AddClassPeople;
		private System.Windows.Forms.Button btn_AddClass;
		private System.Windows.Forms.ComboBox cb_AddClassType;
		private System.Windows.Forms.TextBox txt_AddClassNumber;
		private System.Windows.Forms.Panel panel_AddClassInfo;
		private System.Windows.Forms.TextBox txt_ClassSelectNumber;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.TextBox txt_ClassSelectName;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.TextBox txt_ClassSelectTea;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.TextBox txt_ClassSelectPeople;
		private System.Windows.Forms.Button btn_ReturnGvClass;
		private System.Windows.Forms.ComboBox cb_ClassSelectType;
		private System.Windows.Forms.TextBox txt_ClassSelectTime;
		private System.Windows.Forms.Button btn_UpdateClassInfo;
		private System.Windows.Forms.Panel panel_ClassInfoLook;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridView DataGv_ClassInfo;
		private System.Windows.Forms.ToolStripButton tsbtn_ClassTypeSearch;
		private System.Windows.Forms.ToolStripComboBox tscb_ClassType;
		private System.Windows.Forms.ToolStripLabel toolStripLabel8;
		private System.Windows.Forms.ToolStrip toolStrip3;
		private System.Windows.Forms.Button btn_LookClassInfo;
		private System.Windows.Forms.Button btn_NewClass;
		private System.Windows.Forms.Panel panel_ClassInfo;
		private System.Windows.Forms.ToolStripMenuItem 教室信息管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加教室ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 教室管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel tssl_quitlogin;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.TextBox txt_AddCourseTeaNumber;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox cb_AddCourseTeaDepart;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.ComboBox cb_AddCourseTeaName;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.TextBox txt_AddCourseName;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.TextBox txt_AddCourseScore;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox txt_AddCourseInclu;
		private System.Windows.Forms.Button btn_AddCourse;
		private System.Windows.Forms.ComboBox cb_AddCourseRoom;
		private System.Windows.Forms.ComboBox cb_AddCourseType;
		private System.Windows.Forms.TextBox txt_AddCourseTime;
		private System.Windows.Forms.Panel panel_AddCourse;
		private System.Windows.Forms.Button btn_UpdateCourseInfo;
		private System.Windows.Forms.TextBox txt_CourseTime;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox txt_CourseName;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox txt_CourseScore;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txt_CourseTea;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txt_CourseInclu;
		private System.Windows.Forms.Button btn_ReturnClassInfo;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txt_CourseChoose;
		private System.Windows.Forms.ComboBox cb_CourseRoom;
		private System.Windows.Forms.ComboBox cb_CourseType;
		private System.Windows.Forms.Panel panel_CourseLookInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.Label txtbox4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridView dataGv_CourseInfo;
		private System.Windows.Forms.Button btn_CourseLookInfo;
		private System.Windows.Forms.Button btn_CourseNew;
		private System.Windows.Forms.Panel panel_CourseInfo;
		private System.Windows.Forms.TextBox txt_AddTeaNumber;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txt_AddTeaName;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cb_AddTeaDepart;
		private System.Windows.Forms.ComboBox cb_AddTeaCourse;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txt_AddTeaAccount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_AddTeaPass;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txt_AddTeaCourseTime;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txt_AddTeaCourseRoom;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txt_AddTeaCourseScore;
		private System.Windows.Forms.Panel panel_AddTeaInfo;
		private System.Windows.Forms.Button btn_AddTeaInfo;
		private System.Windows.Forms.Button btn_UpdateTeaInfo;
		private System.Windows.Forms.TextBox txt_TeaAcademic;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_TeaNumber;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_TeaCourse;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txt_TName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txt_TeaScore;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_TeaCourseTime;
		private System.Windows.Forms.Button btn_returnTeaGvInfo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_TeaCourseClass;
		private System.Windows.Forms.ComboBox cb_TeaBeDepart;
		private System.Windows.Forms.Panel panel_TeaLookInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView DataGv_TeaInfo;
		private System.Windows.Forms.ToolStripButton tsbtn_TeaDepartSearch;
		private System.Windows.Forms.ToolStripComboBox tscbn_TeaDepart;
		private System.Windows.Forms.ToolStripLabel toolStripLabel7;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton tsbtn_TeaNameSearch;
		private System.Windows.Forms.ToolStripTextBox tstb_TeaName;
		private System.Windows.Forms.ToolStripLabel toolStripLabel6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsbtn_TeaNumberSearch;
		private System.Windows.Forms.ToolStripTextBox tstb_TeaNumber;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.Button btn_TeaLookInfo;
		private System.Windows.Forms.Button btn_TeaNew;
		private System.Windows.Forms.Panel panel_TeaInfo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_AddStuNumber;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_AddStuName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cb_AddStuDepart;
		private System.Windows.Forms.ComboBox cb_AddStuClass;
		private System.Windows.Forms.Button btn_AddStuInfo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_AddStuAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_AddStuPass;
		private System.Windows.Forms.Panel panel_AddStu;
		private System.Windows.Forms.Button btn_StuReturn;
		private System.Windows.Forms.Label lb_id;
		private System.Windows.Forms.TextBox txt_sid;
		private System.Windows.Forms.Label lb_gender;
		private System.Windows.Forms.Label lb_degree;
		private System.Windows.Forms.TextBox txt_scourse;
		private System.Windows.Forms.Label lb_name;
		private System.Windows.Forms.TextBox txt_sname;
		private System.Windows.Forms.Label lb_age;
		private System.Windows.Forms.Label lb_academic;
		private System.Windows.Forms.TextBox txt_sscore;
		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.TextBox txt_stime;
		private System.Windows.Forms.Label lb_mark;
		private System.Windows.Forms.TextBox txt_smark;
		private System.Windows.Forms.Button btn_UpdateStuInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_sroom;
		private System.Windows.Forms.ComboBox cb_sdepart;
		private System.Windows.Forms.ComboBox cb_sclass;
		private System.Windows.Forms.Panel panel_SelectedStuInfo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbtn_StuDepartSearch;
		private System.Windows.Forms.ToolStripComboBox tscb_StuDepart;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView datagv_sInfo;
		private System.Windows.Forms.ToolStripButton tsbtn_StuClassSearch;
		private System.Windows.Forms.ToolStripComboBox tscb_StuClass;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbtn_StuNameSearch;
		private System.Windows.Forms.ToolStripTextBox tstb_StuName;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbtn_StuIdSearch;
		private System.Windows.Forms.ToolStripTextBox tstb_StuNumber;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Button btn_LookStuInfo;
		private System.Windows.Forms.Button btn_StuNew;
		private System.Windows.Forms.Panel panel_sInfo;
		private System.Windows.Forms.ToolStripMenuItem 管理课程ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 教师信息管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加教师ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.ToolStripStatusLabel tsslDate;
		private System.Windows.Forms.ToolStripStatusLabel tsslTime;
		public System.Windows.Forms.ToolStripStatusLabel tsslRole;
		private System.Windows.Forms.ToolStripStatusLabel tsslUser;
		private System.Windows.Forms.StatusStrip statusStrip1;

	}
}
