using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.DB.Entities
{
    public class Category : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
