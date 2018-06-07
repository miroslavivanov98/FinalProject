using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.DB.Entities
{
    public class Weapon : BaseEntity
    {

        public int ManafacturerId { get; set; }
        [ForeignKey("ManafacturerId")]
        public virtual Manafacturer Manafacturer { get; set; }

        [Required, StringLength(50)]
        [Index("IX_WeaponsNameUnique", IsUnique = true)]
        public string Model { get; set; }

        [Required, StringLength(20)]
        public string Caliber { get; set; }

        [Required, StringLength(20)]
        public string Weight { get; set; }

        [Required, StringLength(20)]
        public string BarrelLength { get; set; }

        [StringLength(20)]
        public string Price { get; set; }


    }
}
