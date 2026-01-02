using AutoMapper;
using BusinessLogic.DTOs.Question;
using BusinessLogic.VeiwModels.Question;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Mapping
{
    public class QuistionProfile : Profile
    {
        public QuistionProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Question, AllQuestionsDto>()
                .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(src => src.ID))
                .ReverseMap();
            CreateMap<Question, QuestionsDto>()
                .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices))
                .ReverseMap();
            CreateMap<Question, UpdateQuestionsDto>().ReverseMap();
            CreateMap<Question, AddQuestionsDto>().ReverseMap();


            CreateMap<AllQuestionsDto, AllQuestionsViewModel>().ReverseMap();
            CreateMap<QuestionsDto, QuestionViewModel>().ReverseMap();
            CreateMap<UpdateQuestionsDto, UpdateQuestionViewModel>().ReverseMap();
            CreateMap<AddQuestionsDto, AddQuestionViewModel>().ReverseMap();
        }   
    }
}
