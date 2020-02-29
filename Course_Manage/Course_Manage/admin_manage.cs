/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/12/1
 * 时间: 22:15
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Course_Manage
{
	/// <summary>
	/// Description of admin_manage.
	/// </summary>
	public partial class admin_manage : Form
	{
		private string Aid;
		BaseOperate baseOperate = new BaseOperate();
		DataSet dataSet;
		DataSet dataSet1;
		SqlDataAdapter dataAdapter;
		public admin_manage(string aid)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Aid = aid;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
			this.statusStrip1.Items["tsslDate"].Text = DateTime.Now.ToLongTimeString();
		}
		
		void Admin_manageLoad(object sender, System.EventArgs e)
		{
			this.panel_AddStu.Visible = false;
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			string sql = string.Format("select * from student,departments,professionals where student.s_major = professionals.p_name and professionals.p_department = departments.d_number order by s_number asc");
			fillStuInfoDataset(sql);
			string sql1 = string.Format("select distinct d_name,p_name from departments,professionals where p_department = d_number");
			SqlDataReader dataReader = baseOperate.getreader(sql1);
			while(dataReader.Read())
			{
				tscb_StuDepart.Items.Add((string)dataReader["d_name"]);
				tscb_StuClass.Items.Add((string)dataReader["p_name"]);
			}
			dataReader.Close();
			this.statusStrip1.Items["tsslRole"].Text = "管理员";
			this.timer1.Start();
		}
		
		#region 学生信息管理
		/// <summary>
		/// 
		/// </summary>
		/// <param name="students">学生信息管理</param>
		
		void 学生信息管理ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = true;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
		}
		
		void 添加学生ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = true;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			this.txt_AddStuPass.Text = "a123456";
			StuDepartAndClass_Initial(cb_AddStuDepart,cb_AddStuClass);
		}
		
		void Btn_AddStuInfoClick(object sender, System.EventArgs e)		//添加学生
		{
			if(this.txt_AddStuAccount.Text == "" || this.txt_AddStuNumber.Text == "" || this.txt_AddStuName.Text == ""
			   || this.cb_AddStuDepart.Text == "" || this.cb_AddStuClass.Text == "")
			{
				MessageBox.Show("文本不能为空");
			}
			else if(this.txt_AddStuAccount.Text != this.txt_AddStuNumber.Text )
			{
				MessageBox.Show("账号和学号不一致");
			}
			else
			{
				string sql = string.Format(@"insert account values('{0}','{1}','{2}','学生');
					insert student(s_number,s_name,s_major) values('{3}','{4}','{5}') ",
				    this.txt_AddStuNumber.Text,this.txt_AddStuAccount.Text,this.txt_AddStuPass.Text,
				    this.txt_AddStuNumber.Text,this.txt_AddStuName.Text,this.cb_AddStuClass.Text);
				int command = baseOperate.getcommand(sql);
				if(command > 0)
				{
					MessageBox.Show("学生信息添加成功");
					DataBind_datagvStu();
					this.txt_AddStuAccount.Text = "";
					this.txt_AddStuNumber.Text = "";
					this.txt_AddStuName.Text = "";
					this.cb_AddStuDepart.Text = "";
					this.cb_AddStuClass.Text = "";
				}
				else
				{
					MessageBox.Show("学生信息添加失败");
				}
			}
		}
		
		void Cb_AddStuClassClick(object sender, System.EventArgs e)		//添加学生--按院系加载班级
		{
			StuInfoOfClassOfDepart_Choose(cb_AddStuDepart,cb_AddStuClass);
		}
		
		void fillStuInfoDataset(string sql)		//SInfo学生信息数据源重载
		{
			SqlConnection conn = baseOperate.getconnection();
			dataAdapter = new SqlDataAdapter(sql,conn);
			dataSet1 = new DataSet();
			dataAdapter.Fill(dataSet1,"SInfo");
			datagv_sInfo.DataSource = dataSet1.Tables["SInfo"];
		}
		
		void DataBind_datagvStu()		//重载学生DataGridView
        {			
			string sql = string.Format("select * from student,departments,professionals where student.s_major = professionals.p_name and professionals.p_department = departments.d_number order by s_number asc");
			fillStuInfoDataset(sql);
            this.tstb_StuNumber.Text = "";
			this.tstb_StuName.Text = "";
			this.tscb_StuDepart.Text = "";
			this.tscb_StuClass.Text = "";
            this.datagv_sInfo.DataSource = dataSet1.Tables["SInfo"];
        }
		
		void Btn_StuNewClick(object sender, System.EventArgs e)	//刷新学生DataGridView
		{
			DataBind_datagvStu();
		}
		
		void Btn_LookStuInfoClick(object sender, System.EventArgs e)	//查看选择的学生信息
		{
			this.panel_sInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_SelectedStuInfo.Visible = true;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			int index = datagv_sInfo.CurrentRow.Index;
			string SNumber = datagv_sInfo.Rows[index].Cells[0].Value.ToString();
			string Schoose = datagv_sInfo.Rows[index].Cells[3].Value.ToString();
			if(Schoose == "")
			{
				string sql = string.Format("select * from student,departments,professionals where s_number = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number order by s_number asc",SNumber);
				dataSet = baseOperate.getdataset(sql,"SelectStuInfo");
				foreach(DataRow row in dataSet.Tables["SelectStuInfo"].Rows)
				{
					this.txt_sid.Text = row["s_number"].ToString();
					this.txt_sname.Text = (string)row["s_name"];
					this.cb_sdepart.Text = (string)row["d_name"];
					this.cb_sclass.Text = (string)row["s_major"];
					this.txt_scourse.Text = "";
					this.txt_sscore.Text = "";
					this.txt_stime.Text = "";
					this.txt_sroom.Text = "";
					this.txt_smark.Text = "";
				}
				StuDepartAndClass_Initial(cb_sdepart,cb_sclass);
			}
			else
			{
				string sql1 = string.Format("select * from student,departments,professionals,courses where s_number = '{0}' and course_name = s_course and student.s_major = professionals.p_name and professionals.p_department = departments.d_number order by s_number asc",SNumber);
				dataSet = baseOperate.getdataset(sql1,"SelectStuInfo");
				foreach(DataRow row in dataSet.Tables["SelectStuInfo"].Rows)
				{
					this.txt_sid.Text = row["s_number"].ToString();
					this.txt_sname.Text = (string)row["s_name"];
					this.cb_sdepart.Text = (string)row["d_name"];
					this.cb_sclass.Text = (string)row["s_major"];
					this.txt_scourse.Text = (string)row["s_course"];
					this.txt_sscore.Text = row["course_score"].ToString();
					this.txt_stime.Text = (string)row["course_time"];
					this.txt_sroom.Text = row["course_class"].ToString();
					this.txt_smark.Text = row["s_score"].ToString();
				}
				StuDepartAndClass_Initial(cb_sdepart,cb_sclass);
			}			
		}
		
		void Cb_sclassClick(object sender, System.EventArgs e)	//按院系设置班级
		{
			StuInfoOfClassOfDepart_Choose(cb_sdepart,cb_sclass);
		}
		
		void Btn_StuReturnClick(object sender, System.EventArgs e)	//返回选择的学生信息DataGridView
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = true;
			this.txt_sid.Text = "";
			this.txt_sname.Text = "";
			this.cb_sdepart.Text = "";
			this.cb_sclass.Text = "";
			this.txt_scourse.Text = "";
			this.txt_sscore.Text = "";
			this.txt_stime.Text = "";
			this.txt_sroom.Text = "";
			this.txt_smark.Text = "";
		}
		
		void Btn_UpdateStuInfoClick(object sender, System.EventArgs e)	//修改学生院系班级信息
		{
			string sql = string.Format("update student set s_major = '{0}' where s_number = '{1}' ",this.cb_sclass.Text,this.txt_sid.Text);
			int result = baseOperate.getcommand(sql);
			if(result > 0)
			{
				MessageBox.Show("信息修改成功");
				DataBind_datagvStu();
			}
			else
			{
				MessageBox.Show("信息修改失败");
			}
		}
		
		void Tsbtn_StuIdSearchClick(object sender, System.EventArgs e)		//学生学号查询
		{
			string sql = string.Format("select * from student,professionals,departments where s_number = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number",this.tstb_StuNumber.Text);
			fillStuInfoDataset(sql);
		}
		
		void Tsbtn_StuNameSearchClick(object sender, System.EventArgs e)	//学生姓名查询
		{
			string sql = string.Format("select * from student,professionals,departments where s_name = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number",this.tstb_StuName.Text);
			fillStuInfoDataset(sql);
		}
		
		void Tsbtn_StuDepartSearchClick(object sender, System.EventArgs e)	//学生院系查询
		{
			string sql = string.Format("select * from student,professionals,departments where d_name = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number",this.tscb_StuDepart.Text);
			fillStuInfoDataset(sql);
		}
		
		void Tsbtn_StuClassSearchClick(object sender, System.EventArgs e)	//学生班级查询
		{
			if(tscb_StuDepart.Text != "")	//根据院系、班级查询学生信息
			{
				string sql = string.Format("select * from student,professionals,departments where s_major = '{0}' and d_name = '{1}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number",this.tscb_StuClass.Text,this.tscb_StuDepart.Text);
				fillStuInfoDataset(sql);
			}
			else
			{
				string sql1 = string.Format("select * from student,professionals,departments where s_major = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number",this.tscb_StuClass.Text);
				fillStuInfoDataset(sql1);
			}
		}
		
		void Tscb_StuClassClick(object sender, System.EventArgs e)		//根据院系选择班级查询
		{
			ClassOfDepart_Choose(tscb_StuDepart,tscb_StuClass);
		}
		
		void StuDepartAndClass_Initial(ComboBox sdepart,ComboBox sclass)		//传院系、班级控件调用初始化
		{
			sdepart.Items.Clear();
			string sql = string.Format("select distinct d_name,p_name from departments,professionals where p_department = d_number");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				sdepart.Items.Add((string)dataReader["d_name"]);
				sclass.Items.Add((string)dataReader["p_name"]);
			}
			dataReader.Close();
		}
		
		void ClassOfDepart_Choose(ToolStripComboBox SDepartSearch,ToolStripComboBox SClassSearch)		//传院系、班级ToolStripCombobox控件,调用根据院系选择班级查询
		{
			if(SDepartSearch.Text != "")
			{
				SClassSearch.Items.Clear();
				string sql1 = string.Format("select p_name,p_department from departments,professionals where d_name = '{0}' and p_department = d_number ",SDepartSearch.Text);
				SqlDataReader dataReader1 = baseOperate.getreader(sql1);
				while(dataReader1.Read())
				{
					SClassSearch.Items.Add((string)dataReader1["p_name"]);
				}
			}
			else
			{
				SClassSearch.Items.Clear();
				string sql = string.Format("select distinct d_name,p_name from departments,professionals where p_department = d_number");
				SqlDataReader dataReader = baseOperate.getreader(sql);
				while(dataReader.Read())
				{
					SClassSearch.Items.Add((string)dataReader["p_name"]);
				}
				dataReader.Close();
			}
		}
		
		void StuInfoOfClassOfDepart_Choose(ComboBox SDepartSearch,ComboBox SClassSearch)		//传院系、班级Combobox控件,调用根据院系选择班级查询
		{
			if(SDepartSearch.Text != "")
			{
				SClassSearch.Items.Clear();
				string sql1 = string.Format("select p_name,p_department from departments,professionals where d_name = '{0}' and p_department = d_number ",SDepartSearch.Text);
				SqlDataReader dataReader1 = baseOperate.getreader(sql1);
				while(dataReader1.Read())
				{
					SClassSearch.Items.Add((string)dataReader1["p_name"]);
				}
			}
			else
			{
				SClassSearch.Items.Clear();
				string sql = string.Format("select distinct d_name,p_name from departments,professionals where p_department = d_number");
				SqlDataReader dataReader = baseOperate.getreader(sql);
				while(dataReader.Read())
				{
					SClassSearch.Items.Add((string)dataReader["p_name"]);
				}
				dataReader.Close();
			}
		}
		
		#endregion
		
		#region 教师信息管理
		/// <summary>
		/// 
		/// </summary>
		/// <param name="teachers">教师信息管理</param>
		void 教师信息管理ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = true;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			string sql = string.Format("select * from teachers,departments,courses where t_course = course_name and t_department = d_name order by t_number asc");
			fillTeaInfoDataset(sql);
		}
		
		void Tscbn_TeaDepartClick(object sender, System.EventArgs e)	//教师DataGvInfo院系控件初始化
		{
			tscbn_TeaDepart.Items.Clear();
			string sql = string.Format("select distinct d_name from departments");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				tscbn_TeaDepart.Items.Add((string)dataReader["d_name"]);
			}
			dataReader.Close();
		}
		
		void Btn_TeaNewClick(object sender, System.EventArgs e)		//刷新
		{
			DataBind_datagvTea();
		}
		
		void Btn_TeaLookInfoClick(object sender, System.EventArgs e)	//选择教师查看信息
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = true;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			int index = DataGv_TeaInfo.CurrentRow.Index;
			string TNumber = DataGv_TeaInfo.Rows[index].Cells[0].Value.ToString();
			string sql = string.Format("select * from teachers,departments,courses where t_number = '{0}' and t_course = course_name and t_department = d_name",TNumber);
			dataSet = baseOperate.getdataset(sql,"SelectTeaInfo");
			foreach(DataRow row in dataSet.Tables["SelectTeaInfo"].Rows)
			{
				this.txt_TeaNumber.Text = row["t_number"].ToString();
				this.txt_TName.Text = (string)row["t_name"];
				this.cb_TeaBeDepart.Text = (string)row["t_department"];
				this.txt_TeaAcademic.Text = (string)row["t_academic"];
				this.txt_TeaCourse.Text = (string)row["t_course"];
				this.txt_TeaScore.Text = row["course_score"].ToString();
				this.txt_TeaCourseTime.Text = (string)row["course_time"];
				this.txt_TeaCourseClass.Text = row["course_class"].ToString();
			}
			TeaDepartAndClass_Initial(cb_TeaBeDepart);				
		}
		
		void Btn_returnTeaGvInfoClick(object sender, System.EventArgs e)	//返回选择的教师信息DataGridView
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = true;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
		}
		
		void Btn_UpdateTeaInfoClick(object sender, System.EventArgs e)	//修改教师信息
		{
			string sql = string.Format(@"update teachers set t_department = '{0}',t_academic = '{1}',t_course = '{2}' where t_number = '{3}';
				update courses set course_name = '{4}',course_class = '{5}',course_time = '{6}',course_score = '{7}' ",
			    this.cb_TeaBeDepart.Text,this.txt_TeaAcademic.Text,this.txt_TeaCourse.Text,this.txt_TeaNumber.Text,
			    this.txt_TeaCourse.Text,this.txt_TeaCourseClass.Text,this.txt_TeaCourseTime.Text,this.txt_TeaScore.Text);
			int result = baseOperate.getcommand(sql);
			if(result > 0)
			{
				MessageBox.Show("信息修改成功");
				DataBind_datagvTea();
			}
			else
			{
				MessageBox.Show("信息修改失败");
			}
		}
		
		void 添加教师ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_AddTeaInfo.Visible = true;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			TeaDepartAndClass_Initial(cb_AddTeaDepart);
			TeaCourseAndClass_Initial(cb_AddTeaCourse);
		}
			
		void Btn_AddTeaInfoClick(object sender, System.EventArgs e)		//添加教师信息
		{
			if(this.txt_AddTeaAccount.Text == "" || this.txt_AddTeaPass.Text == "" || this.txt_AddTeaNumber.Text == ""
			   || this.txt_AddTeaName.Text == "" || this.cb_AddTeaDepart.Text == "" || this.cb_AddTeaCourse.Text == ""
			   || this.txt_AddTeaCourseTime.Text == "" || this.txt_AddTeaCourseRoom.Text == "" || this.txt_AddTeaCourseScore.Text == "")
			{
				MessageBox.Show("文本不能为空");
			}
			else if(this.txt_AddTeaAccount.Text != this.txt_AddTeaPass.Text && this.txt_AddTeaAccount.Text != this.txt_AddTeaNumber.Text)
			{
				MessageBox.Show("账号或密码和工号不一致");
			}
			else
			{
				string sql = string.Format(@"insert account values('{0}','{1}','{2}','教师');
					insert teachers(t_number,t_name,t_department,t_course) values('{3}','{4}','{5}','{6}');
                    insert courses values('{7}','{8}',0,'{9}','{10}','{11}')",
				    this.txt_AddTeaNumber.Text,this.txt_AddTeaAccount.Text,this.txt_AddTeaPass.Text,
				    this.txt_AddTeaNumber.Text,this.txt_AddTeaName.Text,this.cb_AddTeaDepart.Text,this.cb_AddTeaCourse.Text,
				    this.txt_AddTeaNumber.Text,this.cb_AddTeaCourse.Text,this.txt_AddTeaCourseRoom.Text,this.txt_AddTeaCourseTime.Text,this.txt_AddTeaCourseScore.Text);
				int command = baseOperate.getcommand(sql);
				if(command > 0)
				{
					MessageBox.Show("教师信息添加成功");
					DataBind_datagvTea();
					this.txt_AddTeaAccount.Text = "";
					this.txt_AddTeaPass.Text = "";
					this.txt_AddTeaNumber.Text = "";
					this.txt_AddTeaName.Text = "";
					this.cb_AddTeaDepart.Text = "";
					this.cb_AddTeaCourse.Text = "";
					this.txt_AddTeaCourseTime.Text = "";
					this.txt_AddTeaCourseRoom.Text = "";
					this.txt_AddTeaCourseScore.Text = "";
				}
				else
				{
					MessageBox.Show("教师信息添加失败");
				}
			}
		}
		
		void fillTeaInfoDataset(string sql)		//TeaInfo教师信息数据源重载
		{
			SqlConnection conn = baseOperate.getconnection();
			dataAdapter = new SqlDataAdapter(sql,conn);
			dataSet1 = new DataSet();
			dataAdapter.Fill(dataSet1,"TeaInfo");
			DataGv_TeaInfo.DataSource = dataSet1.Tables["TeaInfo"];
		}
		
		void DataBind_datagvTea()		//重载学生DataGridView
        {			
			string sql = string.Format("select * from teachers,departments,courses where t_course = course_name and t_department = d_name order by t_number asc");
			fillTeaInfoDataset(sql);
            this.tstb_TeaNumber.Text = "";
			this.tstb_TeaName.Text = "";
			this.tscbn_TeaDepart.Text = "";
            this.DataGv_TeaInfo.DataSource = dataSet1.Tables["TeaInfo"];
        }
		
		void Tsbtn_TeaNumberSearchClick(object sender, System.EventArgs e)	//教师工号查询
		{
			string sql = string.Format("select * from teachers,departments,courses where t_number = '{0}' and t_course = course_name and t_department = d_name order by t_number asc",this.tstb_TeaNumber.Text);
			fillTeaInfoDataset(sql);
		}
		
		void Tsbtn_TeaNameSearchClick(object sender, System.EventArgs e)	//教师姓名查询
		{
			string sql = string.Format("select * from teachers,departments,courses where t_name = '{0}' and t_course = course_name and t_department = d_name order by t_number asc",this.tstb_TeaName.Text);
			fillTeaInfoDataset(sql);
		}
		
		void Tsbtn_TeaDepartSearchClick(object sender, System.EventArgs e)	//教师院系查询
		{
			string sql = string.Format("select * from teachers,departments,courses where t_department = '{0}' and t_course = course_name and t_department = d_name order by t_number asc",this.tscbn_TeaDepart.Text);
			fillTeaInfoDataset(sql);
		}
		
		void TeaDepartAndClass_Initial(ComboBox Tdepart)		//传院系控件调用初始化
		{
			Tdepart.Items.Clear();
			string sql = string.Format("select distinct d_name from departments");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				Tdepart.Items.Add((string)dataReader["d_name"]);
			}
			dataReader.Close();
		}
		
		void TeaCourseAndClass_Initial(ComboBox Tcourse)		//传课程控件调用初始化
		{
			Tcourse.Items.Clear();
			string sql = string.Format("select distinct course_name from courses");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				Tcourse.Items.Add((string)dataReader["course_name"]);
			}
			dataReader.Close();
		}
		#endregion
		
		#region 课程信息管理
		/// <summary>
		/// 
		/// </summary>
		/// <param name="courses">课程信息管理</param>
		void 管理课程ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = true;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			string sql = string.Format("select * from courses,teachers,classes where t_number = course_number and class_number = course_class order by course_name asc");
			fillCourseInfoDataset(sql);
		}
		
		void 添加课程ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_AddCourse.Visible = true;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			this.txt_AddCourseName.Text = "";
			this.cb_AddCourseType.Text = "";
			this.cb_AddCourseRoom.Text = "";
			this.txt_AddCourseTime.Text = "";
			this.txt_AddCourseScore.Text = "";
			this.txt_AddCourseInclu.Text = "";
			this.cb_AddCourseTeaDepart.Text = "";
			this.cb_AddCourseTeaName.Text = "";
			CourseAndClassType_Initial(cb_AddCourseType);
			CourseTeaDepart_Initial(cb_AddCourseTeaDepart);
		}
		
		void Cb_AddCourseRoomClick(object sender, System.EventArgs e)	//课程教室初始化
		{
			CourseInfoOfClassOfType_Choose(cb_AddCourseType,cb_AddCourseRoom);
		}
		
		void Cb_AddCourseTeaNameClick(object sender, System.EventArgs e)	//授课教师初始化
		{
			CourseTeaInfoOfDepartOfType_Choose(cb_AddCourseTeaDepart,cb_AddCourseTeaName);
		}
		
		void Btn_AddCourseClick(object sender, System.EventArgs e)	//添加课程
		{
			if(this.txt_AddCourseName.Text == "" || this.cb_AddCourseType.Text == "" || this.cb_AddCourseRoom.Text == ""
			   || this.txt_AddCourseTime.Text == "" || this.txt_AddCourseScore.Text == "" || this.txt_AddCourseInclu.Text == "")
			{
				MessageBox.Show("文本不能为空");
			}
			else
			{
				string CourseTeaName = this.cb_AddCourseTeaName.Text;
				string sql1 = string.Format("select * from teachers where t_name = '{0}' ",CourseTeaName);
				dataSet1 = baseOperate.getdataset(sql1,"CourseTeaNameInfo");
				foreach(DataRow row in dataSet1.Tables["CourseTeaNameInfo"].Rows)
				{
					this.txt_AddCourseTeaNumber.Text = row["t_number"].ToString();
				}
				string sql = string.Format(@"insert courses values('{0}','{1}',0,'{2}','{3}','{4}');
				update teachers set t_course = '{5}' where t_name = '{6}' ",this.txt_AddCourseTeaNumber.Text,this.txt_AddCourseName.Text,
				        this.cb_AddCourseRoom.Text,this.txt_AddCourseTime.Text,this.txt_AddCourseScore.Text,this.txt_AddCourseName.Text,this.cb_AddCourseTeaName.Text);
				int command = baseOperate.getcommand(sql);
				if(command > 0)
				{
					MessageBox.Show("课程信息添加成功");
					DataBind_datagvCourse();
					this.txt_AddCourseName.Text = "";
					this.cb_AddCourseType.Text = "";
					this.cb_AddCourseRoom.Text = "";
					this.txt_AddCourseTime.Text = "";
					this.txt_AddCourseScore.Text = "";
					this.txt_AddCourseInclu.Text = "";
					this.cb_AddCourseTeaDepart.Text = "";
					this.cb_AddCourseTeaName.Text = "";
				}
				else
				{
					MessageBox.Show("课程信息添加失败");
				}
			}
		}
		
		void Btn_CourseLookInfoClick(object sender, System.EventArgs e)		//查看课程信息
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = true;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			int index = dataGv_CourseInfo.CurrentRow.Index;
			string CName = dataGv_CourseInfo.Rows[index].Cells[1].Value.ToString();
			string sql = string.Format("select * from courses,teachers,classes where course_name = '{0}' and t_number = course_number and class_number = course_class",CName);
			dataSet = baseOperate.getdataset(sql,"SelectCourseInfo");
			foreach(DataRow row in dataSet.Tables["SelectCourseInfo"].Rows)
			{
				this.txt_CourseName.Text = row["course_name"].ToString();
				this.cb_CourseType.Text = (string)row["class_type"];
				this.cb_CourseRoom.Text = row["course_class"].ToString();
				this.txt_CourseTime.Text = (string)row["course_time"];
				this.txt_CourseScore.Text = row["course_score"].ToString();
				this.txt_CourseTea.Text = (string)row["t_name"];
				this.txt_CourseInclu.Text = row["class_people"].ToString();
				this.txt_CourseChoose.Text = row["course_choose"].ToString();
			}
			CourseAndClassType_Initial(cb_CourseType);
		}
		
		void Btn_CourseNewClick(object sender, System.EventArgs e)		//刷新
		{
			DataBind_datagvCourse();
		}
		
		void Btn_ReturnClassInfoClick(object sender, System.EventArgs e)	//返回课程信息
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = true;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			this.txt_CourseName.Text = "";
			this.cb_CourseType.Text = "";
			this.cb_CourseRoom.Text = "";
			this.txt_CourseTime.Text = "";
			this.txt_CourseScore.Text = "";
			this.txt_CourseTea.Text = "";
			this.txt_CourseInclu.Text = "";
			this.txt_CourseChoose.Text = "";
		}
		
		void Btn_UpdateCourseInfoClick(object sender, System.EventArgs e)	//修改课程信息
		{
			string sql = string.Format("update courses set course_class = '{0}',course_time = '{1}',course_score = '{2}' where course_name = '{3}' ",
			   	this.cb_CourseRoom.Text,this.txt_CourseTime.Text,this.txt_CourseScore.Text,this.txt_CourseName.Text);
			int result = baseOperate.getcommand(sql);
			if(result > 0)
			{
				MessageBox.Show("信息修改成功");
				DataBind_datagvCourse();
			}
			else
			{
				MessageBox.Show("信息修改失败");
			}			
		}
		
		void Cb_CourseRoomClick(object sender, System.EventArgs e)
		{
			CourseInfoOfClassOfType_Choose(cb_CourseType,cb_CourseRoom);
		}
		
		void fillCourseInfoDataset(string sql)		//CourseInfo教师信息数据源重载
		{
			SqlConnection conn = baseOperate.getconnection();
			dataAdapter = new SqlDataAdapter(sql,conn);
			dataSet1 = new DataSet();
			dataAdapter.Fill(dataSet1,"CourseInfo");
			dataGv_CourseInfo.DataSource = dataSet1.Tables["CourseInfo"];
		}
		
		void DataBind_datagvCourse()		//重载课程DataGridView
        {			
			string sql = string.Format("select * from courses,teachers,classes where course_number = t_number and class_number = course_class order by course_name asc");
			fillCourseInfoDataset(sql);
            this.dataGv_CourseInfo.DataSource = dataSet1.Tables["CourseInfo"];
        }
		
		void CourseAndClassType_Initial(ComboBox CourseType)		//传教室类型控件调用初始化
		{
			CourseType.Items.Clear();
			string sql = string.Format("select distinct class_type from classes");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				CourseType.Items.Add((string)dataReader["class_type"]);
			}
			dataReader.Close();
		}
		
		void CourseInfoOfClassOfType_Choose(ComboBox CourseTypeSearch,ComboBox CourseRoomSearch)		//传教室类型、课程教室Combobox控件,根据类型选择教室查询
		{
			if(CourseTypeSearch.Text != "")
			{
				CourseRoomSearch.Items.Clear();
				string sql1 = string.Format("select class_number from classes where class_type = '{0}' ",CourseTypeSearch.Text);
				SqlDataReader dataReader1 = baseOperate.getreader(sql1);
				while(dataReader1.Read())
				{
					CourseRoomSearch.Items.Add(dataReader1["class_number"].ToString());
				}
			}
			else
			{
				CourseRoomSearch.Items.Clear();
				string sql = string.Format("select distinct class_number from classes");
				SqlDataReader dataReader = baseOperate.getreader(sql);
				while(dataReader.Read())
				{
					CourseRoomSearch.Items.Add(dataReader["class_number"].ToString());
				}
				dataReader.Close();
			}
		}
		
		void CourseTeaDepart_Initial(ComboBox CourseTeaDepart)		//传院系类型控件调用初始化
		{
			CourseTeaDepart.Items.Clear();
			string sql = string.Format("select distinct d_name from departments");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				CourseTeaDepart.Items.Add((string)dataReader["d_name"]);
			}
			dataReader.Close();
		}
		
		void CourseTeaInfoOfDepartOfType_Choose(ComboBox CourseTeaDepartSearch,ComboBox CourseTeaSearch)		//传院系类型、授课教师Combobox控件,根据院系选择教师查询
		{
			if(CourseTeaDepartSearch.Text != "")
			{
				CourseTeaSearch.Items.Clear();
				string sql1 = string.Format("select t_name from teachers where t_department = '{0}' and t_course is null ",CourseTeaDepartSearch.Text);
				SqlDataReader dataReader1 = baseOperate.getreader(sql1);
				while(dataReader1.Read())
				{
					CourseTeaSearch.Items.Add(dataReader1["t_name"].ToString());
				}
			}
			else
			{
				CourseTeaSearch.Items.Clear();
				string sql = string.Format("select distinct t_name from teachers where t_course is null ");
				SqlDataReader dataReader = baseOperate.getreader(sql);
				while(dataReader.Read())
				{
					CourseTeaSearch.Items.Add(dataReader["t_name"].ToString());
				}
				dataReader.Close();
			}
		}
		
		#endregion
		
		#region 教室信息管理
		/// <summary>
		/// 
		/// </summary>
		/// <param name="courses">教室信息管理</param>
		void 教室信息管理ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_ClassInfo.Visible = true;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			string sql = string.Format("select * from classes order by class_number asc");
			fillClassInfoDataset(sql);
			ClassType_Initial(tscb_ClassType);
		}
		
		void 添加教室ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = true;
			ClassTypeCombox_Initial(cb_AddClassType);
		}
		
		void Btn_AddClassClick(object sender, System.EventArgs e)	//添加教室
		{
			if(this.cb_AddClassType.Text == "" || this.txt_AddClassNumber.Text == "" || this.txt_AddClassPeople.Text == "")
			{
				MessageBox.Show("文本不能为空");
			}
			else
			{
				string sql = string.Format(@"insert classes values('{0}','{1}','{2}')",this.txt_AddClassNumber.Text,this.txt_AddClassPeople.Text,this.cb_AddClassType.Text);
				int command = baseOperate.getcommand(sql);
				if(command > 0)
				{
					MessageBox.Show("教室添加成功");
					DataBind_datagvClass();
					this.cb_AddClassType.Text = "";
					this.txt_AddClassNumber.Text = "";
					this.txt_AddClassPeople.Text = "";
				}
				else
				{
					MessageBox.Show("教室添加失败");
				}
			}
		}
		
		void Tsbtn_ClassTypeSearchClick(object sender, System.EventArgs e)	//根据教室类型查询教室信息
		{
			string sql = string.Format("select * from classes where class_type = '{0}' order by class_number asc",this.tscb_ClassType.Text);
			fillClassInfoDataset(sql);
		}
		
		void Btn_NewClassClick(object sender, System.EventArgs e)	//刷新
		{
			DataBind_datagvClass();
		}
		
		void Btn_LookClassInfoClick(object sender, System.EventArgs e)		//查看教室信息
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_ClassInfo.Visible = false;
			this.panel_ClassInfoLook.Visible = true;
			this.panel_AddClassInfo.Visible = false;
			int index = DataGv_ClassInfo.CurrentRow.Index;
			string ClassNumber = DataGv_ClassInfo.Rows[index].Cells[0].Value.ToString();
			string sql = string.Format("select count(*) from classes,courses,teachers where class_number = course_class and class_number = '{0}' and t_number = course_number",ClassNumber);
			int result = baseOperate.getExecuteScalar(sql);
			if(result > 0)
			{
				string sql1 = string.Format("select * from classes,courses,teachers where class_number = course_class and class_number = '{0}' and t_number = course_number",ClassNumber);
				dataSet = baseOperate.getdataset(sql1,"SelectClassInfo");
				foreach(DataRow row in dataSet.Tables["SelectClassInfo"].Rows)
				{
					this.cb_ClassSelectType.Text = (string)row["class_type"];
					this.txt_ClassSelectNumber.Text = row["class_number"].ToString();
					this.txt_ClassSelectName.Text = row["course_name"].ToString();
					this.txt_ClassSelectTime.Text = (string)row["course_time"];
					this.txt_ClassSelectPeople.Text = row["class_people"].ToString();
					this.txt_ClassSelectTea.Text = (string)row["t_name"];
				}
				ClassTypeCombox_Initial(cb_ClassSelectType);
			}
			else
			{
				string sql2 = string.Format("select * from classes where class_number = '{0}' ",ClassNumber);
				dataSet = baseOperate.getdataset(sql2,"SelectClassInfo");
				foreach(DataRow row in dataSet.Tables["SelectClassInfo"].Rows)
				{
					this.cb_ClassSelectType.Text = (string)row["class_type"];
					this.txt_ClassSelectNumber.Text = row["class_number"].ToString();
					this.txt_ClassSelectName.Text = "";
					this.txt_ClassSelectTime.Text = "";
					this.txt_ClassSelectPeople.Text = row["class_people"].ToString();
					this.txt_ClassSelectTea.Text = "";
				}
				ClassTypeCombox_Initial(cb_ClassSelectType);
			}
		}
		
		void Btn_ReturnGvClassClick(object sender, System.EventArgs e)	//返回教室信息
		{
			this.panel_SelectedStuInfo.Visible = false;
			this.panel_sInfo.Visible = false;
			this.panel_AddStu.Visible = false;
			this.panel_TeaInfo.Visible = false;
			this.panel_TeaLookInfo.Visible = false;
			this.panel_CourseInfo.Visible = false;
			this.panel_CourseLookInfo.Visible = false;
			this.panel_ClassInfo.Visible = true;
			this.panel_ClassInfoLook.Visible = false;
			this.panel_AddClassInfo.Visible = false;
			DataBind_datagvClass();
		}
		
		void Btn_UpdateClassInfoClick(object sender, System.EventArgs e)	//修改教室信息
		{
			string sql = string.Format("update classes set class_type = '{0}',class_people = '{1}' where class_number = '{2}' ",
			   	this.cb_ClassSelectType.Text,this.txt_ClassSelectPeople.Text,this.txt_ClassSelectNumber.Text);
			int result = baseOperate.getcommand(sql);
			if(result > 0)
			{
				MessageBox.Show("信息修改成功");
				DataBind_datagvClass();
			}
			else
			{
				MessageBox.Show("信息修改失败");
			}	
		}
		
		void fillClassInfoDataset(string sql)		//ClassInfo教室信息数据源重载
		{
			SqlConnection conn = baseOperate.getconnection();
			dataAdapter = new SqlDataAdapter(sql,conn);
			dataSet1 = new DataSet();
			dataAdapter.Fill(dataSet1,"ClassInfo");
			DataGv_ClassInfo.DataSource = dataSet1.Tables["ClassInfo"];
		}
		
		void DataBind_datagvClass()		//重载教室DataGridView
        {			
			string sql = string.Format("select * from classes order by class_number asc");
			fillClassInfoDataset(sql);
            this.DataGv_ClassInfo.DataSource = dataSet1.Tables["ClassInfo"];
        }
		
		void ClassType_Initial(ToolStripComboBox CourseType)		//传教室类型控件调用初始化
		{
			CourseType.Items.Clear();
			string sql = string.Format("select distinct class_type from classes");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				CourseType.Items.Add((string)dataReader["class_type"]);
			}
			dataReader.Close();
		}
		
		void ClassTypeCombox_Initial(ComboBox CourseType)		//传Combox教室类型控件调用初始化
		{
			CourseType.Items.Clear();
			string sql = string.Format("select distinct class_type from classes");
			SqlDataReader dataReader = baseOperate.getreader(sql);
			while(dataReader.Read())
			{
				CourseType.Items.Add((string)dataReader["class_type"]);
			}
			dataReader.Close();
		}
		
		#endregion
		
		void Tssl_quitloginClick(object sender, System.EventArgs e)		//退出登录
		{
			this.Close();
			MainForm mainform = new MainForm();
			mainform.Show();
		}
	}
}
