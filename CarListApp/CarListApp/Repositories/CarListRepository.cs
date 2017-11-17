using CarListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarListApp.Repositories
{
    public class CarListRepository
    {
        CarListContext CarListContext;

        public CarListRepository(CarListContext carListContext)
        {
            CarListContext = carListContext;
        }
    }
}
