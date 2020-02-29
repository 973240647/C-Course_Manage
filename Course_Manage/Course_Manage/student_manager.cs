/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/12/1
 * 时间: 16:28
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
	/// Description of student_manager.
	/// </summary>
	public partial class student_manager : Form
	{
		BaseOperate baseOperate = new BaseOperate();
		private string Sid;
		DataSet dataSet;
		DataSet dataSet1;
		SqlDataAdapter dataAdapter;
		public student_manager(string sid)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Sid = sid;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
			this.statusStrip1.Items["tsslDate"].Text = DateTime.Now.ToLongTimeString();
		}
		
		void Student_managerLoad(object sender, System.EventArgs e)
		{
			this.panel_course.Visible = false;
			getstudentInfo();
			this.statusStrip1.Items["tsslRole"].Text = dataSet.Tables["Students"].Rows[0]["s_name"].ToString()+"学生";
			this.timer1.Start();
		}
		
		void 个人信息ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_info.Visible = true;
			this.panel_course.Visible = false;
		}
		
		void 课程管理ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_info.Visible = false;
			this.panel_course.Visible = true;
			fillDataset();
			datagv_course.DataSource = dataSet1.Tables["Tcourses"];
		}
		
		void getstudentInfo()		//获取学生信息
		{
			string sql = string.Format("select count(*) from student,departments,professionals,courses where s_number = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number and courses.course_name = student.s_course",Sid);
			int result = baseOperate.getExecuteScalar(sql);
			if(result > 0 )
			{
				string sql1 = string.Format("select * from student,departments,professionals,courses where s_number = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number and courses.course_name = student.s_course",Sid);
				dataSet = baseOperate.getdataset(sql1,"Students");
				foreach(DataRow row in dataSet.Tables["Students"].Rows)
				{
					this.txt_sid.Text = row["s_number"].ToString();
					this.txt_sname.Text = (string)row["s_name"];
					this.txt_sdepart.Text = (string)row["d_name"];
					this.txt_sclass.Text = (string)row["s_major"];
					this.txt_scourse.Text = (string)row["s_course"];
					this.txt_sscore.Text = row["course_score"].ToString();
					this.txt_sroom.Text = row["course_class"].ToString();
					this.txt_stime.Text = row["s_score"].ToString();
				}
			}
			else
			{
				string sql2 = string.Format("select * from student,departments,professionals,courses where s_number = '{0}' and student.s_major = professionals.p_name and professionals.p_department = departments.d_number",Sid);
				dataSet = baseOperate.getdataset(sql2,"Students");
				foreach(DataRow row in dataSet.Tables["Students"].Rows)
				{
					this.txt_sid.Text = row["s_number"].ToString();
					this.txt_sname.Text = (string)row["s_name"];
					this.txt_sdepart.Text = (string)row["d_name"];
					this.txt_sclass.Text = (string)row["s_major"];
				}
			}
			
		}
		
		void fillDataset()		//Tscore数据源重载
		{
			string sql = string.Format("select * from courses,teachers,classes where course_name = t_course and course_class = class_number");
			SqlConnection conn = baseOperate.getconnection();
			dataAdapter = new SqlDataAdapter(sql,conn);
			dataSet1 = new DataSet();
			dataAdapter.Fill(dataSet1,"Tcourses");
		}
		
		void DataBind_datagv()		//重载DataGridView
        {			
            fillDataset();
            this.datagv_course.DataSource = dataSet1.Tables["Tcourses"];
        }
		
		void Btn_newClick(object sender, System.EventArgs e)		//刷新
		{
			DataBind_datagv();
		}
		
		void Btn_chooseCourseClick(object sender, System.EventArgs e)
		{
			string sql = string.Format("select count(*) from student where s_number = '{0}' and s_course = '{1}' ",Sid,this.txt_scourse.Text);
			int result = baseOperate.getExecuteScalar(sql);
			if(result > 0)	MessageBox.Show("您已选择课程");
			else
			{
				int index = datagv_course.CurrentRow.Index;
				int room = Convert.ToInt32(datagv_course.Rows[index].Cells[16].Value.ToString());
				int people = Convert.ToInt32(datagv_course.Rows[index].Cells[2].Value.ToString());
					
				if(people >= room)
					MessageBox.Show("该课程选修人数已满，请选择其他课程");
				else
				{
					this.txt_scourse.Text = datagv_course.Rows[index].Cells[1].Value.ToString();
					this.txt_sscore.Text = datagv_course.Rows[index].Cells[5].Value.ToString();
					this.txt_sroom.Text = datagv_course.Rows[index].Cells[3].Value.ToString();
					this.txt_stime.Text = datagv_course.Rows[index].Cells[4].Value.ToString();
					string sql2 = string.Format("update student set s_course = '{0}',s_score = '0' where s_number = '{1}' ",this.txt_scourse.Text,Sid);
					int query = baseOperate.getcommand(sql2);
					if(query > 0)
					{
						string sql3 = string.Format("update courses set course_choose = course_choose + 1 where course_class = '{0}' ",this.txt_sroom.Text);
						int dechoose = baseOperate.getcommand(sql3);
						MessageBox.Show("选择课程成功");
						this.panel_course.Visible = false;
						this.panel_info.Visible = true;
					}
					else
					{
						MessageBox.Show("选择课程失败");
						this.txt_scourse.Text = "";
						this.txt_sscore.Text = "";
						this.txt_sroom.Text = "";
						this.txt_stime.Text = "";
					}
				}
			}
			
		}
		
		void Btn_quitChooseClick(object sender, System.EventArgs e)
		{
			string sql = string.Format("update student set s_course = NULL,s_score = '' where s_number = '{0}' ",Sid);
			int query = baseOperate.getcommand(sql);
			if(query > 0)
			{
				MessageBox.Show("退选课程成功");
				string sql1 = string.Format("update courses set course_choose = course_choose - 1 where course_class = '{0}' ",this.txt_sroom.Text);
				int rechoose = baseOperate.getcommand(sql1);
				this.txt_scourse.Text = "";
				this.txt_sscore.Text = "";
				this.txt_sroom.Text = "";
				this.txt_stime.Text = "";
			}
			else	MessageBox.Show("选择课程失败");
		}
		
		void Tssl_quitloginClick(object sender, System.EventArgs e)		//退出登录
		{
			this.Close();
			MainForm mainform = new MainForm();
			mainform.Show();
		}
		
	}
}
