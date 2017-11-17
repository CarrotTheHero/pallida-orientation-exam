using CarListApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarListApp.Entities
{
    public class CarListContext : DbContext
    {
        public CarListContext(DbContextOptions<CarListContext> options) : base(options)
            {

        }

        public DbSet<Car> Licence_plates { get; set; }
    }
}
