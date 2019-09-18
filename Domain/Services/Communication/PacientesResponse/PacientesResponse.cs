using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.Communication.PacientesResponse
{
    public class PacientesResponse : BaseResponse
    {
        public Pacientes Pacientes { get; private set; }

        private PacientesResponse(bool success, string message, Pacientes pacientes) : base(success, message)
        {
            Pacientes = pacientes;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="pacientes">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public PacientesResponse(Pacientes pacientes) : this(true, string.Empty, pacientes)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public PacientesResponse(string message) : this(false, message, null)
        { }
    }
}
