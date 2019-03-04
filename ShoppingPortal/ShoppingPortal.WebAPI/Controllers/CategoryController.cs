using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingPortal.Masters.BAL;
using ShoppingPortal.Masters.Model;
using ShoppingPortal.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            IEnumerable<Category> objReturn = null;

            using (Category_BAL obj_BAL = new Category_BAL())
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
        public DefaultResult Post([FromBody] Category objCategory)
        {
            DefaultResult objReturn = new DefaultResult();

            if (objCategory.Id == 0)
            {
                objCategory.CategoryId = Guid.NewGuid();
                objCategory.CreationDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                objCategory.IsActive = true;
                //objCategory.PasswordHash = EncryptionLibrary.EncryptText(objCategory.PasswordHash);
            }

            objCategory.UpdatedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            objCategory.IsDeleted = false;

            using (Category_BAL objBAL = new Category_BAL())
            {
                objReturn.Data = objBAL.InsertUpdateRecord(objCategory).ToString();
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
