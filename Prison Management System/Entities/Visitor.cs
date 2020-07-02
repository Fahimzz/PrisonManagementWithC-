using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Entities
{
  public class Visitor
    {
      public string VName { get;set; }
      public string Relationship { get; set; }
      public string Serial { get; set; }

      public string Time { get; set; }
      public string Date { get; set; }
      public string PrisonerId { get; set; }

    }
}
