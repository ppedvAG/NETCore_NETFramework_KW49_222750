using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_NET48_Sample.Models;

namespace WebAPI_NET48_Sample.Data
{
    public static class FakeDB
    {
        public static IList<Person> GetAllPersons()
        {
            IList<Person> list = new List<Person>();

            list.Add(new Person { Id = 1, Name = "Otto Walkes" });
            list.Add(new Person { Id = 2, Name = "Harry Weinfuhrt" });
            list.Add(new Person { Id = 3, Name = "Kurt Krömer" });


            return list;
        }
    }
}