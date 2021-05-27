using Business.Abstract;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _ımageDal;
        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }
        public IResult Add(Image ımage,IFormFile file)
        {
            ımage.ImagePath = FileHelper.Add(file);
            ımage.Date = DateTime.Now;
            _ımageDal.Add(ımage);

            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {

            return new SuccessDataResult<List<Image>>(_ımageDal.GetAll());
        }
    }
}
