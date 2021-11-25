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
    public class VisaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public VisaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<VisasController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetVisas()
        {
            try
            {
                var Visas = await _unitOfWork.Visas.GetAll();
             
                return Ok(Visas);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<VisasController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVisa(int id)
        {
            try
            {
                var Visa = await _unitOfWork.Visas.GetT(q => q.Id == id);
                return Ok(Visa);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<VisasController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateVisa([FromBody] Visa Visa)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.Visas.Insert(Visa);
                await _unitOfWork.Save();

                return CreatedAtAction("GetVisa", new { id = Visa.Id }, Visa);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<VisasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVisa(int id, [FromBody] VisaDTO Visa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalVisa = await _unitOfWork.Visas.GetT(q => q.Id == id);

                if (originalVisa == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(Visa, originalVisa);
                _unitOfWork.Visas.Update(originalVisa);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<VisasController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteVisa(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var Visa = await _unitOfWork.Visas.GetT(q => q.Id == id);

                if (Visa == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Visas.Delete(id);
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
