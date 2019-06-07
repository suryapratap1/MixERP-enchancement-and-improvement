using System.Collections.Generic;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data
{
    public static class CustomFields
    {
        public static IEnumerable<CustomFieldForm> GetCustomFieldForms(string catalog)
        {
            const string sql = "SELECT * FROM core.custom_field_forms;";
            return Factory.Get<CustomFieldForm>(catalog, sql);
        }

        public static IEnumerable<CustomFieldDataType> GetCustomFieldDataTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.custom_field_data_types;";
            return Factory.Get<CustomFieldDataType>(catalog, sql);
        }

        public static IEnumerable<CustomFieldSetup> GetCustomFieldSetups(string catalog, string formName)
        {
            const string sql = "SELECT * FROM core.custom_field_setup WHERE form_name=@0;";
            return Factory.Get<CustomFieldSetup>(catalog, sql, formName);
        }

        public static void SaveCustomFieldSetups(string catalog, string formName, IEnumerable<CustomFieldSetup> fields)
        {
            const string sql = "DELETE FROM core.custom_field_setup WHERE form_name=@0";
            Factory.NonQuery(catalog, sql, formName);

            foreach (var field in fields)
            {
                Factory.Insert(catalog, field);
            }
        }
    }
}