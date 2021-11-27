using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrMarketim.Entities
{
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(15)]
        public string Password { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Surname { get; set; }

        [StringLength(200)]
        public string Address { get; set; }
    }
}
