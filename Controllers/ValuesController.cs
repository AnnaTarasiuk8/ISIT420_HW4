using ISIT420_HW4_Tarasiuk_Gurskaia.Models;
using ISIT420_HW4_Tarasiuk_Gurskaia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Controllers
{
    public class ValuesController : ApiController
    {
        DataService service = new DataService();
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            if(id == 1)
            {
                //List<CD> allCD = service.GetAllCD();
                List<SalesPerson> allSalesPerson = service.GetAllSalesPerson();
                List<Store> allStores = service.GetAllStores();
                Dictionary<Store, int> cities = new Dictionary<Store, int>();
                for (int i = 0; i < allStores.Count; i++)
                {
                    cities.Add(allStores[i], 0);
                }

                for (int i = 0; i < allSalesPerson.Count; i++)
                {
                    for (int j = 0; j < allStores.Count; j++)
                    {
                        if (allStores[j].ID == allSalesPerson[i].StoreID)
                        {
                            cities[allStores[j]]++;
                        }
                    }
                }

                List<string> thirdList = new List<string>();

                foreach (Store store in cities.Keys)
                {
                    thirdList.Add(store.City + ": ");
                }
                int idx = 0;
                foreach (int a in cities.Values)
                {
                    thirdList[idx] += a;
                    idx++;
                }

                //Dictionary<Store, int> cities = new Dictionary<Store, int>();
                //for (int i = 0; i < allStores.Count; i++)
                //{
                //    cities.Add(allStores[i], 0);
                //}

                //return Json(cities);

                //Console.WriteLine("INTERNAL GET NOTE", cities);
                //var product = notes.FirstOrDefault((p) => p.NoteId == id);
                //var product = "I AM OBJ 9999999";
                //if (product == null)
                //{
                //    return NotFound();
                //}
                //return Ok(Json(cities));
                return Json(thirdList);
                //return "value";
            }
            else if(id == 2)
            {
                List<string> res = new List<string>();

                Random rnd = new Random();
                res.Add($"This employee sole ${rnd.Next(100, 999)} for the year!");
                return Json(res);
            }
            else
            {
                List<string> res = new List<string>();

                Random rnd = new Random();
                res.Add($"This store sole ${rnd.Next(100, 999)} for the year!");
                return Json(res);
            }
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //public IHttpActionResult GetNote(int id)
        //{
        //    Console.WriteLine("INTERNAL GET NOTE");
        //    //var product = notes.FirstOrDefault((p) => p.NoteId == id);
        //    var product = "I AM OBJ";
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
    }
}
