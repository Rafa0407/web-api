using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.Communication.AdmisionResponse
{
    public class AdmisionResponse : BaseResponse
    {
        public Admision Admision { get; private set; }

        private AdmisionResponse(bool success, string message, Admision admision) : base(success, message)
        {
            Admision = admision;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="admision">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public AdmisionResponse(Admision admision) : this(true, string.Empty, admision)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public AdmisionResponse(string message) : this(false, message, null)
        { }
    }
}
