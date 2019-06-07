using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Web;
using Serilog;

namespace MixERP.Net.Framework
{
    [Serializable]
    public class MixERPException : Exception
    {
        private readonly string dbConstraintName;

        public MixERPException()
        {
        }

        public MixERPException(string message)
            : base(message)
        {
        }

        public MixERPException(string message, Exception exception)
            : base(message, exception)
        {
        }

        public MixERPException(string message, Exception exception, string dbConstraintName)
            : base(message, exception)
        {
            this.dbConstraintName = dbConstraintName;
        }

        public MixERPException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public string DBConstraintName
        {
            get { return this.dbConstraintName; }
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public static void Handle(MixERPException ex)
        {
            if (ex == null)
            {
                return;
            }

            if (HttpContext.Current.Session != null)
            {
                HttpContext.Current.Session["ex"] = ex;
                Log.Information("Exception object was added to session.");

                HttpContext.Current.Server.TransferRequest("~/Site/RuntimeError.aspx", true);
            }
        }

    }
}