using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.ErrorEventArgs
{
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(string error, Exception ex = null)
        {
            Exception = ex;
            Errors = new List<string>();
            Errors.Add(error);
        }

        public ErrorEventArgs(List<string> errors, Exception ex = null)
        {
            Errors = errors;
        }

        public List<string> Errors { get; private set; }
        public bool IsNetworkConnectivityError { get; set; }
        public bool IsAuthorizationError { get; set; }
        public Exception Exception { get; set; }
    }
}
