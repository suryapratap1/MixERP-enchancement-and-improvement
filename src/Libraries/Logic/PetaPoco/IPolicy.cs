using MixERP.Net.Framework;

namespace PetaPoco
{
    public interface IPolicy
    {
        string ObjectNamespace { get; set; }
        string ObjectName { get; set; }
        AccessTypeEnum AccessType { get; set; }
        bool HasAccess { get; }
        long LoginId { get; set; }
        string Catalog { get; set; }
        void Validate();
    }
}