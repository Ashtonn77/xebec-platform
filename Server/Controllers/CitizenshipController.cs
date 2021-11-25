using AutoMapper;
using Server.Data;
using Server.IRepository;
using XebecPortal.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Server.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizenshipController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public CitizenshipController(IUnitOfWork unitOfWork, IMapper mapper)
        {

            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<CitizenshipsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCitizenships()
        {
            try
            {
                var Citizenships = await _unitOfWork.Citizenships.GetAll();
             
                return Ok(Citizenships);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<CitizenshipsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCitizenship(int id)
        {
            try
            {
                var Citizenship = await _unitOfWork.Citizenships.GetT(q => q.Id == id);
                return Ok(Citizenship);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<CitizenshipsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCitizenship([FromBody] Citizenship Citizenship)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.Citizenships.Insert(Citizenship);
                await _unitOfWork.Save();

                return CreatedAtAction("GetCitizenship", new { id = Citizenship.Id }, Citizenship);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<CitizenshipsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCitizenship(int id, [FromBody] CitizenshipDTO Citizenship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalCitizenship = await _unitOfWork.Citizenships.GetT(q => q.Id == id);

                if (originalCitizenship == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(Citizenship, originalCitizenship);
                _unitOfWork.Citizenships.Update(originalCitizenship);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<CitizenshipsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteCitizenship(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var Citizenship = await _unitOfWork.Citizenships.GetT(q => q.Id == id);

                if (Citizenship == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Citizenships.Delete(id);
                await _unitOfWork.Save();

                return NoContent();


            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }
    }
}
