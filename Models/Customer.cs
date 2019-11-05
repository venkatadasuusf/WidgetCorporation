using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WidgetCorporation.Models
{
    public class Customer
    {
        [Key]
        [Column(TypeName = "int")]
        public int CustomerID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string CustomerName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerEmail { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CustomerPhone { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AddressLine2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(2)")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string ZipCode { get; set; }
        
    }
}
