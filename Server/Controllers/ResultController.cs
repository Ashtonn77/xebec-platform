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
    public class ResultController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public ResultController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<ResultsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetResults()
        {
            try
            {
                var Results = await _unitOfWork.Results.GetAll();
             
                return Ok(Results);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<ResultsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetResult(int id)
        {
            try
            {
                var Result = await _unitOfWork.Results.GetT(q => q.Id == id);
                return Ok(Result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<ResultsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateResult([FromBody] Result Result)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.Results.Insert(Result);
                await _unitOfWork.Save();

                return CreatedAtAction("GetResult", new { id = Result.Id }, Result);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<ResultsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResult(int id, [FromBody] ResultDTO Result)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalResult = await _unitOfWork.Results.GetT(q => q.Id == id);

                if (originalResult == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(Result, originalResult);
                _unitOfWork.Results.Update(originalResult);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<ResultsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteResult(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var Result = await _unitOfWork.Results.GetT(q => q.Id == id);

                if (Result == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Results.Delete(id);
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
