using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Prison_Management_System.Entities;
using Prison_Management_System.Interface;

namespace Prison_Management_System.Repository
{
    class ReceptionistRepo:IVisitorRepo<Visitor>
    {
        DataAccess dbc;
        public ReceptionistRepo()
        {

        }
        public int Save(Visitor visitor)
        {
            dbc = new DataAccess();
            string sql = "INSERT INTO visitor1 VALUES (" + visitor.Serial + "," + visitor.PrisonerId + ",'" + visitor.VName + "','" + visitor.Relationship + "','" + visitor.Date + "','" + visitor.Time + "');";
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
        public List<Visitor> GetAll()
        {
            dbc = new DataAccess();
            string sql = "SELECT * FROM visitor1";
            SqlDataReader reader = dbc.GetData(sql);
            List<Visitor> homelist = new List<Visitor>();
            while (reader.Read())
            {
                Visitor v = new Visitor();
                v.Serial = reader["Serial"].ToString();
                v.PrisonerId = reader["prisonerId"].ToString();
                v.VName = reader["visitorName"].ToString();
                v.Relationship = reader["Relation"].ToString();
                v.Date = reader["Date"].ToString();
                v.Time= reader["Time"].ToString();

                homelist.Add(v);
            }
            dbc.Dispose();

            return homelist;
        }
    }
}
