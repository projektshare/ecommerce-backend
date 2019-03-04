using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingPortal.Common;
using ShoppingPortal.ProductInfo.BAL;
using ShoppingPortal.ProductInfo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            IEnumerable<Product> objReturn = null;
            using (Product_BAL obj_BAL = new Product_BAL())
            {
                objReturn = obj_BAL.GetAllRecord();

            }
            return objReturn;

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public DefaultResult Post([FromBody] Product objProduct)
        {
            DefaultResult objReturn = new DefaultResult();

            if (objProduct.Id == 0)
            {
                objProduct.ProductId = Guid.NewGuid();
                objProduct.CreationDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                objProduct.IsActive = true;
                //objProduct.PasswordHash = EncryptionLibrary.EncryptText(objProduct.PasswordHash);
            }

            objProduct.UpdatedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            objProduct.IsDeleted = false;

            using (Product_BAL objBAL = new Product_BAL())
            {
                objReturn.Data = objBAL.InsertUpdateRecord(objProduct).ToString();
            }

            return objReturn;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
