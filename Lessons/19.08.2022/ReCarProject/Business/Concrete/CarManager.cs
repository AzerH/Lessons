
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            if (car.CarName.Length<=2)
                Console.WriteLine("Name of car must be more than 2 character");
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Car added");
            }
                
            


        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("car has been deleted");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public Car GetCarByid(int id)
        {
            return _carDal.Get(c => c.BrandId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
