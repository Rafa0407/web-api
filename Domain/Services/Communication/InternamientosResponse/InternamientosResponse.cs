using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.Communication.InternamientosResponse
{
    public class InternamientosResponse : BaseResponse
    {
        public Internamientos Internamientos { get; private set; }

        private InternamientosResponse(bool success, string message, Internamientos internamientos) : base(success, message)
        {
            Internamientos = internamientos;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="internamientos">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public InternamientosResponse(Internamientos internamientos) : this(true, string.Empty, internamientos)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public InternamientosResponse(string message) : this(false, message, null)
        { }
    }
}
