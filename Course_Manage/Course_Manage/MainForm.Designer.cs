/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2004/2/6
 * 时间: 9:58
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Course_Manage
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rbTeacher = new System.Windows.Forms.RadioButton();
			this.rbStudent = new System.Windows.Forms.RadioButton();
			this.rbAdmin = new System.Windows.Forms.RadioButton();
			this.userName = new System.Windows.Forms.TextBox();
			this.userPass = new System.Windows.Forms.TextBox();
			this.bt_login = new System.Windows.Forms.Button();
			this.bt_again = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(176, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名：";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(176, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "密  码：";
			// 
			// rbTeacher
			// 
			this.rbTeacher.BackColor = System.Drawing.Color.Transparent;
			this.rbTeacher.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rbTeacher.Location = new System.Drawing.Point(176, 224);
			this.rbTeacher.Name = "rbTeacher";
			this.rbTeacher.Size = new System.Drawing.Size(104, 24);
			this.rbTeacher.TabIndex = 3;
			this.rbTeacher.Text = "教师";
			this.rbTeacher.UseVisualStyleBackColor = false;
			// 
			// rbStudent
			// 
			this.rbStudent.BackColor = System.Drawing.Color.Transparent;
			this.rbStudent.Checked = true;
			this.rbStudent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rbStudent.Location = new System.Drawing.Point(251, 224);
			this.rbStudent.Name = "rbStudent";
			this.rbStudent.Size = new System.Drawing.Size(104, 24);
			this.rbStudent.TabIndex = 3;
			this.rbStudent.TabStop = true;
			this.rbStudent.Text = "学生";
			this.rbStudent.UseVisualStyleBackColor = false;
			// 
			// rbAdmin
			// 
			this.rbAdmin.BackColor = System.Drawing.Color.Transparent;
			this.rbAdmin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rbAdmin.Location = new System.Drawing.Point(323, 224);
			this.rbAdmin.Name = "rbAdmin";
			this.rbAdmin.Size = new System.Drawing.Size(104, 24);
			this.rbAdmin.TabIndex = 4;
			this.rbAdmin.Text = "管理员";
			this.rbAdmin.UseVisualStyleBackColor = false;
			// 
			// userName
			// 
			this.userName.BackColor = System.Drawing.Color.PowderBlue;
			this.userName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.userName.Location = new System.Drawing.Point(239, 115);
			this.userName.Multiline = true;
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(154, 29);
			this.userName.TabIndex = 1;
			// 
			// userPass
			// 
			this.userPass.BackColor = System.Drawing.Color.PowderBlue;
			this.userPass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userPass.Location = new System.Drawing.Point(239, 164);
			this.userPass.Multiline = true;
			this.userPass.Name = "userPass";
			this.userPass.PasswordChar = '*';
			this.userPass.Size = new System.Drawing.Size(154, 29);
			this.userPass.TabIndex = 2;
			// 
			// bt_login
			// 
			this.bt_login.BackColor = System.Drawing.Color.Khaki;
			this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_login.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.bt_login.Location = new System.Drawing.Point(176, 274);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(81, 31);
			this.bt_login.TabIndex = 5;
			this.bt_login.Text = "登录";
			this.bt_login.UseVisualStyleBackColor = false;
			this.bt_login.Click += new System.EventHandler(this.Bt_loginClick);
			// 
			// bt_again
			// 
			this.bt_again.BackColor = System.Drawing.Color.Khaki;
			this.bt_again.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_again.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.bt_again.Location = new System.Drawing.Point(312, 274);
			this.bt_again.Name = "bt_again";
			this.bt_again.Size = new System.Drawing.Size(81, 31);
			this.bt_again.TabIndex = 6;
			this.bt_again.Text = "重置";
			this.bt_again.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.label2.Location = new System.Drawing.Point(173, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 41);
			this.label2.TabIndex = 7;
			this.label2.Text = "登  录/LOGIN";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(572, 376);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bt_again);
			this.Controls.Add(this.bt_login);
			this.Controls.Add(this.userPass);
			this.Controls.Add(this.userName);
			this.Controls.Add(this.rbAdmin);
			this.Controls.Add(this.rbStudent);
			this.Controls.Add(this.rbTeacher);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "学生选课管理系统";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbTeacher;
		private System.Windows.Forms.Button bt_again;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.TextBox userPass;
		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.RadioButton rbAdmin;
		private System.Windows.Forms.RadioButton rbStudent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		
		
	}
}
