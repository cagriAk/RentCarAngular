using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IImageService
    {
        IResult Add(Image ımage, IFormFile file);
        IDataResult<List<Image>> GetAll();
    }
}
