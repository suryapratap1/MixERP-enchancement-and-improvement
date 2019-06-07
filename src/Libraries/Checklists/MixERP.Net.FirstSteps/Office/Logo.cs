using System.IO;
using System.Web.Hosting;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Contracts.Checklist;
using MixERP.Net.i18n.Resources;
using PetaPoco;

namespace MixERP.Net.FirstSteps.Office
{
    public class Logo : FirstStep
    {
        public Logo()
        {
            this.Order = 300;
            this.Name = Titles.UploadLogo;
            this.Category = Titles.FirstTasks;
            this.CategoryAlias = "first-tasks";

            this.Description = Labels.UploadLogoDescription;
            this.Icon = "film icon";
            this.NavigateUrl = "/Modules/BackOffice/Offices.mix";


            this.Message = Labels.UploadLogo;
            string path = this.GetLogoPath();
            this.Status = false;

            if (string.IsNullOrWhiteSpace(path))
            {
                return;
                ;
            }

            path = HostingEnvironment.MapPath("/Resource/Static/Attachments/" + path);

            if (!File.Exists(path))
            {
                return;
            }

            this.Status = true;
            this.Message = Titles.OK;
        }

        private string GetLogoPath()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            const string sql = "SELECT logo_file FROM office.offices WHERE office_id = @0;";
            return Factory.Scalar<string>(catalog, sql, officeId);
        }
    }
}