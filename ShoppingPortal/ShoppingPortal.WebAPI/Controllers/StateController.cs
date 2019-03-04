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
    public class StateController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<State> Get()
        {
            IEnumerable<State> objReturn = null;

            using (State_BAL objBAL = new State_BAL())
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
        public DefaultResult Post([FromBody] State objState)
        {
            DefaultResult objReturn = new DefaultResult();

            if (objState.Id == 0)
            {
                objState.StateId = Guid.NewGuid();
                objState.CreationDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                objState.IsActive = true;
                //objState.PasswordHash = EncryptionLibrary.EncryptText(objState.PasswordHash);
            }

            objState.UpdatedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            objState.IsDeleted = false;

            using (State_BAL objBAL = new State_BAL())
            {
                objReturn.Data = objBAL.InsertUpdateRecord(objState).ToString();
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
