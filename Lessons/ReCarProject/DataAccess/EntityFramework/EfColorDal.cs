﻿using Core.DataAccess.EfEntityRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDatabaseContext> , IColorDal
    {
    }
}
