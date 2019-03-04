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
    public class CountryController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            IEnumerable<Country> objReturn = null;
            
            using (Country_BAL objBAL = new Country_BAL())
            {
                objReturn = objBAL.GetAllRecord();

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
        public DefaultResult Post([FromBody] Country objCountry)
        {
            DefaultResult objReturn = new DefaultResult();

            if (objCountry.Id == 0)
            {
                objCountry.CountryId = Guid.NewGuid();
                objCountry.CreationDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                objCountry.IsActive = true;
                //objCountry.PasswordHash = EncryptionLibrary.EncryptText(objCountry.PasswordHash);
            }

            objCountry.UpdatedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            objCountry.IsDeleted = false;

            using (Country_BAL objBAL = new Country_BAL())
            {
                objReturn.Data = objBAL.InsertUpdateRecord(objCountry).ToString();
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
