using Microsoft.AspNetCore.Mvc;
using prj.Helper.ServiceHelper.Model;
using prj.Helper.Services.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prj.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDataController : ControllerBase
    {
        private readonly IMasterData _maserData;
        public MasterDataController(IMasterData maserData)
        {
             _maserData= maserData;

        }
        // GET: api/<MasterData>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                       
                return Ok(  await _maserData.GetList());

               
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET api/<MasterData>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MasterData>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MasterData>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MasterData>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
