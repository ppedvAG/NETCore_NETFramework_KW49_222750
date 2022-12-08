using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_NET48_Sample.Data;
using WebAPI_NET48_Sample.Models;

namespace WebAPI_NET48_Sample.Controllers
{
    public class DemoController : ApiController
    {

        [HttpGet]
        public IList<Person> GetAllPersons()
        {
            return FakeDB.GetAllPersons();
        }
    }
}
