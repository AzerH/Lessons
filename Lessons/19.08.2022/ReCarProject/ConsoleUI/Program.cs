﻿using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.GetAll().ForEach(c => Console.WriteLine(c.CarName));


            //Console.WriteLine(carManager.GetCarByid(2).CarName); 
            //var car = new Car();

            //carManager.Add(new Car() { CarId = 5, BrandId = 2, CarName = "Pajero", ColorId = 2, DailyPrice = 14000, ModelYear = 2006 });
            //carManager.Delete(new Car() { CarId = 5, BrandId = 2, CarName = "Pajero" });

            carManager.GetCarDetails().ForEach(c => Console.WriteLine(c.CarName +"//"+c.BrandName));


        }
    }
}
