/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2004/2/6
 * 时间: 11:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Course_Manage
{
	/// <summary>
	/// Description of Teachers.
	/// </summary>
	public class Teachers
	{
		private string tId;
		
		public string TId {
			get { return tId; }
			set { tId = value; }
		}		
		
		private string tPass;
		
		public string TPass {
			get { return tPass; }
			set { tPass = value; }
		}
		
		private string tNumber;
		
		public string TNumber {
			get { return tNumber; }
			set { tNumber = value; }
		}
		
		private string tName;
		
		public string TName {
			get { return tName; }
			set { tName = value; }
		}
		
		private string tGender;
		
		public string TGender {
			get { return tGender; }
			set { tGender = value; }
		}
		
		private string tAge;
		
		public string TAge {
			get { return tAge; }
			set { tAge = value; }
		}
		
		private string tDegree;
		
		public string TDegree {
			get { return tDegree; }
			set { tDegree = value; }
		}
		
		private string tAcademic;
		
		public string TAcademic {
			get { return tAcademic; }
			set { tAcademic = value; }
		}
		
		private string tDepartment;
		
		public string TDepartment {
			get { return tDepartment; }
			set { tDepartment = value; }
		}
		
		
		private string tHealth;
		
		public string THealth {
			get { return tHealth; }
			set { tHealth = value; }
		}
		
		private string tCourse;
		
		public string TCourse {
			get { return tCourse; }
			set { tCourse = value; }
		}
		
		public Teachers(string number,string name,string gender,string age,string degree,string academic,string depart,string health)
		{
			this.TNumber = number;
			this.TName = name;
			this.TGender = gender;
			this.TAge = age;
			this.TDegree = degree;
			this.TAcademic = academic;
			this.TDepartment = depart;
			this.THealth = health;
		}
		
		public Teachers(string tid,string pass)
		{
			this.TId = tid;
			this.TPass = pass;
		}
	}
}
