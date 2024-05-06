using AutoMapper;
using ghabzinow.Models;
using ghabzinow.ViewModel.user;
using System;

namespace ghabzinow.Helpers.AutoMapper
{
    public class ProfileAutomapper:Profile
    {
        public ProfileAutomapper()
        {
            CreateMap<RigisterDto, User>().ReverseMap();

        }
    }
}
