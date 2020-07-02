using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Prison_Management_System.Entities;

namespace Prison_Management_System.Repository
{
	public class UserRepo
	{
		DataAccess dbc;

		public UserRepo()
		{
			
		}

		public int GetUser(User user)
		{
			dbc = new DataAccess();
			string query = "Select * from login where userId = '" + user.UserId + "' and password = '" + user.Password + "';";
			

			SqlDataReader reader = dbc.GetData(query);
			reader.Read();
			int usertype = (int)reader["Status"];
			if (usertype == 0)
			{
				return 1;
			}
			else if (usertype == 1)
			{
				return 2;
			}
			else if (usertype == 2)
			{
				return 3;
			}
			else { return 0; }


		}
		public int insert(User user)
		{
			dbc = new DataAccess();
			string sql = "INSERT INTO Login(userId,Password,Status) VALUES('" + user.UserId + "','" + user.Password + "','" + user.Status + "')";
			int result = dbc.ExecuteQuery(sql);
			if(result>0)
			{
				return 1;
			}
			else
			{
				return 0;
			}

		}
		public int Delete(string id)
		{
			dbc = new DataAccess();
			string sql = "DELETE FROM Login WHERE userId='" + id + "'";
			int result = dbc.ExecuteQuery(sql);
			dbc.Dispose();
			return result;
		}
		public int Update(User user)
		{
			dbc = new DataAccess();
			string sql = "UPDATE Login SET  Password = '" + user.Password + "' WHERE userId='" + user.UserId + "'"; ;
			int result = dbc.ExecuteQuery(sql);
			return result;
		}
		public int GetUserforpass(User user)
		{
			dbc = new DataAccess();
			string query = "Select * from login where userId = '" + user.UserId + "' and password = '" + user.Password + "';";


			SqlDataReader reader = dbc.GetData(query);
			reader.Read();
			int usertype = (int)reader["Status"];
			if (usertype == 0)
			{
				return 1;
			}
			else if (usertype == 1)
			{
				return 2;
			}
			else if (usertype == 2)
			{
				return 3;
			}
			else { return 0; }


		}
	}
}
