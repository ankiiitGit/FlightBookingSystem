using AutoMapper;
using FlightBookingSystem.DataModels;
using FlightBookingSystem.Models;
using FlightBookingSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        IAdminRepository _repo;
        private IMapper _mapper;

        public AdminController(IAdminRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }        

        // GET api/<AdminController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<AdminController>
        [HttpPost]
        [Route("CreateAirline")]
        public IActionResult CreateAirline([FromBody] AirlineDataModel newAirline) //CreateAirline
        {
            if(ModelState.IsValid)
            {
                Airline existingAirline = _mapper.Map<Airline>(newAirline);
                var airline = _repo.CreateAirline(existingAirline);
                return StatusCode(201, airline);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // POST api/<AdminController>
        [HttpPost]
        [Route("CreateFlightInfo")]
        public IActionResult CreateFlightInfo([FromBody] FlightInfoDataModel newFlight) //CreateFlightInfo
        {
            if (ModelState.IsValid)
            {
                FlightInfo existingFlight = _mapper.Map<FlightInfo>(newFlight);
                var flightinfo = _repo.CreateFlightInfo(existingFlight);
                return StatusCode(201, flightinfo);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<AdminController>/5
        [HttpPut("{airlineId}")]
        public IActionResult Put([FromRoute] int airlineId) //Update
        {
            if (ModelState.IsValid)
            {
                var airline = _repo.BlockAirline(airlineId);
                if (airline == null) return NoContent();
                else return StatusCode(201, airline);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // GET: api/<AdminController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAirlines());
        }



        // DELETE api/<AdminController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
