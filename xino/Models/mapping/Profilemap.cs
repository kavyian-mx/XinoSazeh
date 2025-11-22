using AutoMapper;
using ENDPOINTs.Models.DTOs;
using xino.DEL.Entity;

namespace ENDPOINTs.Models.mapping;

    public class Profilemap:Profile
    {
        public Profilemap()
        {
        CreateMap<ConsultationCreateDto, Consultation>();

            
        }
    }

