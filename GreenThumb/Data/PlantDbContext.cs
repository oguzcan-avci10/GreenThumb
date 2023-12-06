using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb.Data
{
    public class PlantDbContext : DbContext
    {
        public PlantDbContext()
        {
            
        }
        public DbSet<PlantModel> Plants{ get; set; }
        public DbSet<InstructionModel> Instructions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PlantDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlantModel>().HasData(new PlantModel
            {
                PlantId = 1,
                Name = "Sunflower",
                Description = "Bright yellow flowering plants known for their striking appearance and large, disk-like flower heads."
            },
            new PlantModel
            {
                PlantId = 2,
                Name = "Cactus",
                Description = "Plants that have succulent stems, pads or branches with scales and spines instead of leaves."
            },
            new PlantModel
            {
                PlantId = 3,
                Name = "Rose",
                Description = "Rose flowers vary in size and shape. They burst with colours ranging from pastel pink, peach, and cream, to vibrant yellow, orange, and red. Many roses are fragrant"
            },
            new PlantModel
            {
                PlantId = 4,
                Name = "Tree",
                Description = "A tree is a tall plant that can live a very long time. It has a single stem or trunk and branches that support leaves."
            },
            new PlantModel
            {
                PlantId = 5,
                Name = "Grass",
                Description = "A low, green plant that grows naturally over a lot of the earth's surface."
            },
            new PlantModel
            {
                PlantId = 6,
                Name = "Bamboo",
                Description = "Bamboo is a type of fast-growing grass that is known for its strength and versatility."
            },
            new PlantModel
            {
                PlantId = 7,
                Name = "Ivy",
                Description = "Ivy is a type of climbing plant that can grow on walls, trees, and other surfaces."
            },
            new PlantModel
            {
                PlantId = 8,
                Name = "Palm Tree",
                Description = "A palm tree is a type of tropical tree with a tall, slender trunk."
            },
            new PlantModel
            {
                PlantId = 9,
                Name = "Bush",
                Description = "Bushes are often used for landscaping and can provide a natural barrier or privacy screen."
            },
            new PlantModel
            {
                PlantId = 10,
                Name = "Corn",
                Description = "Corn is a type of cereal grain that is grown for its edible seeds."
            });

            modelBuilder.Entity<InstructionModel>().HasData(
                new InstructionModel()
                {
                    InstructionId = 1,
                    InstructionInfo = "Watering the plant",
                    PlantId = 1
                },
                new InstructionModel
                {
                    InstructionId = 2,
                    InstructionInfo = "Put them in sunlight if you have them indoors.",
                    PlantId = 2
                },
                new InstructionModel
                {
                    InstructionId = 3,
                    InstructionInfo = "During fall and winter, you can water them less often.",
                    PlantId = 3
                },
                new InstructionModel
                {
                    InstructionId = 4,
                    InstructionInfo = "Provide 1 to 2 inches (2.5 to 5.1 cm) of water each week.",
                    PlantId = 3
                });
        }

    }
}
