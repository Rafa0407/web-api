using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Resources.PacientesResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        // for all the ModelToResourceProfile
        public ModelToResourceProfile()
        {
            // we create a map between the Category model class and the CategoryResource
            CreateMap<Pacientes, PacientesResources>();
            CreateMap<DatosPadres, DatosPadresResource>();
        }
    }
}
