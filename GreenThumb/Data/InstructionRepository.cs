using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb.Data
{
    public class InstructionRepository<T> where T : class
    {
        private readonly PlantDbContext _context;
        private readonly DbSet<T> _dbSet;

        public InstructionRepository(PlantDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();  
        }

        // Lägg till skötselråd

        public void AddInstruction(InstructionModel instruction)
        {
            _context.Instructions.Add(instruction);
            _context.SaveChanges();
        }
    }
}
