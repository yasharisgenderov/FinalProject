using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
     public class ProductManager:IProductService
     {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product) // utilities folderini void ucun istifadecini melumatlandirmaq ucun yaradiriq yeni resultlari bildirmek ucun.Daha sonra utilitylerin icinde IResult taratdim ve voidle deyisdim
        {
            // business codes
            /*Result result = new Result();
           result.Success;  eger men bunu setle verseydim bele olardi lakin getle verirem deye bele olur. YENI KI SUCCESSI ORDA SET ELYIB YENI DEYER VERSEYDIK TEKCE RETurn SUCCESS YAZARDIQ AMMA BIZ GETLE VERMISIK DEYE NEW RESULTIN MOTERIZESINDE DEYERLERI BIZ VERIRIK
            return result;*/
            
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Urun ismi en az 2 karakter olmalidi");
            }
            _productDal.Add(product);
            return new SuccessResult("Urun Eklendi");
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(p => p.CategoryId == 2);
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
