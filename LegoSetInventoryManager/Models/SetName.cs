﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LegoSets
{
    public class SetName : SetDetails
    {
        [Key]

        [StringLength(100)]

        [Display(Name = "Set Name")]

        public string? Title { get; set; }
    }
}