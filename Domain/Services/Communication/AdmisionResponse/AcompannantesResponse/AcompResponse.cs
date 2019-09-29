using ECHO_API.Domain.Models;

namespace ECHO_API.Domain.Services.Communication.AdmisionResponse.AcompannantesResponse
{
    public class AcompResponse : BaseResponse
    {

        public AcompannantePaciente Acompannante { get; private set; }
        private AcompResponse(bool success, string message, AcompannantePaciente acompannante) : base(success, message)
        {
            Acompannante = acompannante;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="acompannante">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public AcompResponse(AcompannantePaciente acompannante) : this(true, string.Empty, acompannante)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public AcompResponse(string message) : this(false, message, null)
        { }
    }
}
