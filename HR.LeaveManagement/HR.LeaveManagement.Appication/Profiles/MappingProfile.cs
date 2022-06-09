using AutoMapper;
using HR.LeaveManagement.Appication.DTOs;
using HR.LeaveManagement.Appication.DTOs.LeaveRequest;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Appication.MappingProfile 
{
    public class MappingProfile : Profile
    {

      public MappingProfile()
        { 
            CreateMap <LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap <LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap <LeaveType, LeaveTypeDto>().ReverseMap();

        }
    }
}
