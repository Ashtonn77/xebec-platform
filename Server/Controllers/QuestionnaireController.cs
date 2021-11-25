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
    public class QuestionnaireController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public QuestionnaireController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        // GET: api/<QuestionnairesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetQuestionnaires()
        {
            try
            {
                var Questionnaires = await _unitOfWork.Questnionnaires.GetAll();
             
                return Ok(Questionnaires);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<QuestionnairesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetQuestionnaire(int id)
        {
            try
            {
                var Questionnaire = await _unitOfWork.Questnionnaires.GetT(q => q.Id == id);
                return Ok(Questionnaire);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<QuestionnairesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateQuestionnaire([FromBody] Questionnaire Questionnaire)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {

                await _unitOfWork.Questnionnaires.Insert(Questionnaire);
                await _unitOfWork.Save();

                return CreatedAtAction("GetQuestionnaire", new { id = Questionnaire.Id }, Questionnaire);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }

        }


        // PUT api/<QuestionnairesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuestionnaire(int id, [FromBody] QuestionnaireDTO Questionnaire)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalQuestionnaire = await _unitOfWork.Questnionnaires.GetT(q => q.Id == id);

                if (originalQuestionnaire == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                mapper.Map(Questionnaire, originalQuestionnaire);
                _unitOfWork.Questnionnaires.Update(originalQuestionnaire);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<QuestionnairesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteQuestionnaire(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var Questionnaire = await _unitOfWork.Questnionnaires.GetT(q => q.Id == id);

                if (Questionnaire == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Questnionnaires.Delete(id);
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
