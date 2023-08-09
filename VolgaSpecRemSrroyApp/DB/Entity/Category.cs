using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolgaSpecRemSrroyApp.DB.Entity
{
   public class Category
    {
        public int ID { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
