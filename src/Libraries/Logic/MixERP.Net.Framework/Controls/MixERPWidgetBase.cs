namespace MixERP.Net.Framework.Controls
{
    public abstract class MixERPWidget: MixERPUserControlBase, IWidget
    {
        public override AccessLevel AccessLevel
        {
            get { return AccessLevel.PolicyBased; }
        }
    }
}