using AutoMapper;
using CoreCodeCamp.Models;
using CoreCodeCamp.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                //.ForMember(dest => dest.Venue, x => x.MapFrom(model => model.Location.VenueName))
                .ReverseMap();

            this.CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(t => t.Camp, ops => ops.Ignore())
                .ForMember(t => t.Speaker, ops => ops.Ignore());

            this.CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
                



        }
    }
}
