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
    public class DocumentHelperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentHelperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<DocumentHelperController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDocumentHelper()
        {
            try
            {
                var DocumentHelper = await _unitOfWork.DocumentHelper.GetAll();
             
                return Ok(DocumentHelper);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<DocumentHelperController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDocumentHelper(int id)
        {
            try
            {
                var DocumentHelper = await _unitOfWork.DocumentHelper.GetT(q => q.Id == id);
                return Ok(DocumentHelper);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<DocumentHelperController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDocumentHelper([FromBody] DocumentHelper DocumentHelper)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.DocumentHelper.Insert(DocumentHelper);
                await _unitOfWork.Save();

                return CreatedAtAction("GetDocumentHelper", new { id = DocumentHelper.Id }, DocumentHelper);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<DocumentHelperController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDocumentHelper(int id, [FromBody] DocumentHelper DocumentHelper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalDocumentHelper = await _unitOfWork.DocumentHelper.GetT(q => q.Id == id);

                if (originalDocumentHelper == null)
                {
                    return BadRequest("Submitted data is invalid");
                }
                _unitOfWork.DocumentHelper.Update(originalDocumentHelper);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<DocumentHelperController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteDocumentHelper(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var DocumentHelper = await _unitOfWork.DocumentHelper.GetT(q => q.Id == id);

                if (DocumentHelper == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.DocumentHelper.Delete(id);
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
