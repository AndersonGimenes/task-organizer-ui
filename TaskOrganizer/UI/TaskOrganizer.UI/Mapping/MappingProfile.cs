using AutoMapper;
using TaskOrganizer.UI.Models;
using TaskOrganizer.UI.Proxy.Entities;

namespace TaskOrganizer.UI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApiTaskResponse, TaskModel>()
                .ForMember( dest => dest.TaskNumber, src => src.MapFrom( x => x.TaskResponse.TaskNumber))
                .ForMember( dest => dest.Title, src => src.MapFrom( x => x.TaskResponse.Title))
                .ForMember( dest => dest.Description, src => src.MapFrom( x => x.TaskResponse.Description))
                .ForMember( dest => dest.Progress, src => src.MapFrom( x => x.TaskResponse.Progress))
                .ForMember( dest => dest.EstimatedDate, src => src.MapFrom( x => x.TaskResponse.EstimatedDate))
                .ForMember( dest => dest.CreateDate, src => src.MapFrom( x => x.TaskResponse.CreateDate));
        }
    }
}