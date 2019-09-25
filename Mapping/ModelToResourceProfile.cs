using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Resources.AdmisionResource;
using ECHO_API.Resources.FuncionPersonalIntr;
using ECHO_API.Resources.InternamientosResource;
using ECHO_API.Resources.MedicosResource;
using ECHO_API.Resources.PacientesResource;
using ECHO_API.Resources.PersonalInternamientoResource;
using ECHO_API.Resources.UsuariosResource;
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
            CreateMap<Internamientos, InternamientoResource>();
            CreateMap<Usuarios, UsuarioResource>();
            CreateMap<Medicos, MedicoResource>();
            CreateMap<Admision, AdmisionResource>();
            CreateMap<PersonalInternamiento, PersonalIntrResource>();
            CreateMap<FuncionPersonalInternamiento, FunPersInterResource>();
        }
    }
}
