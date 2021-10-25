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
using XebecPortal.Shared.NewGamifiedModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalsTestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonalsTestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        } 

        // GET: api/<PersonalInformationController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPersonalInformation()
        {
            try
            {
                var PersonalInformation = await _unitOfWork.PersonalTestInfos.GetAll();
             
                return Ok(PersonalInformation);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<PersonalInformationController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonalInformation(int id)
        {
            try
            {
                var PersonalInformation = await _unitOfWork.PersonalTestInfos.GetT(q => q.Id == id);
                return Ok(PersonalInformation);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<PersonalInformationController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePersonalInformation([FromBody] PersonalTestInfo PersonalInformation)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.PersonalTestInfos.Insert(PersonalInformation);
                await _unitOfWork.Save();

                return CreatedAtAction("GetPersonalInformation", new { id = PersonalInformation.Id }, PersonalInformation);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<PersonalInformationController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonalInformation(int id, [FromBody] PersonalTestInfo PersonalInformation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalPersonalInformation = await _unitOfWork.PersonalTestInfos.GetT(q => q.Id == id);

                if (originalPersonalInformation == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                _unitOfWork.PersonalTestInfos.Update(originalPersonalInformation);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<PersonalInformationController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePersonalInformation(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var PersonalInformation = await _unitOfWork.PersonalTestInfos.GetT(q => q.Id == id);

                if (PersonalInformation == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.PersonalTestInfos.Delete(id);
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
