using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace LegoSetInventoryManager.Models
{
    public class SetName : SetDetail
    {
        [Key]

        [StringLength(100)]

        [Display(Name = "Set Name")]

        public string? Title { get; set; }
    }
}