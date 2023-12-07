using GreenThumb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb.Data
{
    public class PlantsUow
    {
        private readonly PlantDbContext _context;

        public PlantRepository<PlantModel> PlantRepository { get; }
        public InstructionRepository<InstructionModel> InstructionRepository { get; }

        public PlantsUow(PlantDbContext context)
        {
            _context = context;

            PlantRepository = new(context);
            InstructionRepository = new(context);   
        }
    }
}
