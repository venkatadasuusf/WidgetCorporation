using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WidgetCorporation.Models
{
    public class Cart
    {
        [Key]
        [Column(TypeName = "int")]
        public int CartID { get; set; }

        //[ForeignKey] 
        [Column(TypeName = "int")]
        public int CustomerID { get; set; }
    }
}
