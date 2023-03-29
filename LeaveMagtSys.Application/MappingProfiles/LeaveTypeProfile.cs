using AutoMapper;
using LeaveMagtSys.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using LeaveMagtSys.Domain;

namespace LeaveMagtSys.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
        }
    }
}
