using System;

namespace MixERP.Net.Common.Events
{
    public class MixERPPGEventArgs : EventArgs
    {
        public readonly string AdditionalInformation;
        public readonly string Condition;
        public readonly int PID;

        public MixERPPGEventArgs(string additionalInformation, string condition, int pid)
        {
            this.AdditionalInformation = additionalInformation;
            this.Condition = condition;
            this.PID = pid;
        }
    }
}