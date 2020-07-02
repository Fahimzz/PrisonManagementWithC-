using Prison_Management_System.Entities;
using Prison_Management_System.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Repository
{
    class NotificationRepo:INotification<Notification>
    {
        DataAccess dbc;
        public int Save(Notification notice)
        {
            dbc = new DataAccess();
            string sql = "INSERT INTO Notification VALUES ('" + notice.Notice + "','" + notice.Date + "');";
            int result = dbc.ExecuteQuery(sql);
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public List<Notification> GetAll()
        {
            dbc = new DataAccess();
            string sql = "SELECT * FROM Notification";
            SqlDataReader reader = dbc.GetData(sql);
            List<Notification> homelist = new List<Notification>();
            while (reader.Read())
            {
                Notification emp = new Notification();
                emp.Id = Convert.ToInt32(reader["Id"]);
                emp.Notice = reader["Notice"].ToString();
                emp.Date = reader["Date"].ToString();
                

                homelist.Add(emp);
            }
            dbc.Dispose();

            return homelist;
        }
    }
}
