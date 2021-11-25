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
    public class WorkPermitController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public WorkPermitController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<WorkPermitsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWorkPermits()
        {
            try
            {
                var WorkPermits = await _unitOfWork.WorkPermits.GetAll();
             
                return Ok(WorkPermits);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<WorkPermitsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWorkPermit(int id)
        {
            try
            {
                var WorkPermit = await _unitOfWork.WorkPermits.GetT(q => q.Id == id);
                return Ok(WorkPermit);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<WorkPermitsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateWorkPermit([FromBody] WorkPermit WorkPermit)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.WorkPermits.Insert(WorkPermit);
                await _unitOfWork.Save();

                return CreatedAtAction("GetWorkPermit", new { id = WorkPermit.Id }, WorkPermit);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<WorkPermitsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorkPermit(int id, [FromBody] WorkPermitDTO WorkPermit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalWorkPermit = await _unitOfWork.WorkPermits.GetT(q => q.Id == id);

                if (originalWorkPermit == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(WorkPermit, originalWorkPermit);
                _unitOfWork.WorkPermits.Update(originalWorkPermit);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<WorkPermitsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteWorkPermit(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var WorkPermit = await _unitOfWork.WorkPermits.GetT(q => q.Id == id);

                if (WorkPermit == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.WorkPermits.Delete(id);
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
