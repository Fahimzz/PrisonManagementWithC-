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
    class ReceptionistService
    {
        ReceptionistRepo rcpt;
        IVisitorRepo<Visitor> rcp;

        public ReceptionistService()
        {
            rcpt = new ReceptionistRepo();
            this.rcp = new ReceptionistRepo();
        }
        public int saveVisitor(string serial, string vid, string vname, string relation,string date,string time)
        {
            return rcpt.Save(new Visitor() { Serial=serial,PrisonerId=vid,VName=vname,Relationship=relation,Date=date,Time=time}); ;
        }
        public List<Visitor> GetallVisitor()
        {
            return rcp.GetAll();
        }
    }
}
