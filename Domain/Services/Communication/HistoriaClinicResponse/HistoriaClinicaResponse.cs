using ECHO_API.Domain.Models;


namespace ECHO_API.Domain.Services.Communication.HistoriaClinicResponse
{
    public class HistoriaClinicaResponse : BaseResponse
    {
        public HistoriaClinica HistoriaClinica;

        private HistoriaClinicaResponse(bool success, string message, HistoriaClinica historiaClinica) : base(success, message)
        {
            HistoriaClinica = historiaClinica;
        }
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="historia">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public HistoriaClinicaResponse(HistoriaClinica historiaClinica) : this(true, string.Empty, historiaClinica)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public HistoriaClinicaResponse(string message) : this(false, message, null)
        { }
    }
}
