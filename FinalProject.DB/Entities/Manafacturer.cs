using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.DB.Entities
{
    public class Manafacturer : BaseEntity
    {
        [Required, StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
