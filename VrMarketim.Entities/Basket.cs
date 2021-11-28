using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrMarketim.Entities
{
    public class Basket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        /*public virtual Account Account { get; set; }*/

        [StringLength(200)]
        public string Products { get; set; }
    }
}
