using Prison_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Interface
{
    public interface INotification<TEntity> where TEntity : class
    {
        List<Notification> GetAll();

    }
}
