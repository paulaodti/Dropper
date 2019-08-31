using System.Collections.Generic;
using System.Web.Http;

namespace DropperAPI.Controllers
{
    public class MedicaoVazaoController : ApiController
    {
        // GET: api/MedicaoVazao
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MedicaoVazao/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MedicaoVazao
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MedicaoVazao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MedicaoVazao/5
        public void Delete(int id)
        {
        }
    }
}
