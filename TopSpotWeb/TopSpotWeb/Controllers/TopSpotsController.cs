using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotWeb.Models;
using System.Web.Http.Cors;

namespace TopSpotWeb.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            // File object reads the local json file into local variable
            var topspotjsonArray = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(System.IO.File.ReadAllText("C:/dev/TopSpotsAPI/topspots.json"));
            return topspotjsonArray;
        }

        // GET: api/TopSpots/5
        public void Get(int id)
        {

        }

        // POST: api/TopSpots
        public TopSpot Post(TopSpot topspot)      
        {
            return topspot;
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
