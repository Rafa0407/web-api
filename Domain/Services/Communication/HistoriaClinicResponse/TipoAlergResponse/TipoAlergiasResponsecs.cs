using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.Communication.HistoriaClinicResponse.TipoAlergResponse
{
    public class TipoAlergiasResponsecs : BaseResponse
    {
        public TipoAlergias TiposAlergia;

        private TipoAlergiasResponsecs(bool success, string message, TipoAlergias tipoAlergias) : base(success, message)
        {
            TiposAlergia = tipoAlergias;
        }
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="alergias">Pcientes agregado.</param>
        /// <returns>Response.</returns>
        public TipoAlergiasResponsecs(TipoAlergias tipoAlergias) : this(true, string.Empty, tipoAlergias)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public TipoAlergiasResponsecs(string message) : this(false, message, null)
        { }
    }
}
