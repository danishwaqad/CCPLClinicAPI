using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCPLClinicAPI.Controllers
{
    public class TestController : ApiController
    {
        
        public IHttpActionResult Get()
        {
            return Ok("Current Time is " + DateTime.Now.ToShortTimeString());
        }


        [HttpGet]
        public IHttpActionResult GetNew(string CNIC)
        {
            return Ok("You Entered : " + CNIC);
        }
    }
}
