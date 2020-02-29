/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/11/26
 * 时间: 22:58
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Course_Manage
{
	/// <summary>
	/// Description of teacher_manage.
	/// </summary>
	public partial class teacher_manage : Form
	{
		private string Tid;
		BaseOperate baseOperate = new BaseOperate();
		DataSet dataSet1;
		DataSet dataSet;
		SqlDataAdapter dataAdapter;
		public teacher_manage(string tid)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Tid = tid;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void Timer1Tick(object sender, System.EventArgs e)
		{
			this.statusStrip1.Items["tsslDate"].Text = DateTime.Now.ToLongTimeString();
		}
		
		void Teacher_manageLoad(object sender, System.EventArgs e)
		{
			this.panel_score.Visible = false;
			this.panel_course.Visible = false;
			getteacherInfo();
			this.statusStrip1.Items["tsslRole"].Text = dataSet.Tables["Teachers"].Rows[0]["t_name"].ToString()+"教师";
			this.timer1.Start();
		}
		
		void 个人信息ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_score.Visible = false;
			this.panel_course.Visible = false;
			this.panel_info.Visible = true;	
		}
		
		void Btn_updataTInfoClick(object sender, System.EventArgs e)
		{
			string sql = string.Format("update teachers set t_name = '{0}',t_gender = '{1}',t_age = '{2}',t_health = '{3}' ",
			                          this.txt_tname.Text,this.txt_tgender.Text,this.txt_tage.Text,this.txt_thealth.Text);
			int result = baseOperate.getcommand(sql);
			if(result > 0)	MessageBox.Show("修改成功");
			DataBind_teacherInfo();
		}
		
		void 课程管理ToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panel_score.Visible = false;
			this.panel_course.Visible = true;
			this.panel_info.Visible = false;
			getCourse();
		}
		
		void 成绩管理ToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			this.panel_info.Visible = false;
			this.panel_score.Visible = true;
			this.panel_course.Visible = false;
			getCourse();	
			string sql = string.Format("select * from student where s_course = '{0}' ",this.txt_Tcourse.Text);			
			fillDataset(sql);
			string sql1 = string.Format("select distinct s_major from student where s_course = '{0}' ",this.txt_Tcourse.Text);
			SqlDataReader dataReader = baseOperate.getreader(sql1);
			while(dataReader.Read())
			{
				tstb_class.Items.Add((string)dataReader["s_major"]);
			}
			dataReader.Close();
		}
		
		void fillDataset(string sql)		//Tscore数据源重载
		{
			SqlConnection conn = baseOperate.getconnection();
			dataAdapter = new SqlDataAdapter(sql,conn);
			dataSet1 = new DataSet();
			dataAdapter.Fill(dataSet1,"Tscore");
			datagv_score.DataSource = dataSet1.Tables["Tscore"];
		}
		
		void Btn_datagvOkClick(object sender, System.EventArgs e)	//修改学生成绩
		{
			SqlConnection conn = baseOperate.getconnection();
			DialogResult result = MessageBox.Show("确实要将修改保存到数据库吗？","操作提示",
                                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
			try{
                conn.Open();
                if(result == DialogResult.OK)
                {
					SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
					dataAdapter.Update(dataSet1,"Tscore");
                    MessageBox.Show("更新成功");
                }
                DataBind_datagv();
            }
            catch(Exception exp)
            {
                MessageBox.Show("更新失败");
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                conn.Close();
            }

		}
		
		void getteacherInfo()		//获取教师信息
		{
			string sql = string.Format("select * from teachers where t_number = '{0}' ",Tid);
			dataSet = baseOperate.getdataset(sql,"Teachers");
			foreach(DataRow row in dataSet.Tables["Teachers"].Rows)
			{
				this.txt_tid.Text = row["t_number"].ToString();
				this.txt_tname.Text = (string)row["t_name"];
				this.txt_tgender.Text = (string)row["t_gender"];
				this.txt_tage.Text = row["t_age"].ToString();
				this.txt_tdegree.Text = (string)row["t_degree"];
				this.txt_tacademic.Text = (string)row["t_academic"];
				this.txt_tdepartment.Text = (string)row["t_department"];
				this.txt_thealth.Text = (string)row["t_health"];
			}
		}
		
		void getCourse()		//获取课程信息
		{
			string sql = string.Format("select * from courses where course_number = '{0}' ",Tid);
			DataSet dataSet = baseOperate.getdataset(sql,"Tcourses");
			foreach(DataRow row in dataSet.Tables["Tcourses"].Rows)
			{
				this.txt_Tcourse.Text = (string)row["course_name"];
				this.txt_Cclass.Text = row["course_class"].ToString();
				this.txt_Ctime.Text = (string)row["course_time"];
				this.txt_Cscore.Text = row["course_score"].ToString();
			}
		}
		
		void DataBind_teacherInfo()		//重载教师个人信息
        {
            SqlConnection conn = baseOperate.getconnection();
            
            try{
                conn.Open();
                getteacherInfo();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }
		
		void DataBind_datagv()		//重载DataGridView
        {	
			string sql = string.Format("select * from student where s_course = '{0}' ",this.txt_Tcourse.Text);						
            fillDataset(sql);
            this.tstb_number.Text = "";
			this.tstb_name.Text = "";
			this.tstb_class.Text = "";
        }
		
		void Btn_newClick(object sender, System.EventArgs e)	//刷新
		{
			DataBind_datagv();
		}
		
		void Tsbtn_idsearchClick(object sender, System.EventArgs e)		//学号查询
		{
			string sql = string.Format("select * from student where s_number = '{0}' ",this.tstb_number.Text);
			fillDataset(sql);
		}
		
		void Tsbtn_namesearchClick(object sender, System.EventArgs e)	//姓名查询
		{
			string sql = string.Format("select * from student where s_name = '{0}' ",this.tstb_name.Text);
			fillDataset(sql);
		}

		void Tsbtn_classsearchClick(object sender, System.EventArgs e)	//班级查询
		{
			string sql = string.Format("select * from student where s_major = '{0}' and s_course = '{1}' ",this.tstb_class.Text,this.txt_Tcourse.Text);
			fillDataset(sql);
		}
		
		void Tssl_quitloginClick(object sender, System.EventArgs e)		//退出登录
		{
			this.Close();
			MainForm mainform = new MainForm();
			mainform.Show();
		}
	}
}
