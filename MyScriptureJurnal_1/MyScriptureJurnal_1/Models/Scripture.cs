using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJurnal_1.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Chapter { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(60)]
        public string Notes { get; set; }

        [Display(Name = "Insert Date")]
        [DataType(DataType.Date)]
        public DateTime InsertDate { get; set; }
    }
}
