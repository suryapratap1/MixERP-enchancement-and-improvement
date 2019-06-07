using Serilog;
using System.Xml;

namespace MixERP.Net.WebControls.ReportEngine.Helpers
{
    public static class XmlHelper
    {
        public static XmlNode GetNode(string path, string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            return doc.SelectSingleNode(name);
        }

        public static XmlNodeList GetNodes(string path, string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            return doc.SelectNodes(name);
        }

        public static XmlNodeList GetNodesFromText(string xml, string name)
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return null;
            }

            XmlDocument doc = new XmlDocument();

            try
            {
                doc.LoadXml(xml);
                return doc.SelectNodes(name);
            }
            catch (XmlException ex)
            {
                Log.Debug("XML Exception occurred: {Exception}.", ex);
            }

            return null;
        }

        public static string GetNodeText(string path, string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            var selectSingleNode = doc.SelectSingleNode(name);

            if (selectSingleNode != null)
            {
                return selectSingleNode.InnerXml;
            }

            return string.Empty;
        }
    }
}