using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WidgetCorporation.Models
{
    public class Login
    {
        [Key]
        [Column(TypeName = "int")]
        public int LoginSeqID { get; set; }

        //[ForeignKey] 
        [Column(TypeName = "int")]
        public int CustomerID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
    }
}
