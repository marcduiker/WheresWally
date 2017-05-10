using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WheresWally.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class FaceController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            // Find images in webpage

            //      Limit the images to be of a certain pixel size.

            //      Put image links on an image-queue

            //      Read from image-queue and submit image to Face API to verify if it contains a face

            //          If the image contains a face

            //              Put image on faces-queue

            //              Read from face-queue Submit face-image to Face API if it contains a specific face

            //                  If the image contains a specific face 

            //                      Put the image in blobstorage.
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
