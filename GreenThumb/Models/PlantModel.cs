using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb.Models
{
    public class PlantModel
    {
        [Key]
        [Column("plant_id")]
        public int PlantId { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("description")]
        public string? Description { get; set; }

        public List<InstructionModel> Instructions { get; set; } = new();
    }
}
