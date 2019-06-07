using MixERP.Net.Framework;

namespace PetaPoco
{
    public class PolicyValidator : IPolicy
    {
        public AccessTypeEnum AccessType { get; set; }
        public string ObjectNamespace { get; set; }
        public string ObjectName { get; set; }
        public bool HasAccess { get; private set; }
        public long LoginId { get; set; }
        public string Catalog { get; set; }

        public void Validate()
        {
            this.HasAccess = AccessValidator.Validate(this);
        }
    }
}