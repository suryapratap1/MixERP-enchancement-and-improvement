using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        private readonly Collection<Collection<KeyValuePair<string, object>>> parameterCollection =
            new Collection<Collection<KeyValuePair<string, object>>>();

        public bool AutoInitialize { get; set; }
        public string Catalog { get; set; }
        public string ImageButtonCssClass { get; set; }
        public string InvalidLocationErrorMessage { get; set; }
        public bool NoHeader { get; set; }

        /// <summary>
        ///     Collection of each datasources' parameter collection.
        ///     The datasource parameter collection is a collection of
        ///     parameters stored in KeyValuePair.
        /// </summary>
        public Collection<Collection<KeyValuePair<string, object>>> ParameterCollection
        {
            get { return this.parameterCollection; }
        }

        public string Path { get; set; }
        public string ReportNotFoundErrorMessage { get; set; }
        public string RunningTotalText { get; set; }
        public string Html { get; set; }

        public void AddParameterToCollection(Collection<KeyValuePair<string, object>> parameter)
        {
            this.parameterCollection.Add(parameter);
        }
    }
}