/*
 * 由SharpDevelop创建。
 * 用户： Polemo
 * 日期: 2018/12/2
 * 时间: 20:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Course_Manage
{
	partial class InfoWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWin));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.panel_CourseInfo = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGv_Course = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_sInfo.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_sInfo)).BeginInit();
			this.panel_CourseInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGv_Course)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_sInfo
			// 
			this.panel_sInfo.Controls.Add(this.btn_StuNew);
			this.panel_sInfo.Controls.Add(this.btn_LookStuInfo);
			this.panel_sInfo.Controls.Add(this.toolStrip1);
			this.panel_sInfo.Controls.Add(this.datagv_sInfo);
			this.panel_sInfo.Location = new System.Drawing.Point(12, 38);
			this.panel_sInfo.Name = "panel_sInfo";
			this.panel_sInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_sInfo.TabIndex = 30;
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
			// 
			// tsbtn_StuClassSearch
			// 
			this.tsbtn_StuClassSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtn_StuClassSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_StuClassSearch.Image")));
			this.tsbtn_StuClassSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_StuClassSearch.Name = "tsbtn_StuClassSearch";
			this.tsbtn_StuClassSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbtn_StuClassSearch.Text = "查询";
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
			// panel_CourseInfo
			// 
			this.panel_CourseInfo.Controls.Add(this.button1);
			this.panel_CourseInfo.Controls.Add(this.button2);
			this.panel_CourseInfo.Controls.Add(this.dataGv_Course);
			this.panel_CourseInfo.Location = new System.Drawing.Point(35, 12);
			this.panel_CourseInfo.Name = "panel_CourseInfo";
			this.panel_CourseInfo.Size = new System.Drawing.Size(868, 417);
			this.panel_CourseInfo.TabIndex = 36;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(601, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 36);
			this.button1.TabIndex = 32;
			this.button1.Text = "刷  新";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(759, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 36);
			this.button2.TabIndex = 31;
			this.button2.Text = "查  看";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dataGv_Course
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGv_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGv_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGv_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn7,
									this.dataGridViewTextBoxColumn8,
									this.dataGridViewTextBoxColumn9,
									this.dataGridViewTextBoxColumn10,
									this.dataGridViewTextBoxColumn11});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGv_Course.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGv_Course.Location = new System.Drawing.Point(12, 19);
			this.dataGv_Course.Name = "dataGv_Course";
			this.dataGv_Course.RowTemplate.Height = 23;
			this.dataGv_Course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGv_Course.Size = new System.Drawing.Size(849, 275);
			this.dataGv_Course.TabIndex = 30;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "s_number";
			this.dataGridViewTextBoxColumn4.Frozen = true;
			this.dataGridViewTextBoxColumn4.HeaderText = "工号";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 120;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "s_name";
			this.dataGridViewTextBoxColumn7.Frozen = true;
			this.dataGridViewTextBoxColumn7.HeaderText = "姓名";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "d_name";
			this.dataGridViewTextBoxColumn8.Frozen = true;
			this.dataGridViewTextBoxColumn8.HeaderText = "所属院系";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 170;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "s_course";
			this.dataGridViewTextBoxColumn9.Frozen = true;
			this.dataGridViewTextBoxColumn9.HeaderText = "所授课程";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 170;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "s_score";
			this.dataGridViewTextBoxColumn10.Frozen = true;
			this.dataGridViewTextBoxColumn10.HeaderText = "课程教室";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.Frozen = true;
			this.dataGridViewTextBoxColumn11.HeaderText = "课程时间";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 140;
			// 
			// InfoWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 538);
			this.Controls.Add(this.panel_CourseInfo);
			this.Controls.Add(this.panel_sInfo);
			this.Name = "InfoWin";
			this.Text = "DataGvInfo";
			this.panel_sInfo.ResumeLayout(false);
			this.panel_sInfo.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagv_sInfo)).EndInit();
			this.panel_CourseInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGv_Course)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridView dataGv_Course;
		private System.Windows.Forms.Panel panel_CourseInfo;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
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
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbtn_StuDepartSearch;
		private System.Windows.Forms.ToolStripComboBox tscb_StuDepart;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
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
	}
}
