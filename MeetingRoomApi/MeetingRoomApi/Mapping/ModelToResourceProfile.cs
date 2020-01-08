using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.Models;
using MeetingRoomApi.Resources;

namespace MeetingRoomApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Meeting_Room, MeetingRoomResource>(); 
        }
    }
}
