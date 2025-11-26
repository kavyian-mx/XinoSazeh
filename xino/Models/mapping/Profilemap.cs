using AutoMapper;
using ENDPOINTs.Models.DTOs;
using xino.DEL.Entity;

namespace ENDPOINTs.Models.mapping;

    public class Profilemap:Profile
    {
        public Profilemap()
        {
        CreateMap<ConsultationCreateDto, Consultation>();
        CreateMap<Consultation, ConsultationlistDTO>();
        CreateMap<ConsultationIsCheck, Consultation>();
        

        CreateMap<CurriculumVitaeCreateDto, CurriculumVitae>();
        CreateMap<CurriculumVitae, CurriculumVitaeListDto>();
        CreateMap<CurriculumVitaeIsCkeck, CurriculumVitae>();


        CreateMap<AdminCreateDTOs, Admin>();
        CreateMap<AdminEditDTOs, Admin>();
        CreateMap<Admin, AdminListDTOs>();





        CreateMap<BlugCreateDTOs, blug>();
        CreateMap<BlugEditDTOs, blug>();
        CreateMap<blug, BlugListDTOs>();



        CreateMap<InteriorDecorationCreateDTOs, InteriorDecoration>();
        CreateMap<InteriorDecorationEditDTOs, InteriorDecoration>();
        CreateMap<InteriorDecoration, InteriorDecorationListDTOs>();



        CreateMap<ProjectCreateDTOs, Project>();
        CreateMap<ProjectEditDTOs, Project>();
        CreateMap<Project, ProjectListDTOs>();





        }
    }

