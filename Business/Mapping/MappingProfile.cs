using AutoMapper;
using Entities;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegisterDto, User>().ReverseMap();
            CreateMap<SubjectDto, Subject>().ReverseMap();
            CreateMap<ArticleDto, Article>().ReverseMap();
        }
    }
}
