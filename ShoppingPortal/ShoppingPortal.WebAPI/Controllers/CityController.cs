using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingPortal.Common;
using ShoppingPortal.Masters.BAL;
using ShoppingPortal.Masters.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<City> Get()
        {
            IEnumerable<City> objReturn = null;
            using (City_BAL obj_BAL = new City_BAL())
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
        public DefaultResult Post([FromBody] City objCity)
        {
            DefaultResult objReturn = new DefaultResult();

            if (objCity.Id == 0)
            {
                objCity.CityId = Guid.NewGuid();
                objCity.CreationDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                objCity.IsActive = true;
                //objCity.PasswordHash = EncryptionLibrary.EncryptText(objCity.PasswordHash);
            }

            objCity.UpdatedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            objCity.IsDeleted = false;

            using (City_BAL objBAL = new City_BAL())
            {
                objReturn.Data = objBAL.InsertUpdateRecord(objCity).ToString();
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
