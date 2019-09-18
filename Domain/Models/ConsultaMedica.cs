using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class ConsultaMedica
    {
        public ConsultaMedica()
        {
            FacturasEncabezado = new HashSet<FacturasEncabezado>();
            PlanCitas = new HashSet<PlanCitas>();
            RecetasMedicas = new HashSet<RecetasMedicas>();
            SolicitudExamenes = new HashSet<SolicitudExamenes>();
        }

        public int IdConsulta { get; set; }
        public int? IdCaso { get; set; }
        public int IdAgenda { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Presion { get; set; }
        public int? Estatura { get; set; }
        public decimal? Peso { get; set; }
        public string ExamenFisico { get; set; }
        public string Gpac { get; set; }
        public string E { get; set; }
        public DateTime? Fur { get; set; }
        public DateTime? Fpp { get; set; }
        public string Eg { get; set; }
        public DateTime? FechaProxCita { get; set; }
        public bool? ProgramarCita { get; set; }
        public int ProgramarCitaDias { get; set; }
        public bool? ProgramadaCita { get; set; }
        public bool? RecetaImpresa { get; set; }
        public string UsuarioImpReceta { get; set; }
        public string DescripcionMotivoConsulta { get; set; }

        public virtual AgendaMedicos IdAgendaNavigation { get; set; }
        public virtual ICollection<FacturasEncabezado> FacturasEncabezado { get; set; }
        public virtual ICollection<PlanCitas> PlanCitas { get; set; }
        public virtual ICollection<RecetasMedicas> RecetasMedicas { get; set; }
        public virtual ICollection<SolicitudExamenes> SolicitudExamenes { get; set; }
    }
}
