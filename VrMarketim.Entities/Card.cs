using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrMarketim.Entities
{
    public class Card
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public String CardNumber { get; set; }

        [StringLength(15)]
        public string NameSurname { get; set; }

        [StringLength(15)]
        public string Date { get; set; }

        [StringLength(15)]
        public string SecCode { get; set; }


    }
}
