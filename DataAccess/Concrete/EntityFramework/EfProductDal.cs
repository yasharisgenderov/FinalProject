using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal // iproductdali yazmagimizin sebebi IproductDlda her hansi emeliyyati yazanda burda implement elemek mumkun olsun
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.products
                             join c in context.categories   
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 Productİd = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsİnStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
