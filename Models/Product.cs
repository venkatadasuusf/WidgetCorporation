using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WidgetCorporation.Models
{
    public class Product
    {
        [Key]
        [Column(TypeName = "int")]
        public int ProductID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ProductName { get; set; }

        [Column(TypeName = "money")]
        public decimal ProductPrice { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ProductAvailability { get; set; }

        [Column(TypeName = "int")]
        public int ProductInventory { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ProductImageName { get; set; }
        
    }
}
