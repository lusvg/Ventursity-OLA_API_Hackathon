using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.Error
{
    public class ServiceError : Exception
    {
        public ErrorModel Error { get; set; }
        public bool IsConnectivityError { get; set; }
        public bool IsAuthorizationError { get; set; }

        public override string StackTrace
        {
            get
            {
                string connectivityError = IsConnectivityError ? "Connectivity Error - Cannot connect to internet or server is down" + Environment.NewLine : string.Empty;
                string authorizationError = IsAuthorizationError ? "Authorization Error - The device is not authorized for access" + Environment.NewLine : string.Empty;

                string apiErrorTrace = string.Empty;

                if (Error != null)
                {
                    string httpStatusMessage = string.IsNullOrWhiteSpace(Error.HttpStatusMessage) ? string.Empty : string.Format("HTTP Status Message - {0}{1}", Error.HttpStatusMessage, Environment.NewLine);
                    string apiReasonPhrase = string.IsNullOrWhiteSpace(Error.ReasonPhrase) ? string.Empty : string.Format("API Reason Phrase - {0}{1}", Error.ReasonPhrase, Environment.NewLine);
                    apiErrorTrace = string.Format("Error when API was called.{0}{1}{2}{0}", Environment.NewLine, httpStatusMessage, apiReasonPhrase);
                }
                return string.Format("{1}{2}{3}{0}Original Stack Trace{0}{4}", Environment.NewLine, apiErrorTrace, connectivityError, authorizationError, base.StackTrace);

            }
        }
    }
    public class ErrorModel
    {
        public string HttpStatusMessage { get; set; }
        public string ReasonPhrase { get; set; }
    }
}
