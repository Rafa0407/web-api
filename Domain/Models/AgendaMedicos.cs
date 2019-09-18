using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AgendaMedicos
    {
        public AgendaMedicos()
        {
            MotivosConsultaAgenda = new HashSet<MotivosConsultaAgenda>();
        }

        public int IdAgenda { get; set; }
        public short IdMedico { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPaciente { get; set; }
        public int IdEspecialidad { get; set; }
        public bool? Cancelada { get; set; }
        public bool? Atendido { get; set; }
        public string Usuario { get; set; }
        public bool? Presente { get; set; }
        public DateTime? HoraPresente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Tiempo { get; set; }
        public bool? Sms { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificador { get; set; }
        public string UsuarioCancela { get; set; }
        public string MotivoCancelacion { get; set; }
        public string UsuarioConfirma { get; set; }
        public DateTime? FechaConfirma { get; set; }
        public bool? Confirmada { get; set; }
        public string CodMedRed { get; set; }
        public string NombreMedRed { get; set; }
        public DateTime? FechaCancela { get; set; }
        public bool? SmsEmail { get; set; }
        public int IdParqueo { get; set; }

        public virtual Medicos IdMedicoNavigation { get; set; }
        public virtual Pacientes IdPacienteNavigation { get; set; }
        public virtual ConsultaMedica ConsultaMedica { get; set; }
        public virtual ICollection<MotivosConsultaAgenda> MotivosConsultaAgenda { get; set; }
    }
}
