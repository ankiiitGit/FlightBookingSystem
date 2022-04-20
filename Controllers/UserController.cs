using AutoMapper;
using FlightBookingSystem.DataModels;
using FlightBookingSystem.Models;
using FlightBookingSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _repo;
        private IMapper _mapper;

        public UserController(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpPost]
        [Route("GetFlights")]
        public IActionResult GetFlights([FromBody] FlightInfoDataModel flightInfo)
        {
            FlightInfo flight = _mapper.Map<FlightInfo>(flightInfo);
            return Ok(_repo.GetFlights(flight));
        }

        // GET: api/<UserController>
        [HttpGet("GetTicketBookings/{email}")]      //[HttpGet("{email}")]        
        public IActionResult GetTicketBookings(string email)
        {            
            return Ok(_repo.GetTicketBookings(email));
        }

        // GET: api/<UserController>
        [HttpGet("GetTicketBookingPNR/{pnr}")]        //[HttpGet("{pnr}")]        
        public IActionResult GetTicketBookingPNR(string pnr)
        {
            return Ok(_repo.GetTicketBookingPNR(pnr));
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] TicketBookingDataModel newTicket) //CreateAirline
        {
            if (ModelState.IsValid)
            {
                TicketBooking existingBooking = _mapper.Map<TicketBooking>(newTicket);
                var booking = _repo.CreateTicket(existingBooking);
                return StatusCode(201, booking);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{bookingId}")]
        public IActionResult Put([FromBody] int bookingId) //Update -- CancelTicketBooking
        {
            if (ModelState.IsValid)
            {
                var ticket = _repo.CancelTicketBooking(bookingId);
                if (ticket == null) return NoContent();
                else return StatusCode(201, ticket);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
