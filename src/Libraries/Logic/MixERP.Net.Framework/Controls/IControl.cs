namespace MixERP.Net.Framework.Controls
{
    public interface IControl
    {
        string MasterPageId { get; set; }
        bool RemoveTheme { get; set; }
        string OverridePath { get; set; }
    }
}