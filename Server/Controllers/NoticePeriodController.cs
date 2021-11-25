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
    public class NoticePeriodController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public NoticePeriodController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<NoticePeriodsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetNoticePeriods()
        {
            try
            {
                var NoticePeriods = await _unitOfWork.NoticePeriods.GetAll();
             
                return Ok(NoticePeriods);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<NoticePeriodsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetNoticePeriod(int id)
        {
            try
            {
                var NoticePeriod = await _unitOfWork.NoticePeriods.GetT(q => q.Id == id);
                return Ok(NoticePeriod);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<NoticePeriodsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateNoticePeriod([FromBody] NoticePeriod NoticePeriod)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.NoticePeriods.Insert(NoticePeriod);
                await _unitOfWork.Save();

                return CreatedAtAction("GetNoticePeriod", new { id = NoticePeriod.Id }, NoticePeriod);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<NoticePeriodsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNoticePeriod(int id, [FromBody] NoticePeriodDTO NoticePeriod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalNoticePeriod = await _unitOfWork.NoticePeriods.GetT(q => q.Id == id);

                if (originalNoticePeriod == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(NoticePeriod, originalNoticePeriod);
                _unitOfWork.NoticePeriods.Update(originalNoticePeriod);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<NoticePeriodsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteNoticePeriod(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var NoticePeriod = await _unitOfWork.NoticePeriods.GetT(q => q.Id == id);

                if (NoticePeriod == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.NoticePeriods.Delete(id);
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
