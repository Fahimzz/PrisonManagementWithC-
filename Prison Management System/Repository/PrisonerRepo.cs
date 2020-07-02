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
    class PrisonerRepo:IPrisonerRepo<Prisoner>
    {
        DataAccess dbc;
        public PrisonerRepo()
        {

        }
        public int Save(Prisoner prisoner)
        {
            dbc = new DataAccess();
            string sql = "INSERT INTO Prisoner VALUES (" + prisoner.PrisonerId + ",'" + prisoner.PrisonerName + "','" + prisoner.Crime + "','" + prisoner.EntryDate + "','" + prisoner.ReleasedDate + "'," + prisoner.CellNo + ",'" + prisoner.NID + "');";
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
        public List<Prisoner> GetAll()
        {
            dbc = new DataAccess();
            string sql = "SELECT * FROM Prisoner";
            SqlDataReader reader = dbc.GetData(sql);
            List<Prisoner> homelist = new List<Prisoner>();
            while (reader.Read())
            {
                Prisoner pn = new Prisoner();
                pn.PrisonerId = Convert.ToInt32(reader["prisonerId"]);
                pn.PrisonerName = reader["prisonerName"].ToString();
                pn.Crime = reader["crime"].ToString();
                pn.EntryDate = reader["entryDate"].ToString();
                pn.ReleasedDate = reader["ReleaseDate"].ToString();
                pn.CellNo = Convert.ToInt32(reader["cellNo"]);
                pn.NID = reader["nid"].ToString();

                homelist.Add(pn);
            }
            dbc.Dispose();

            return homelist;
        }
        public int Delete(string id)
        {
            dbc = new DataAccess();
            string sql = "DELETE FROM Prisoner WHERE PrisonerId='" + id + "'";
            int result = dbc.ExecuteQuery(sql);
            dbc.Dispose();
            return result;
        }
    }
}
