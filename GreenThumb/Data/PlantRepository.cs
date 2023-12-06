using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb.Data
{
    public class PlantRepository<T> where T : class
    {
        private readonly PlantDbContext _context;
        private readonly DbSet<T> _dbSet;

        public PlantRepository(PlantDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public PlantModel? GetPlantByName(string plantName)
        {
            return _context.Plants.FirstOrDefault(p => p.Name == plantName);
        }
    }
}
