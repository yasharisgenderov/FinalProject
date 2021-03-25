using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService) // constructorda biz deyirik ki mene bir manager ver,cunki iproductservice productmanagerin referansini tuta bilir.Biz de constructorda verdiyimiz productServicei asagida istifade ede bilmirik deye onun referansini _productService e veririk ki asagida istifade ede bilek
        {
            _productService = productService; // burada new ProductManager de yaza bilerik(Cunki implemente etmisdik) lakin yazmiriq cunki kodun buarada productmanagerden asili olmasini istemirik.
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            /*IProductService productService = new ProductManager(new EfProductDal()); bu buarada asiliq yaradir deye constructor halina saldim */
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
