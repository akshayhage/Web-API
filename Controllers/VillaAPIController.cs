using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using Web_API.Data;
using Web_API.DataAccess;
using Web_API.Models;
using Web_API.Models.Dto;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;   
        }
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(_db.villas.ToList());
        }

        [HttpGet("id:int",Name = "GetVilla")]
        public ActionResult<VillaDTO> GetVilla(int id) 
        {
            if (id <= 0)
                return BadRequest();
            var villa = _db.villas.FirstOrDefault(u => u.Id == id);
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
                return BadRequest();
            Villa villa = new()
            {
                //Id = villaDTO.Id,
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Sqft = villaDTO.Sqft,
                CreatedTime=DateTime.Now
            };
            _db.villas.Add(villa);
            _db.SaveChanges();
            return CreatedAtRoute("GetVilla",new {id = villaDTO.Id },villaDTO);
            //return Ok(villaDTO);
        }

        [HttpDelete("id:int",Name ="DeleteVilla")]
        public IActionResult DeleteVilla(int id)
        {
            if (id==null&& id>0)
                return BadRequest();
            var villa = _db.villas.FirstOrDefault(u => u.Id == id);
            if (villa == null)
                return NotFound();
            _db.villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }


        [HttpPut("id:int",Name ="UpdateVilla")]
        public IActionResult UpdateVilla(int id,[FromBody]VillaDTO villaDTO)
        {
            if (id == null && id!=villaDTO.Id )
                return BadRequest();

            Villa model = new()
            {
                Id = id,
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Sqft = villaDTO.Sqft,
                CreatedTime = DateTime.Now
            };
            _db.villas.Update(model);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPatch("id:int",Name = "UpdatePartialVilla")]

        public IActionResult UpdatePartialVilla(int id,JsonPatchDocument<VillaDTO> patchDTO)
        {
            if(patchDTO==null&&id==0)
            {
                return BadRequest();    
            }
            var villa = _db.villas.FirstOrDefault(u => u.Id == id);
            VillaDTO villaDTO = new()
            {
                Id = villa.Id,
                Name = villa.Name,
                Occupancy=villa.Occupancy,
                Sqft = villa.Sqft

            };

            if(villa==null)
              return NotFound();
            patchDTO.ApplyTo(villaDTO, ModelState);

            Villa model = new()
            {
                Id = id,
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Sqft = villaDTO.Sqft,
                CreatedTime = DateTime.Now
            };
            _db.villas.Update(model);
            _db.SaveChanges();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return NoContent();
        }
    }
}
