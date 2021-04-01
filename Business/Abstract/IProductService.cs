using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //neticeni,mesaji hem de dondereceyi datani yeni List<Product>i saxliyit .voidler IResultdan istifade edirik,IDataResultda List<Productdan>
    // IDataResult<List<Product>> yazanda bildirdiyimiz sey bizim yalniz List<Product>i deyil hemcinin emeliyyatin neticesinin ve messagei da retrun elemek istediyimizi bildiririk
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllByCategoryId(int id); 

        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);

        IResult Update(Product product);
    }
}
