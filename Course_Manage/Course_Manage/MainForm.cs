/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2004/2/6
 * 时间: 9:58
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course_Manage
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		BaseOperate baseOperate = new BaseOperate();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Bt_loginClick(object sender, System.EventArgs e)
		{
			if(userName.Text == "" || userPass.Text == "")
			{
				MessageBox.Show("账号或密码不能为空，请重新输入!");
				userName.Text = "";
				userPass.Text = "";
				userName.Focus();
			}
			else
			{
				string tid = this.userName.Text.Trim().ToString();
				if(rbTeacher.Checked)
				{
					string sql = string.Format("select count(*) from account where Id_account = '{0}' and Id_pass = '{1}' and Id_type = '{2}' ",userName.Text.Trim(),userPass.Text.Trim(),rbTeacher.Text);
					int result = baseOperate.getExecuteScalar(sql);
					if(result > 0)
					{
						this.Hide();
						teacher_manage teacherManage = new teacher_manage(tid);
						teacherManage.Show();
					}
					else
					{
						MessageBox.Show("用户名或密码错误！");
						userName.Text = "";
						userPass.Text = "";
						userName.Focus();
					}
				}
				else if(rbStudent.Checked)
				{
					string sql = string.Format("select * from account where " +
				 "Id_account = '{0}' and Id_pass = '{1}' and Id_type = '{2}' ",userName.Text.Trim(),userPass.Text.Trim(),rbStudent.Text);
					int result = baseOperate.getExecuteScalar(sql);
					if(result > 0)
					{
						this.Hide();
						student_manager studentManage = new student_manager(tid);
						studentManage.Show();
					}
					else
					{
						MessageBox.Show("用户名或密码错误！");
						userName.Text = "";
						userPass.Text = "";
						userName.Focus();
					}
				}
				else if(rbAdmin.Checked)
				{
					string sql = string.Format("select * from account where " +
				 "Id_account = '{0}' and Id_pass = '{1}' and Id_type = '{2}' ",userName.Text.Trim(),userPass.Text.Trim(),rbAdmin.Text);
					int result = baseOperate.getExecuteScalar(sql);
					if(result > 0)
					{
						this.Hide();
						admin_manage adminManage = new admin_manage(tid);
						adminManage.Show();
					}
					else
					{
						MessageBox.Show("用户名或密码错误！");
						userName.Text = "";
						userPass.Text = "";
						userName.Focus();
					}
				}
				
			}
		}
		
	}
}
