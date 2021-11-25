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
    public class IdealCandidateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public IdealCandidateController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<IdealCandidatesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetIdealCandidates()
        {
            try
            {
                var IdealCandidates = await _unitOfWork.IdealCandidates.GetAll();
             
                return Ok(IdealCandidates);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<IdealCandidatesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetIdealCandidate(int id)
        {
            try
            {
                var IdealCandidate = await _unitOfWork.IdealCandidates.GetT(q => q.Id == id);
                return Ok(IdealCandidate);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<IdealCandidatesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateIdealCandidate([FromBody] IdealCandidate IdealCandidate)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.IdealCandidates.Insert(IdealCandidate);
                await _unitOfWork.Save();

                return CreatedAtAction("GetIdealCandidate", new { id = IdealCandidate.Id }, IdealCandidate);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<IdealCandidatesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIdealCandidate(int id, [FromBody] IdealCandidateDTO IdealCandidate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalIdealCandidate = await _unitOfWork.IdealCandidates.GetT(q => q.Id == id);

                if (originalIdealCandidate == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(IdealCandidate, originalIdealCandidate);
                _unitOfWork.IdealCandidates.Update(originalIdealCandidate);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<IdealCandidatesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteIdealCandidate(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var IdealCandidate = await _unitOfWork.IdealCandidates.GetT(q => q.Id == id);

                if (IdealCandidate == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.IdealCandidates.Delete(id);
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
