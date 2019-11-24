using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WidgetCorporation.Models
{
    public class CartDetails
    {
        [Key]
        [Column(TypeName = "int")]
        public int CartDetSeqID { get; set; }

        //[ForeignKey]
        [Column(TypeName = "int")]
        public int CartID { get; set; }

        //[ForeignKey]
        [Column(TypeName = "int")]
        public int ProductID { get; set; }

        [Column(TypeName = "int")]
        public int ProductQuantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }

    }
}
