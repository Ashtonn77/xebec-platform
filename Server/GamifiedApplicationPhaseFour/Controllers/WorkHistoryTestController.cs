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
using XebecPortal.Shared.NewGamifiedDtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.GamifiedApplicationPhaseFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkHistoryTestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public WorkHistoryTestController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<WorkHistoryController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWorkHistories()
        {
            try
            {
                var WorkHistory = await _unitOfWork.WorkHistoryTests.GetAll();
             
                return Ok(WorkHistory);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("all/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWorksByAppUserId(int id)
        {
            try
            {
                var WorkHistories = await _unitOfWork.WorkHistoryTests.GetAll(q => q.AppUserId == id);
             
                return Ok(WorkHistories);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        
        [HttpGet("single/{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSingleWorkHistoryById(int id)
        {
            try
            {
                var WorkHistory = await _unitOfWork.WorkHistoryTests.GetT(q => q.Id == id);                
                return Ok(WorkHistory);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        //get by appuserid
        // GET api/<WorkHistoryController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWorkHistory(int id)
        {
            try
            {
                var WorkHistory = await _unitOfWork.WorkHistoryTests.GetT(q => q.AppUserId == id);
                return Ok(WorkHistory);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<WorkHistoryController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateWorkHistory([FromBody] WorkHistoryTest WorkHistory)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.WorkHistoryTests.Insert(WorkHistory);
                await _unitOfWork.Save();

                return CreatedAtAction("GetWorkHistory", new { id = WorkHistory.Id }, WorkHistory);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<WorkHistoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorkHistory(int id, [FromBody] WorkHistoryTestDto WorkHistory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalWorkHistory = await _unitOfWork.WorkHistoryTests.GetT(q => q.Id == id);

                if (originalWorkHistory == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                mapper.Map(WorkHistory, originalWorkHistory);
                _unitOfWork.WorkHistoryTests.Update(originalWorkHistory);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<WorkHistoryController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteWorkHistory(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var WorkHistory = await _unitOfWork.WorkHistoryTests.GetT(q => q.Id == id);

                if (WorkHistory == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.WorkHistoryTests.Delete(id);
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
