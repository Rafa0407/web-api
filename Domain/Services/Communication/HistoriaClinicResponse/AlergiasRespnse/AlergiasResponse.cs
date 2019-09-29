using ECHO_API.Domain.Models;


namespace ECHO_API.Domain.Services.Communication.HistoriaClinicResponse.AlergiasRespnse
{
    public class AlergiasResponse : BaseResponse
    {
        public Alergias Alergias;

        private AlergiasResponse(bool success, string message, Alergias alergias) : base(success, message)
        {
            Alergias = alergias;
        }
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="alergias">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public AlergiasResponse(Alergias alergias) : this(true, string.Empty, alergias)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public AlergiasResponse(string message) : this(false, message, null)
        { }
    }
}
