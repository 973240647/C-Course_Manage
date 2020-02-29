/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2004/2/6
 * 时间: 11:12
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Course_Manage
{
	/// <summary>
	/// Description of BaseOperate.
	/// </summary>
	public class BaseOperate
	{
		#region 建立数据库连接
		/// <summary>
		/// 建立数据库连接
		/// </summary>
		/// <returns>返回SqlConnection对象</returns>
		public SqlConnection getconnection()
		{
			//从配置文件读取数据库链接字符串
			string connString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
			SqlConnection conn = new SqlConnection(connString);
			return conn;
		}
		#endregion
		
		#region 执行SqlCommand查询命令
		/// <summary>
		/// 执行 SqlCommand查询
		/// </summary>
		/// <param name="sql_str">SQL 语句</param>
		public int getExecuteScalar(string sql_str)
		{
			
			SqlConnection sqlconn = this.getconnection();
			sqlconn.Open();
			SqlCommand sqlCommand = new SqlCommand(sql_str,sqlconn);
			int result = (int)sqlCommand.ExecuteScalar();
			sqlconn.Close();
			return result;
		}
		#endregion
		
		#region 执行SqlCommand命令
		/// <summary>
		/// 执行 SqlCommand
		/// </summary>
		/// <param name="sql_str">SQL 语句</param>
		public int getcommand(string sql_str)
		{
			
			SqlConnection sqlconn = this.getconnection();
			sqlconn.Open();
			SqlCommand sqlCommand = new SqlCommand(sql_str,sqlconn);
			int result = (int)sqlCommand.ExecuteNonQuery();
			sqlconn.Close();
			return result;
			
			
		}
		#endregion
		
		#region 创建DataSet对象
		/// <summary>
		/// 创建一个DataSet对象
		/// </summary>
		/// <param name="sql_str">SQL 语句</param>
		/// <param name="sql_table">表名</param>
		/// <returns>返回DataSet对象</returns>
		public DataSet getdataset(string sql_str,string str_table)
		{
			SqlConnection sqlconn = this.getconnection();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_str,sqlconn);
			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet,str_table); 
			return dataSet;
		}
		#endregion
		
		#region 创建SqlDataReader对象
		/// <summary>
		/// 创建一个SqlDataReader对象
		/// </summary>
		/// <param name="sql_str">SQL 语句</param>
		/// <returns>返回SqlDataReader对象</returns>
		public SqlDataReader getreader(string sql_str)
		{
			SqlConnection sqlconn = this.getconnection();
			SqlCommand sqlCommand = new SqlCommand(sql_str,sqlconn);
			sqlconn.Open();
			SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
			return dataReader;
		}
		#endregion
	}
}
