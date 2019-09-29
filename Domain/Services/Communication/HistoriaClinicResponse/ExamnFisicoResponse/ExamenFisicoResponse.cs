using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.Communication.HistoriaClinicResponse.ExamnFisicoResponse
{
    public class ExamenFisicoResponse : BaseResponse
    {
        public ExamenFisico ExamenFisico; 

        private ExamenFisicoResponse (bool success, string message, ExamenFisico examenFisico) : base(success, message)
        {
            ExamenFisico = examenFisico;
        }
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="historia">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public ExamenFisicoResponse(ExamenFisico examenFisico) : this(true, string.Empty, examenFisico)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ExamenFisicoResponse(string message) : this(false, message, null)
        { }
    }
}
