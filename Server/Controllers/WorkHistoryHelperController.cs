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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkHistoryHelperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkHistoryHelperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<WorkHistoryHelperController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWorkHistoryHelper()
        {
            try
            {
                var WorkHistoryHelper = await _unitOfWork.WorkHistoryHelpers.GetAll();
             
                return Ok(WorkHistoryHelper);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<WorkHistoryHelperController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWorkHistoryHelper(int id)
        {
            try
            {
                var WorkHistoryHelper = await _unitOfWork.WorkHistoryHelpers.GetT(q => q.Id == id);
                return Ok(WorkHistoryHelper);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<WorkHistoryHelperController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateWorkHistoryHelper([FromBody] WorkHistoryHelper WorkHistoryHelper)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.WorkHistoryHelpers.Insert(WorkHistoryHelper);
                await _unitOfWork.Save();

                return CreatedAtAction("GetWorkHistoryHelper", new { id = WorkHistoryHelper.Id }, WorkHistoryHelper);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<WorkHistoryHelperController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorkHistoryHelper(int id, [FromBody] WorkHistoryHelper WorkHistoryHelper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalWorkHistoryHelper = await _unitOfWork.WorkHistoryHelpers.GetT(q => q.Id == id);

                if (originalWorkHistoryHelper == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                _unitOfWork.WorkHistoryHelpers.Update(originalWorkHistoryHelper);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<WorkHistoryHelperController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteWorkHistoryHelper(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var WorkHistoryHelper = await _unitOfWork.WorkHistoryHelpers.GetT(q => q.Id == id);

                if (WorkHistoryHelper == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.WorkHistoryHelpers.Delete(id);
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
