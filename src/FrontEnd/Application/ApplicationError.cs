using System;
using System.Threading;
using MixERP.Net.Framework;
using Serilog;

namespace MixERP.Net.FrontEnd.Application
{
    internal static class ApplicationError
    {
        internal static void Handle(Exception ex)
        {
            if (ex == null)
            {
                return;
            }

            if (ex is ThreadAbortException)
            {
                Log.Verbose("The thread was being aborted. {Exception}.", ex);
                return;
            }


            MixERPException exception = ex as MixERPException;

            if (exception != null)
            {
                Log.Verbose("Handling exception.");

                MixERPException.Handle(exception);
                return;
            }

            Log.Error("Exception occurred. {Exception}.", ex);

            var innerException = ex.InnerException as MixERPException;

            if (innerException != null)
            {
                MixERPException.Handle(innerException);
                return;
            }

            if (ex.InnerException != null)
            {
                Log.Error("Inner Exception. {InnerException}.", ex.InnerException);
            }

            throw ex;
        }
    }
}