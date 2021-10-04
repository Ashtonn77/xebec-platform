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
    public class EducationHelperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EducationHelperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<EducationHelperController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEducationHelper()
        {
            try
            {
                var EducationHelper = await _unitOfWork.EducationHelpers.GetAll();
             
                return Ok(EducationHelper);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<EducationHelperController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetEducationHelper(int id)
        {
            try
            {
                var EducationHelper = await _unitOfWork.EducationHelpers.GetT(q => q.Id == id);
                return Ok(EducationHelper);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<EducationHelperController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEducationHelper([FromBody] EducationHelper EducationHelper)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.EducationHelpers.Insert(EducationHelper);
                await _unitOfWork.Save();

                return CreatedAtAction("GetEducationHelper", new { id = EducationHelper.Id }, EducationHelper);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<EducationHelperController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEducationHelper(int id, [FromBody] EducationHelper EducationHelper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalEducationHelper = await _unitOfWork.EducationHelpers.GetT(q => q.Id == id);

                if (originalEducationHelper == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                _unitOfWork.EducationHelpers.Update(originalEducationHelper);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<EducationHelperController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEducationHelper(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var EducationHelper = await _unitOfWork.EducationHelpers.GetT(q => q.Id == id);

                if (EducationHelper == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.EducationHelpers.Delete(id);
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
