using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using Web_API.Data;
using Web_API.Models;
using Web_API.Models.Dto;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("id:int",Name = "GetVilla")]
        public ActionResult<VillaDTO> GetVilla(int id) 
        {
            if (id <= 0)
                return BadRequest();
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if(villa== null)
                return NotFound();
            return Ok(villa);
        }

        [HttpPost]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO) 
        {
            if(villaDTO == null)
                return BadRequest();
            if (villaDTO.Id > 0)
                return StatusCode(StatusCodes.Status500InternalServerError);
            
            villaDTO.Id=VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id+1;
            VillaStore.villaList.Add(villaDTO);
            return CreatedAtRoute("GetVilla",new {id = villaDTO.Id },villaDTO);
        }

        



    }
}
