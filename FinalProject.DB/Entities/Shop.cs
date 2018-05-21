using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.DB.Entities
{
    public class Shop : BaseEntity
    {

        [Required, StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string StreetName { get; set; }

        [StringLength(50)]
        public string WorkTime { get; set; }
    }
}
