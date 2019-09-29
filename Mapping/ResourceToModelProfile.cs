using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Resources.AcompannanteResource;
using ECHO_API.Resources.AdmisionResource;
using ECHO_API.Resources.HistoriaClinicaResources;
using ECHO_API.Resources.HistoriaClinicaResources.AlergiasResource;
using ECHO_API.Resources.HistoriaClinicaResources.ExamenesFisicoResource;
using ECHO_API.Resources.HistoriaClinicaResources.TiposAlergiasResources;
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
            CreateMap<SaveAdmisionResource, Admision>();
            CreateMap<UpdateAdmisionResource, Admision>();
            CreateMap<SaveAcompannanteResource, AcompannantePaciente>();
            CreateMap<SaveHistoriaClinicaResource, HistoriaClinica>();
            CreateMap<SaveAlergiaResource, Alergias>();
            CreateMap<SaveTipoAlergiasResource, TipoAlergias>();
            CreateMap<SaveExamenFisicoResource, ExamenFisico>();
        }
    }
}
