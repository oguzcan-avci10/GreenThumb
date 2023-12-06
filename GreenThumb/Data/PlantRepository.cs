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
        // Hämta alla plantor med tillhörande instruktioner
        public PlantModel? GetByName(string plantName)
        {
            return _context.Plants.Include(p => p.Instructions).FirstOrDefault(p => p.Name == plantName);/*FirstOrDefault(p => p.Name == plantName);*/
        }

        // Hämta alla plantor
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        // Delete plant
        public void Delete(string plantName)
        {
            var plants = _context.Plants.ToList();

            foreach (var p in plants)
            {
                if (p.Name == plantName) 
                {
                    _context.Plants.Remove(p);
                    _context.SaveChanges();
                    
                }

            }
        }

       
    }
}
