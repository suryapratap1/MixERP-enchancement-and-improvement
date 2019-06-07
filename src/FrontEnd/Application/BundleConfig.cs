using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace MixERP.Net.FrontEnd.Application
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/mixerp-core.js").Include(GetMixERPCoreScript()));
            bundles.Add(new ScriptBundle("~/bundles/libraries.js").Include(GetLibrariesScript()));
            bundles.Add(new ScriptBundle("~/bundles/master-page.js").Include(GetMasterPageScript()));
            bundles.Add(new ScriptBundle("~/bundles/scrudfactory-view.js").Include(GetScrudFactoryView()));
            bundles.Add(new ScriptBundle("~/bundles/scrudfactory-form.js").Include(GetScrudFactoryForm()));

            bundles.Add(new StyleBundle("~/bundles/master-page.css").Include(GetMasterPageStyle()));
            bundles.Add(new StyleBundle("~/bundles/master-page.rtl.css").Include(GetMasterPageRTLStyle()));

            bundles.Add(new StyleBundle("~/bundles/report.css").Include(GetReportStyle()));
            bundles.Add(new StyleBundle("~/bundles/report.rtl.css").Include(GetReportRTLStyle()));
        }

        private static string[] GetScrudFactoryView()
        {
            return new[]
            {
                "~/Scripts/Modules/ScrudFactory/view/initialization.js",
                "~/Scripts/Modules/ScrudFactory/shared/conversion.js",
                "~/Scripts/Modules/ScrudFactory/shared/field-factory.js",
                "~/Scripts/Modules/ScrudFactory/shared/scrud-class.js",
                "~/Scripts/Modules/ScrudFactory/shared/localization.js",
                "~/Scripts/Modules/ScrudFactory/shared/view.js",
                "~/Scripts/Modules/ScrudFactory/view/add-button.js",
                "~/Scripts/Modules/ScrudFactory/view/ajax-load-page-count.js",
                "~/Scripts/Modules/ScrudFactory/view/buttons-action.js",
                "~/Scripts/Modules/ScrudFactory/view/buttons-custom.js",
                "~/Scripts/Modules/ScrudFactory/view/buttons.js",
                "~/Scripts/Modules/ScrudFactory/view/check.js",
                "~/Scripts/Modules/ScrudFactory/view/export.js",
                "~/Scripts/Modules/ScrudFactory/view/filters-ajax.js",
                "~/Scripts/Modules/ScrudFactory/view/filters.js",
                "~/Scripts/Modules/ScrudFactory/view/flag.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview-actions-delete.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview-actions-edit-ajax.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview-actions-edit.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview-actions-get-key.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview-actions.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview-ajax.js",
                "~/Scripts/Modules/ScrudFactory/view/gridview.js",
                "~/Scripts/Modules/ScrudFactory/view/import-export.js",
                "~/Scripts/Modules/ScrudFactory/view/import.js",
                "~/Scripts/Modules/ScrudFactory/view/kanban-cards-ajax.js",
                "~/Scripts/Modules/ScrudFactory/view/kanban-cards.js",
                "~/Scripts/Modules/ScrudFactory/view/kanban-ratable.js",
                "~/Scripts/Modules/ScrudFactory/view/kanban-segment-ajax.js",
                "~/Scripts/Modules/ScrudFactory/view/kanban-segment.js",
                "~/Scripts/Modules/ScrudFactory/view/kanban-sortable.js",
                "~/Scripts/Modules/ScrudFactory/view/shared/localization.js",
                "~/Scripts/Modules/ScrudFactory/view/meta-definition.js",
                "~/Scripts/Modules/ScrudFactory/view/paging.js",
                "~/Scripts/Modules/ScrudFactory/view/procedure-annotation.js",
                "~/Scripts/Modules/ScrudFactory/view/query-string.js",
                "~/Scripts/Modules/ScrudFactory/view/select.js",
                "~/Scripts/Modules/ScrudFactory/view/verification-ajax.js",
                "~/Scripts/Modules/ScrudFactory/view/verification.js",
                "~/Scripts/Modules/ScrudFactory/view/view-components.js",
                "~/Scripts/Modules/ScrudFactory/view/view-shared.js",
                "~/Scripts/Modules/ScrudFactory/view/view-success.js",
                "~/Scripts/Modules/ScrudFactory/view/events-on-doc-ready.js",
                "~/Scripts/Modules/ScrudFactory/view/events-on-viewready.js"
            };
        }

        private static string[] GetScrudFactoryForm()
        {
            return new[]
            {
                "~/Scripts/Modules/ScrudFactory/form/initialization.js",
                "~/Scripts/Modules/ScrudFactory/shared/conversion.js",
                "~/Scripts/Modules/ScrudFactory/shared/field-factory.js",
                "~/Scripts/Modules/ScrudFactory/shared/scrud-class.js",
                "~/Scripts/Modules/ScrudFactory/shared/localization.js",
                "~/Scripts/Modules/ScrudFactory/shared/view.js",
                "~/Scripts/Modules/ScrudFactory/form/title.js",
                "~/Scripts/Modules/ScrudFactory/form/url.js",
                "~/Scripts/Modules/ScrudFactory/form/visibility.js",
                "~/Scripts/Modules/ScrudFactory/form/form-cancel.js",
                "~/Scripts/Modules/ScrudFactory/form/form-custom-fields.js",
                "~/Scripts/Modules/ScrudFactory/form/form-edit.js",
                "~/Scripts/Modules/ScrudFactory/form/form-navigation.js",
                "~/Scripts/Modules/ScrudFactory/form/form-actions.js",
                "~/Scripts/Modules/ScrudFactory/form/form-layout-field-group.js",
                "~/Scripts/Modules/ScrudFactory/form/form-layout.js",
                "~/Scripts/Modules/ScrudFactory/form/form-load-default-values.js",
                "~/Scripts/Modules/ScrudFactory/form/form-load-dropdowns.js",
                "~/Scripts/Modules/ScrudFactory/form/form-reset.js",
                "~/Scripts/Modules/ScrudFactory/form/form-save.js",
                "~/Scripts/Modules/ScrudFactory/form/form-validate.js",
                "~/Scripts/Modules/ScrudFactory/form/form-create.js",
                "~/Scripts/Modules/ScrudFactory/form/ajax-request-initialize.js",
                "~/Scripts/Modules/ScrudFactory/form/event-on-doc-keydown.js",
                "~/Scripts/Modules/ScrudFactory/form/event-on-doc-ready.js",
                "~/Scripts/Modules/ScrudFactory/form/trigger-events.js",
                "~/Scripts/Modules/ScrudFactory/form/event-on-ajax-stop.js"
            };
        }

        #region Scripts

        private static string[] GetMixERPCoreScript()
        {
            return new[]
            {
                "~/Scripts/mixerp/core/dom/cascading-pair.js",
                "~/Scripts/mixerp/core/dom/checkable.js",
                "~/Scripts/mixerp/core/dom/document.js",
                "~/Scripts/mixerp/core/dom/frame.js",
                "~/Scripts/mixerp/core/dom/events.js",
                "~/Scripts/mixerp/core/dom/loader.js",
                "~/Scripts/mixerp/core/dom/uploader.js",
                "~/Scripts/mixerp/core/dom/popunder.js",
                "~/Scripts/mixerp/core/dom/select.js",
                "~/Scripts/mixerp/core/dom/visibility.js",
                "~/Scripts/mixerp/core/grid/cell.js",
                "~/Scripts/mixerp/core/grid/grid.js",
                "~/Scripts/mixerp/core/grid/print-grid.js",
                "~/Scripts/mixerp/core/libraries/chartjs.js",
                "~/Scripts/mixerp/core/libraries/colorbox.js",
                "~/Scripts/mixerp/core/libraries/jquery-notify.js",
                "~/Scripts/mixerp/core/libraries/semantic-ui.js",
                "~/Scripts/mixerp/core/prototype/string.js",
                "~/Scripts/mixerp/core/array.js",
                "~/Scripts/mixerp/core/aspnet-validation.js",
                "~/Scripts/mixerp/core/conversion.js",
                "~/Scripts/mixerp/core/date-expressions.js",
                "~/Scripts/mixerp/core/enums.js",
                "~/Scripts/mixerp/core/browser.js",
                "~/Scripts/mixerp/core/flag.js",
                "~/Scripts/mixerp/core/json.js",
                "~/Scripts/mixerp/core/localization.js",
                "~/Scripts/mixerp/core/location.js",
                "~/Scripts/mixerp/core/mixerp-ajax.js",
                "~/Scripts/mixerp/core/transaction.js",
                "~/Scripts/mixerp/core/validation.js",
                "~/Scripts/mixerp/core/window.js",
                "~/Scripts/mixerp/core/dom/cascading-pair.js",
                "~/Scripts/mixerp/core/dom/checkable.js",
                "~/Scripts/mixerp/core/dom/document.js",
                "~/Scripts/mixerp/core/dom/events.js",
                "~/Scripts/mixerp/core/dom/popunder.js",
                "~/Scripts/mixerp/core/dom/select.js",
                "~/Scripts/mixerp/core/dom/visibility.js",
                "~/Scripts/mixerp/core/grid/cell.js",
                "~/Scripts/mixerp/core/grid/grid.js",
                "~/Scripts/mixerp/core/grid/print-grid.js",
                "~/Scripts/mixerp/core/libraries/chartjs.js",
                "~/Scripts/mixerp/core/libraries/colorbox.js",
                "~/Scripts/mixerp/core/libraries/jquery-notify.js",
                "~/Scripts/mixerp/core/libraries/semantic-ui.js",
                "~/Scripts/mixerp/core/prototype/string.js"
            };
        }

        private static string[] GetLibrariesScript()
        {
            string[] libraries = new[]
            {
                "~/Scripts/jquery-1.9.1.js",
                "~/Scripts/jquery.address.js",
                "~/Scripts/jquery-ui.js",
                "~/Scripts/jquery-timePicker/jquery.timepicker.js",
                "~/Scripts/shortcut.js",
                "~/Scripts/colorbox/jquery.colorbox.js",
                "~/Scripts/jqueryNumber/jquery.number.js",
                "~/Scripts/date.js",
                "~/Scripts/chartjs/Chart.min.js",
                "~/Scripts/chartjs/legend.js",
                "~/Scripts/notify-combined.min.js",
                "~/Scripts/semantic-ui/semantic.js",
                "~/Scripts/jquery.signalR.js",
                "~/Scripts/vakata-jstree/dist/jstree.min.js",
                "~/Scripts/momentjs/moment-with-locales.js",
                "~/Scripts/underscore/underscore-min.js",
                "~/Scripts/angular/angular.min.js",
                "~/Scripts/linq.js/linq.js"
            };

            libraries = libraries.Concat(GetMixERPCoreScript()).ToArray();

            return libraries;
        }

        private static string[] GetMasterPageScript()
        {
            List<string> script = new List<string>
            {
                "~/Scripts/jquery-1.9.1.js",
                "~/Scripts/angular/angular.min.js",
                "~/Scripts/jquery.address.js",
                "~/Scripts/jquery-ui.js",
                "~/Scripts/jquery-timepicker/jquery.timepicker.js",
                "~/Scripts/shortcut.js",
                "~/Scripts/colorbox/jquery.colorbox.js",
                "~/Scripts/papaparse/papaparse.min.js",
                "~/Scripts/jqueryNumber/jquery.number.js",
                "~/Scripts/date.js",
                "~/Scripts/chartjs/Chart.min.js",
                "~/Scripts/chartjs/legend.js",
                "~/Scripts/notify-combined.min.js",
                "~/Scripts/semantic-ui/semantic.js",
                "~/Scripts/jquery.signalR.js",
                "~/Scripts/vakata-jstree/dist/jstree.min.js",
                "~/Scripts/momentjs/moment-with-locales.js",
                "~/Scripts/underscore/underscore-min.js",
                "~/Scripts/sprintf/sprintf.min.js",
                "~/Scripts/linq.js/linq.js"
            };

            script.AddRange(GetMixERPCoreScript());

            script.AddRange(new[]
            {
                "~/Scripts/ajax-file-upload.js",
                //Libraries End
                "~/Scripts/mixerp/master-page/declaration.js",
                "~/Scripts/mixerp/master-page/js-tree.js",
                "~/Scripts/mixerp/master-page/keyboard.js",
                "~/Scripts/mixerp/master-page/layout.js",
                "~/Scripts/mixerp/master-page/locale.js",
                "~/Scripts/mixerp/master-page/scrud.js",
                "~/Scripts/mixerp/master-page/sortable.js",
                "~/Scripts/mixerp/master-page/semantic.js",
                //"~/Scripts/mixerp/master-page/menu.js",
                "~/Scripts/mixerp/master-page/notification.js"
            });

            return script.ToArray();
        }

        #endregion

        #region Stylesheets

        private static string[] GetMasterPageStyle()
        {
            return new[]
            {
                "~/Scripts/colorbox/colorbox.css",
                "~/Scripts/jquery-ui/css/custom-theme/jquery-ui.css",
                "~/Scripts/jquery-timepicker/jquery.timepicker.css",
                "~/Scripts/vakata-jstree/dist/themes/default/style.css",
                "~/Scripts/semantic-ui/semantic.css",
                "~/App_Themes/MixERP/mixerp.css"
            };
        }


        private static string[] GetMasterPageRTLStyle()
        {
            return new[]
            {
                "~/Stylesheets/rtl.css",
                "~/Scripts/colorbox/colorbox.css",
                "~/Scripts/jquery-ui/css/custom-theme/jquery-ui.css",
                "~/Scripts/jquery-timepicker/jquery.timepicker.css",
                "~/Scripts/vakata-jstree/dist/themes/default/style.css",
                "~/Scripts/semantic-ui/semantic.rtl.css",
                "~/App_Themes/MixERP/mixerp.css"
            };
        }

        private static string[] GetReportStyle()
        {
            return new[]
            {
                "~/Scripts/semantic-ui/components/icon.css",
                "~/Stylesheets/report.css"
            };
        }

        private static string[] GetReportRTLStyle()
        {
            return new[]
            {
                "~/Scripts/semantic-ui/components/icon.rtl.css",
                "~/Stylesheets/report.rtl.css"
            };
        }

        #endregion
    }
}