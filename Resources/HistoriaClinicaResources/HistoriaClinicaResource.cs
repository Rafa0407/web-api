using ECHO_API.Resources.HistoriaClinicaResources.AlergiasResource;
using ECHO_API.Resources.HistoriaClinicaResources.ExamenesFisicoResource;
using ECHO_API.Resources.UsuariosResource;
using System;
using System.Collections.Generic;

namespace ECHO_API.Resources.HistoriaClinicaResources
{
    public class HistoriaClinicaResource
    {
        public int IdIhistoriaClinica { get; set; }
        public int? Internamiento { get; set; }
        public DateTime? FechaHistoria { get; set; }
        public int? CreadoPor { get; set; }
        public string Servicio { get; set; }
        public int? Peso { get; set; }
        public short? Talla { get; set; }
        public bool? EstadoVacunacion { get; set; }
        public string Afh { get; set; }
        public string App { get; set; }
        public string Aqxt { get; set; }
        public string Ago { get; set; }
        public string TratamientoActual { get; set; }
        public string OtrosDatos { get; set; }
        public string EstadoNeurológico { get; set; }
        public string Oftalmológico { get; set; }
        public string Cuello { get; set; }
        public string Orl { get; set; }
        public string PaladarDentadura { get; set; }
        public string Cardiaco { get; set; }
        public string ToraxPulmonar { get; set; }
        public string Abdomen { get; set; }
        public string Extremidades { get; set; }
        public string Pulsos { get; set; }
        public string PielAnexos { get; set; }
        public string TactoVaginal { get; set; }
        public string TactoRectal { get; set; }

        public virtual UsuarioResource CreadoPorNavigation { get; set; }
        public virtual ICollection<AlergiaResource> Alergias { get; set; }
        public virtual ICollection<ExamenFisicoResource> ExamenFisico { get; set; }
    }
}
