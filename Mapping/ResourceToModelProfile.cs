using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Resources.InternamientosResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        // for all the resourcesToModelProfile
        public ResourceToModelProfile()
        {
            CreateMap<SaveInternamientosResource, Internamientos>();
        }
    }
}
