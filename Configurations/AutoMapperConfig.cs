using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FlightBookingSystem.DataModels;
using FlightBookingSystem.Models;

namespace FlightBookingSystem.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserDataModel>().ReverseMap();
            CreateMap<Admin, AdminDataModel>().ReverseMap();
            CreateMap<Airline, AirlineDataModel>().ReverseMap();
            CreateMap<Passenger, PassengerDataModel>().ReverseMap();
            CreateMap<FlightInfo, FlightInfoDataModel>().ReverseMap();
            CreateMap<TicketBooking, TicketBookingDataModel>().ReverseMap();
        }
    }
}
