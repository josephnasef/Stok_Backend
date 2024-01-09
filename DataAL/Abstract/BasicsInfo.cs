using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Abstract
{
    abstract public class BasicsInfo
    {
        [Column(TypeName = "date")]
        public DateTime? LastEiteDate { get; set; }

        [StringLength(100)]
        public string LastEditeBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime Creation_Date { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }
        public bool? isDeleted { get; set; }
        public bool? state { get; set; }
        public bool? Isapproved { get; set; }
    }
}
