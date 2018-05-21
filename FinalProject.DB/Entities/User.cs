using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.DB.Entities
{
    public class User : BaseEntity
    {
        [Required, StringLength(20)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string PassHash { get; set; }

        [Required, StringLength(20)]
        public string IsAdmin { get; set; }

        [Required, StringLength(20)]
        public string IsBanned { get; set; }

    }
}
