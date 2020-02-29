/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/12/1
 * 时间: 20:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Course_Manage
{
	partial class Form1
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
			this.panel_SelectedStuInfo = new System.Windows.Forms.Panel();
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
			this.panel_SelectedStuInfo.SuspendLayout();
			this.panel_CourseLookInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_SelectedStuInfo
			// 
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
			this.panel_SelectedStuInfo.Location = new System.Drawing.Point(12, 48);
			this.panel_SelectedStuInfo.Name = "panel_SelectedStuInfo";
			this.panel_SelectedStuInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_SelectedStuInfo.TabIndex = 31;
			// 
			// cb_sclass
			// 
			this.cb_sclass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_sclass.FormattingEnabled = true;
			this.cb_sclass.Location = new System.Drawing.Point(558, 102);
			this.cb_sclass.Name = "cb_sclass";
			this.cb_sclass.Size = new System.Drawing.Size(157, 24);
			this.cb_sclass.TabIndex = 22;
			// 
			// cb_sdepart
			// 
			this.cb_sdepart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_sdepart.FormattingEnabled = true;
			this.cb_sdepart.Location = new System.Drawing.Point(205, 102);
			this.cb_sdepart.Name = "cb_sdepart";
			this.cb_sdepart.Size = new System.Drawing.Size(157, 24);
			this.cb_sdepart.TabIndex = 21;
			// 
			// txt_sroom
			// 
			this.txt_sroom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_sroom.Location = new System.Drawing.Point(558, 238);
			this.txt_sroom.Name = "txt_sroom";
			this.txt_sroom.ReadOnly = true;
			this.txt_sroom.Size = new System.Drawing.Size(157, 26);
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
			this.btn_UpdateStuInfo.Location = new System.Drawing.Point(627, 359);
			this.btn_UpdateStuInfo.Name = "btn_UpdateStuInfo";
			this.btn_UpdateStuInfo.Size = new System.Drawing.Size(88, 36);
			this.btn_UpdateStuInfo.TabIndex = 18;
			this.btn_UpdateStuInfo.Text = "修  改";
			this.btn_UpdateStuInfo.UseVisualStyleBackColor = true;
			// 
			// txt_smark
			// 
			this.txt_smark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txt_smark.Location = new System.Drawing.Point(205, 308);
			this.txt_smark.Name = "txt_smark";
			this.txt_smark.ReadOnly = true;
			this.txt_smark.Size = new System.Drawing.Size(157, 26);
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
			this.txt_stime.Size = new System.Drawing.Size(157, 26);
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
			this.txt_sscore.Size = new System.Drawing.Size(157, 26);
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
			this.txt_sname.Size = new System.Drawing.Size(157, 26);
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
			this.txt_scourse.Size = new System.Drawing.Size(157, 26);
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
			this.txt_sid.Size = new System.Drawing.Size(157, 26);
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
			this.panel_CourseLookInfo.Location = new System.Drawing.Point(15, 26);
			this.panel_CourseLookInfo.Name = "panel_CourseLookInfo";
			this.panel_CourseLookInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_CourseLookInfo.TabIndex = 39;
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 480);
			this.Controls.Add(this.panel_CourseLookInfo);
			this.Controls.Add(this.panel_SelectedStuInfo);
			this.Name = "Form1";
			this.Text = "Info";
			this.panel_SelectedStuInfo.ResumeLayout(false);
			this.panel_SelectedStuInfo.PerformLayout();
			this.panel_CourseLookInfo.ResumeLayout(false);
			this.panel_CourseLookInfo.PerformLayout();
			this.ResumeLayout(false);
		}
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
		private System.Windows.Forms.TextBox txt_CourseTime;
		private System.Windows.Forms.Button btn_UpdateCourseInfo;
		private System.Windows.Forms.Panel panel_CourseLookInfo;
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
	}
}
