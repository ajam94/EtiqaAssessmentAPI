using EtiqaAssessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EtiqaAssessment.Controllers
{
    [Route("api")]
    [ApiController]
    public class FreelancersController : ControllerBase
    {
        private readonly FreelancersContext _dbFreelancers;

        public FreelancersController(FreelancersContext dbFreelancers)
        {
            _dbFreelancers = dbFreelancers;
        }

        [HttpGet("GetAllFreelancers")]
        public async Task<ActionResult<IEnumerable<Freelancers>>> GetFreelancers()
        {
            if (_dbFreelancers.Freelancers == null)
            {
                return NotFound();
            }
            return await _dbFreelancers.Freelancers.ToListAsync();
        }

        [HttpGet("GetFreelancerbyID/{id}")]
        public async Task<ActionResult<Freelancers>> GetFreelancerbyID(int id)
        {
            if (_dbFreelancers.Freelancers == null)
            {
                return NotFound();
            }
            var freelancer = await _dbFreelancers.Freelancers.FindAsync(id);
            if (freelancer == null) return NotFound();

            return freelancer;
        }


        [HttpPost("CreateNewFreelancer")]
        public async Task<ActionResult<Freelancers>> PostFreelancer(Freelancers freelancer)
        {
            _dbFreelancers.Freelancers.Add(freelancer);
            await _dbFreelancers.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFreelancerbyID), new { id = freelancer.Id }, freelancer);
        }

        [HttpPut("UpdateFreelancerbyID/{id}")]
        public async Task<IActionResult> PutFreelancer(int id, Freelancers freelancer) 
        {
            if (id != freelancer.Id) return BadRequest();
            _dbFreelancers.Entry(freelancer).State = EntityState.Modified;

            try 
            {
                await _dbFreelancers.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException) 
            {
                if (!FreelancerAvailable(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }

        private bool FreelancerAvailable(int id)
        {
            return (_dbFreelancers.Freelancers?.Any(x => x.Id == id)).GetValueOrDefault();
        }

        [HttpDelete("DeleteFreelancerbyID/{id}")]
        public async Task<IActionResult> DeleteFreelancer(int id)
        {
            if (_dbFreelancers.Freelancers == null) return NotFound();
            var freelancer = await _dbFreelancers.Freelancers.FindAsync(id);
            if (freelancer == null) return NotFound();

            _dbFreelancers.Freelancers.Remove(freelancer);
            await _dbFreelancers.SaveChangesAsync();
            return Ok();
        } 
    }
}