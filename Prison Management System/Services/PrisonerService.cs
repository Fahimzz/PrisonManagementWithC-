using Prison_Management_System.Entities;
using Prison_Management_System.Interface;
using Prison_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Prison_Management_System.Services
{
    class PrisonerService
    {
        PrisonerRepo prsn;
        IPrisonerRepo<Prisoner> prson;

        public PrisonerService()
        {
            prsn = new PrisonerRepo();
            this.prson = new PrisonerRepo();
        }
        public int savePrisoner(int pid, string pname, string crime, string edate, string rdate, int cno, string nid)
        {
            return prsn.Save(new Prisoner() { PrisonerId = pid, PrisonerName = pname, Crime = crime, EntryDate = edate, ReleasedDate = rdate, CellNo = cno, NID = nid }); ;
        }

       
        public List<Prisoner> getAllPrisoner()
        {
            return prson.GetAll();
        }
        public int deletePrisoner(string id)
        {
            int result = prsn.Delete(id);
            return result;
        }
    }
}
