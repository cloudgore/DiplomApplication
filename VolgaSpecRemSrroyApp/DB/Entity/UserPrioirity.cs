using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolgaSpecRemSrroyApp.DB.Entity
{
public    class UserPrioirity
    {

        public int ID { get; set; }
        public string PriorityName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
