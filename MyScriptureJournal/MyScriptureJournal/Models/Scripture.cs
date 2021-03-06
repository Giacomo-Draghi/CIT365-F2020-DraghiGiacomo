﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime InsertDate { get; set; }
    }
}
