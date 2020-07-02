using Prison_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Interface
{
    internal interface IVisitorRepo<T>
    {
        List<Visitor> GetAll();
    }
}
