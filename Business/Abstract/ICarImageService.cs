﻿using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage, IFormFile file);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int imageId);
        IDataResult<List<CarImage>> GetAllByCarId(int carId);
    }
}
