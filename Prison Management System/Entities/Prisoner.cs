using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Entities
{
    public class Prisoner
    {
        public string PrisonerName { get; set; }
        public int PrisonerId { get; set; }
        public string EntryDate { get; set; }
        public string ReleasedDate { get; set; }
        public int CellNo { get; set; }
        public string NID { get; set; }
        public string Crime { get; set; }
    }
}
