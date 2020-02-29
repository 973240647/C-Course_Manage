/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2004/2/6
 * 时间: 11:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Course_Manage
{
	/// <summary>
	/// Description of Students.
	/// </summary>
	public class Students
	{
		private string sPass;
		
		public string SPass {
			get { return sPass; }
			set { sPass = value; }
		}
		
		private string sNumber;
		
		public string SNumber {
			get { return sNumber; }
			set { sNumber = value; }
		}
		
		private string sName;
		
		public string SName {
			get { return sName; }
			set { sName = value; }
		}
		
		private string sMajor;
		
		public string SMajor {
			get { return sMajor; }
			set { sMajor = value; }
		}
		
		private string sCourse;
		
		public string SCourse {
			get { return sCourse; }
			set { sCourse = value; }
		}
		
		private string sScore;
		
		public string SScore {
			get { return sScore; }
			set { sScore = value; }
		}
		
		public Students(string number,string name,string major,string course,string score)
		{
			this.SNumber = number;
			this.SName = name;
			this.SMajor = major;
			this.SCourse = course;
			this.SScore = score;
		}
		
		public Students(string pass)
		{
			this.SPass = pass;
		}
	}
}
