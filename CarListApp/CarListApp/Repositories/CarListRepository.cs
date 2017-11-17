using CarListApp.Entities;
using CarListApp.Models;
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

        public List<Car> GetAll()
        {
            return CarListContext.Licence_plates.ToList();
        }

        public List<Car> GetSearchedCars(string plate)
        {
            return CarListContext.Licence_plates.Where(x => x.Plate.Contains(plate)).ToList();
        }
    }
}
