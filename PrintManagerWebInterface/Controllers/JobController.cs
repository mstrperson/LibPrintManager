using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibPrintManager;
using PrintManagerWebInterface.Models;

namespace PrintManagerWebInterface.Controllers
{
    public class JobController : ApiController
    {
        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            if (id < 0) return (IHttpActionResult)new HttpResponseMessage(HttpStatusCode.BadRequest);

            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                Job job = db.Jobs.Find(id);
                if (job == null) return (IHttpActionResult)new HttpResponseMessage(HttpStatusCode.NotFound);

                return (IHttpActionResult)Request.CreateResponse<JobModel>(HttpStatusCode.OK, (JobModel)job, "text/json");
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}