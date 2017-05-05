using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Vega.Models;

namespace Vega.Models
{
    public class Feature
    {
        public Feature()
        {
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}