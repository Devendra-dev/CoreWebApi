using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Resources;
using MeetingRoomApi.Domain.Models;

namespace MeetingRoomApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveMeetingRoomResource, Meeting_Room>();
        }
    }
}
