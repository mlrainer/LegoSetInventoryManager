using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace LegoSetInventoryManager.Models
{
    public class SetDetail
    {

        [Required]

        [StringLength(100)]

        [Display(Name = "Set Theme")]

        public string? Theme { get; set; }

        [Required]

        [StringLength(100)]

        [Display(Name = "Set Number")]

        public int SetNumber { get; set; }

        [Required]

        [StringLength(100)]

        [Display(Name = "Pieces")]

        public int Pieces { get; set; }

        [Required]

        [StringLength(100)]

        [Display(Name = "Mini Figs")]

        public int MiniFigs { get; set; }

        [Required]

        [StringLength(100)]

        [Display(Name = "Set Complete?")]

        public string? Complete { get; set; }
    }
}