using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
          IResult result = BusinessRules.Run(IsMoreThan10(car));

            if (result!=null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccessResult("Eklendi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Veriler Listelendi");
        }

        public IResult Delete(Car car)
        {

            _carDal.Delete(car);

            return new SuccessResult("Veri silindi");
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult("Güncellendi");
        }

        public IResult IsMoreThan10(Car car)
        {
            int count = _carDal.GetAll(c => c.BrandId == car.BrandId).Count;
            if (count<10)
            {
                return new SuccessResult();
            }
            return new ErrorResult("10 dan fazla araç var") ;
        }
    }
}
