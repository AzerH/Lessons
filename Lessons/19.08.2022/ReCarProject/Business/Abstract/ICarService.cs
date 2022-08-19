using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarByid(int id);

        List<Car> GetByBrandId(int id);

        List<Car> GetCarsByColorId(int id);

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<CarDetailDto> GetCarDetails();


    }
}
