using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb.Models
{
    public class InstructionModel
    {
        [Key]
        [Column("instruction_id")]
        public int InstructionId { get; set; }
        [Column("instruction_info")]
        public string InstructionInfo { get; set; } = null!;

        [Column("plant_id")]
        public int PlantId { get; set; } 

        public PlantModel Plant { get; set; } = null!;



    }
}
