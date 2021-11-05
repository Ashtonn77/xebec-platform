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
    public class ProfilePortfolioLinkController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfilePortfolioLinkController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ProfilePortfolioLinksController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProfilePortfolioLinks()
        {
            try
            {
                var ProfilePortfolioLinks = await _unitOfWork.ProfilePortfolioLinks.GetAll();

                return Ok(ProfilePortfolioLinks);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<ProfilePortfolioLinksController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProfilePortfolioLink(int id)
        {
            try
            {
                var ProfilePortfolioLink = await _unitOfWork.ProfilePortfolioLinks.GetT(q => q.Id == id);
                return Ok(ProfilePortfolioLink);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<ProfilePortfolioLinksController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProfilePortfolioLink([FromBody] ProfilePortfolioLink profilePortfolioLink)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {
              

                await _unitOfWork.ProfilePortfolioLinks.Insert(profilePortfolioLink);
                await _unitOfWork.Save();

                return CreatedAtAction("GetProfilePortfolioLink", new { id = profilePortfolioLink.Id }, profilePortfolioLink);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<ProfilePortfolioLinksController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, [FromBody] ProfilePortfolioLink profilePortfolioLink)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalProfilePortfolioLink = await _unitOfWork.ProfilePortfolioLinks.GetT(q => q.Id == id);

                if (originalProfilePortfolioLink == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                _unitOfWork.ProfilePortfolioLinks.Update(originalProfilePortfolioLink);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<ProfilePortfolioLinksController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProfilePortfolioLink(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var profilePortfolioLink = await _unitOfWork.ProfilePortfolioLinks.GetT(q => q.Id == id);

                if (profilePortfolioLink == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.ProfilePortfolioLinks.Delete(id);
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
