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
        private readonly PlantDbContext _conext;

        public PlantRepository<PlantModel> PlantRepository { get; }
        public PlantRepository<InstructionModel> InstructionRepository { get; }

        public PlantsUow(PlantDbContext context)
        {
            _conext = context;

            PlantRepository = new(context);
            InstructionRepository = new(context);   
        }

        public async Task Complete()
        {
            await _conext.SaveChangesAsync();
        }
    }
}
