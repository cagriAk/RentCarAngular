using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public  class EfCardal : EfEntityRepository<Car,RentCarContext>,ICarDal
    {
      
    }
}
