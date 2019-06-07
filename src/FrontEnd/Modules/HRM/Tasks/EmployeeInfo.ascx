<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInfo.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.EmployeeInfo"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>


<script src="/Scripts/mixerp/utitlities/countries.js"></script>
<script src="/Scripts/underscore/underscore-min.js"></script>

<asp:Panel runat="server" ID="InfoPanel" data-ng-controller="EmployeeInfoController" data-ng-cloak>
    <div class="ui purple header">
        <img ng-src="/api/core/attachment/document/200/200/{{employee.Photo}}" class="ui circular image" alt="{{employee.EmployeeName}}" />
        <div class="content">
            {{employee.EmployeeName}}
            <div class="sub header">
                {{employee.EmployeeType}}
            </div>
        </div>
    </div>


    <div class="bpad8">
        <div class="ui basic buttons">
            <a href="Employees.mix" class="ui basic button">{{getResource('Resources.Titles.Employees')}}</a>
            <a href="/Modules/BackOffice/AttachmentManager.mix?OverridePath=/Modules/HRM/Tasks/Employees.mix&Book=employee&Id={{employee.EmployeeId}}" class="ui basic button">{{getResource('Resources.Titles.UploadAttachments')}}</a>
            <a href="Employee/IdentificationDetails.mix?EmployeeId={{employee.EmployeeId}}" class="ui basic button">{{getResource('Resources.Titles.IdentificationDetails')}}</a>
            <a href="Employee/SocialNetworks.mix?EmployeeId={{employee.EmployeeId}}" class="ui basic button">{{getResource('Resources.Titles.SocialNetworks')}}</a>
            <a href="Employee/Experiences.mix?EmployeeId={{employee.EmployeeId}}" class="ui basic button">{{getResource('Resources.Titles.Experiences')}}</a>
            <a href="Employee/Qualifications.mix?EmployeeId={{employee.EmployeeId}}" class="ui basic button">{{getResource('Resources.Titles.Qualifications')}}</a>
            <a href="Employee/LeaveApplication.mix?EmployeeId={{employee.EmployeeId}}" class="ui basic button">{{getResource('Resources.Titles.LeaveApplication')}}</a>
        </div>
    </div>

    <div class="ui attached tabular menu">
        <a class="active item" data-tab="general-info-tab">General Information</a>
        <a class="item" data-tab="identification-tab" onclick="showIdentificationDetails();">{{getResource('Resources.Titles.IdentificationDetails')}}</a>
        <a class="item" data-tab="social-networks-tab" onclick="showSocialNetwork();">{{getResource('Resources.Titles.SocialNetworks')}}</a>
        <a class="item" data-tab="experiences-tab" onclick="showExperiences();">{{getResource('Resources.Titles.Experiences')}}</a>
        <a class="item" data-tab="qualifications-tab" onclick="showQualifications();">{{getResource('Resources.Titles.Qualifications')}}</a>
    </div>
    <div class="ui active tab attached segment" data-tab="general-info-tab">
        <div class="ui stackable grid">
            <div class="five wide column">
                <div class="ui segment">
                    <div class="ui large header">
                        {{employee.EmployeeName}}
                    </div>
                    <a href="/api/core/attachment/document/{{employee.Photo }}" target="_blank">
                        <img ng-src="/api/core/attachment/document/272/272/{{employee.Photo }}" class="ui image"
                            height="272"
                            alt="{{employee.EmployeeName}}" />
                    </a>
                    <br />
                    <table class="ui striped definition table">
                        <tbody>
                            <tr>
                                <td>{{getResource('Resources.Titles.EmailAddress')}}
                                </td>
                                <td>
                                    <i class="mail icon"></i>
                                    <a href="mailto:{{employee.Email}}">{{employee.EmailAddress}}</a>
                                </td>
                            </tr>
                            <tr>
                                <td>{{getResource('Resources.ScrudResource.website')}}
                                </td>
                                <td>
                                    <i class="world icon"></i>
                                    <a href="{{employee.Website}}" target="_blank">{{employee.Website}}</a>
                                </td>
                            </tr>
                            <tr>
                                <td>{{getResource('Resources.ScrudResource.blog')}}
                                </td>
                                <td>
                                    <i class="world icon"></i>
                                    <a href="{{employee.Blog}}" target="_blank">{{employee.Blog}}</a>
                                </td>
                            </tr>
                            <tr>
                                <td>{{getResource('Resources.ScrudResource.phone_home')}}
                                </td>
                                <td>
                                    <i class="phone icon"></i>
                                    <a href="tel:{{employee.Phone}}">{{employee.PhoneHome}}</a>

                                </td>
                            </tr>
                            <tr>
                                <td>{{getResource('Resources.ScrudResource.phone_cell')}}
                                </td>
                                <td>
                                    <i class="mobile icon"></i>
                                    <a href="tel:{{employee.Cell}}">{{employee.PhoneCell}}</a>

                                </td>
                            </tr>
                            <tr>
                                <td>{{getResource('Resources.ScrudResource.phone_office_extension')}}
                                </td>
                                <td>
                                    <i class="phone icon"></i>
                                    <a href="tel:{{employee.Phone}}">{{employee.PhoneOfficeExtension}}</a>

                                </td>
                            </tr>
                            <tr class="negative">
                                <td>{{getResource('Resources.ScrudResource.phone_emergency')}}
                                </td>
                                <td>
                                    <i class="red phone icon"></i>
                                    <a href="tel:{{employee.Fax}}">{{employee.PhoneEmergency}}</a>
                                </td>
                            </tr>
                            <tr class="negative">
                                <td>{{getResource('Resources.ScrudResource.phone_emergency2')}}
                                </td>
                                <td>
                                    <i class="red phone icon"></i>
                                    <a href="tel:{{employee.Fax}}">{{employee.PhoneEmergency2}}</a>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 200px;">{{getResource('Resources.Titles.User')}}
                                </td>
                                <td>
                                    <i class="user icon"></i>
                                    {{employee.UserName}}
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>

            </div>
            <div class="eleven wide column">
                <table class="ui striped definition table">
                    <tbody>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.ScrudResource.joined_on')}}
                            </td>
                            <td title="{{employee.JoinedOn.toFormattedDate()}}">{{employee.JoinedOnAgo}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.Office')}}
                            </td>
                            <td>{{employee.Office}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.Gender')}}
                            </td>
                            <td>{{employee.GenderName}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.MaritalStatus')}}
                            </td>
                            <td>{{employee.MaritalStatus}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.EmployeeType')}}
                            </td>
                            <td>{{employee.EmployeeType}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.Department')}}
                            </td>
                            <td>{{employee.CurrentDepartment}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.Role')}}
                            </td>
                            <td>{{employee.Role}}
                            </td>
                        </tr>
                        <tr class="negative">
                            <td style="width: 200px;">{{getResource('Resources.Titles.EmploymentStatus')}}
                            </td>
                            <td>{{employee.EmploymentStatus}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.JobTitle')}}
                            </td>
                            <td>{{employee.JobTitle}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.PayGrade')}}
                            </td>
                            <td>{{employee.PayGrade}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.Shift')}}
                            </td>
                            <td>{{employee.Shift}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.Nationality')}}
                            </td>
                            <td>{{employee.Nationality}}
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px;">{{getResource('Resources.Titles.DateOfBirth')}}
                            </td>
                            <td title="{{employee.DateOfBirth.toFormattedDate()}}">{{employee.Age}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.address_line_1')}}
                            </td>
                            <td>{{employee.AddressLine1}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.address_line_2')}}
                            </td>
                            <td>{{employee.AddressLine2}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.zip_code')}}
                            </td>
                            <td>{{employee.ZipCode}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.street')}}
                            </td>
                            <td>{{employee.Street}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.city')}}
                            </td>
                            <td>{{employee.City}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.state')}}
                            </td>
                            <td>{{employee.State}}
                            </td>
                        </tr>
                        <tr>
                            <td>{{getResource('Resources.ScrudResource.country')}}
                            </td>
                            <td>
                                <i class="{{getCountryCode(employee.Country)}} flag"></i>{{employee.Country}}
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="ui tab attached segment" data-tab="identification-tab">
        <div class="ui grey header">
            {{getResource('Resources.Titles.IdentificationDetails')}}
        </div>

        <table class="ui striped table">
            <thead>
                <tr>
                    <th>{{getResource('Resources.ScrudResource.identification_type_code')}}</th>
                    <th>{{getResource('Resources.ScrudResource.identification_type_name')}}</th>
                    <th>{{getResource('Resources.ScrudResource.identification_number')}}</th>
                    <th>{{getResource('Resources.ScrudResource.expires_on')}}</th>
                </tr>
            </thead>
            <tbody data-ng-repeat="identification in identifications">
                <tr>
                    <td>{{identification.IdentificationTypeCode}}</td>
                    <td>{{identification.IdentificationTypeName}}</td>
                    <td>{{identification.IdentificationNumber}}</td>
                    <td>{{identification.ExpiresOn}}</td>
                </tr>
            </tbody>
        </table>
        <a href="Employee/IdentificationDetails.mix?View=FormView&EmployeeId={{employee.EmployeeId}}&ReturnUrl={{thispage}}&data-tab=identification-tab" class="ui green button">
            {{getResource('Resources.Titles.AddNew')}}
        </a>
    </div>
    <div class="ui tab attached segment" data-tab="social-networks-tab">
        <div class="ui grey header">
            {{getResource('Resources.Titles.SocialNetworks')}}
        </div>

        <table class="ui striped table">
            <thead>
                <tr>
                    <th>{{getResource('Resources.ScrudResource.social_network_name')}}</th>
                    <th>{{getResource('Resources.ScrudResource.social_network_id')}}</th>
                </tr>
            </thead>
            <tbody data-ng-repeat="network in socialNetworks">
                <tr>
                    <td>
                        <i class="{{network.SemanticCssClass}} icon"></i>
                        <a href="{{network.BaseUrl}}" target="_blank">{{network.SocialNetworkName}}
                        </a>
                    </td>
                    <td>
                        <a href="{{network.ProfileUrl}}" target="_blank">{{network.SocialNetworkId}}
                        </a>

                    </td>
                </tr>
            </tbody>
        </table>
        <a href="Employee/SocialNetworks.mix?View=FormView&EmployeeId={{employee.EmployeeId}}&ReturnUrl={{thispage}}&data-tab=social-networks-tab" class="ui green button">
            {{getResource('Resources.Titles.AddNew')}}
        </a>
    </div>
    <div class="ui tab attached segment" data-tab="experiences-tab">
        <div class="ui grey header">
            {{getResource('Resources.Titles.Experiences')}}
        </div>

        <table class="ui striped table">
            <thead>
                <tr>
                    <th>{{getResource('Resources.ScrudResource.organization_name')}}</th>
                    <th>{{getResource('Resources.ScrudResource.title')}}</th>
                    <th>{{getResource('Resources.ScrudResource.started_on')}}</th>
                    <th>{{getResource('Resources.ScrudResource.ended_on')}}</th>
                </tr>
            </thead>
            <tbody data-ng-repeat="experience in experiences">
                <tr>
                    <td>{{experience.OrganizationName}}</td>
                    <td>{{experience.Title}}</td>
                    <td title="{{experience.StartedOn.toFormattedDate()}}">{{experience.StartedOnAgo}}</td>
                    <td title="{{experience.EndedOn.toFormattedDate()}}">{{experience.EndedOnAgo}}</td>
                </tr>
            </tbody>
        </table>
        
        <a href="Employee/Experiences.mix?View=FormView&EmployeeId={{employee.EmployeeId}}&ReturnUrl={{thispage}}&data-tab=experiences-tab" class="ui green button">
            {{getResource('Resources.Titles.AddNew')}}
        </a>
    </div>
    <div class="ui tab attached segment" data-tab="qualifications-tab">
        <div class="ui grey header">
            {{getResource('Resources.Titles.Qualifications')}}
        </div>

        <table class="ui striped table">
            <thead>
                <tr>
                    <th>{{getResource('Resources.ScrudResource.education_level_name')}}</th>
                    <th>{{getResource('Resources.ScrudResource.institution')}}</th>
                    <th>{{getResource('Resources.ScrudResource.majors')}}</th>
                    <th>{{getResource('Resources.ScrudResource.total_years')}}</th>
                    <th>{{getResource('Resources.ScrudResource.started_on')}}</th>
                    <th>{{getResource('Resources.ScrudResource.completed_on')}}</th>
                </tr>
            </thead>
            <tbody data-ng-repeat="qualification in qualifications">
                <tr>
                    <td>{{qualification.EducationLevelName}}</td>
                    <td>{{qualification.Institution}}</td>
                    <td>{{qualification.Majors}}</td>
                    <td>{{qualification.TotalYears}}</td>
                    <td title="{{qualification.StartedOn.toFormattedDate()}}">{{qualification.StartedOnAgo}}</td>
                    <td title="{{qualification.CompletedOn.toFormattedDate()}}">{{qualification.CompletedOnAgo}}</td>
                </tr>
            </tbody>
        </table>

        <a href="Employee/Qualifications.mix?View=FormView&EmployeeId={{employee.EmployeeId}}&ReturnUrl={{thispage}}&data-tab=qualifications-tab" class="ui green button">
            {{getResource('Resources.Titles.AddNew')}}
        </a>
    </div>

</asp:Panel>

<%-- ReSharper disable once NativeTypePrototypeExtending --%>
<script>
    function getEmployee() {
        var employeeId = parseInt(window.getQueryStringByName("EmployeeId") || 0);

        var filters = [];
        var filter = new Object();
        filter.ColumnName = "employee_id";
        filter.FilterCondition = "0";
        filter.FilterValue = employeeId;

        filters.push(filter);

        var data = JSON.stringify(filters);

        var url = "/api/hrm/employee-view/get-where/1/";
        return window.getAjaxRequest(url, "POST", data);
    };

    function getIdentificationDetails() {
        var employeeId = parseInt(window.getQueryStringByName("EmployeeId") || 0);

        var filters = [];
        var filter = new Object();
        filter.ColumnName = "employee_id";
        filter.FilterCondition = "0";
        filter.FilterValue = employeeId;

        filters.push(filter);

        var data = JSON.stringify(filters);

        var url = "/api/hrm/employee-identification-detail-scrud-view/get-where/1/";
        return window.getAjaxRequest(url, "POST", data);
    };

    function getSocialNetworkDetails() {
        var employeeId = parseInt(window.getQueryStringByName("EmployeeId") || 0);

        var filters = [];
        var filter = new Object();
        filter.ColumnName = "employee_id";
        filter.FilterCondition = "0";
        filter.FilterValue = employeeId;

        filters.push(filter);

        var data = JSON.stringify(filters);

        var url = "/api/hrm/employee-social-network-detail-scrud-view/get-where/1/";
        return window.getAjaxRequest(url, "POST", data);
    };

    function getExperiences() {
        var employeeId = parseInt(window.getQueryStringByName("EmployeeId") || 0);

        var filters = [];
        var filter = new Object();
        filter.ColumnName = "employee_id";
        filter.FilterCondition = "0";
        filter.FilterValue = employeeId;

        filters.push(filter);

        var data = JSON.stringify(filters);

        var url = "/api/hrm/employee-experience-scrud-view/get-where/1/";
        return window.getAjaxRequest(url, "POST", data);
    };

    function getQualifications() {
        var employeeId = parseInt(window.getQueryStringByName("EmployeeId") || 0);

        var filters = [];
        var filter = new Object();
        filter.ColumnName = "employee_id";
        filter.FilterCondition = "0";
        filter.FilterValue = employeeId;

        filters.push(filter);

        var data = JSON.stringify(filters);

        var url = "/api/hrm/employee-qualification-scrud-view/get-where/1/";
        return window.getAjaxRequest(url, "POST", data);
    };


    MixERPApp.controller("EmployeeInfoController", function ($scope, $sce, $window) {
        var getEmployeeAjax = getEmployee();
        var getIdentificationDetailsAjax = getIdentificationDetails();
        var getSocialNetworkDetailsAjax = getSocialNetworkDetails();
        var getExperiencesAjax = getExperiences();
        var getQualificationsAjax = getQualifications();
        $scope.thispage = $window.location.pathname;

        $scope.getCountryCode = function (countryName) {
            if (countryName) {
                return $window._.find($window.countries, { countryName: countryName }).countryCode.toLowerCase();
            };

            return "";
        };

        getEmployeeAjax.success(function (msg) {
            $scope.$apply(function () {
                $scope.employee = msg[0];
                $scope.employee.JoinedOnAgo = $window.moment($window.removeTimezone(msg[0].JoinedOn)).fromNow();
                var age = $window.moment().diff($window.moment(msg[0].DateOfBirth), "years");

                if (!age) { age = ""; };

                if (age) {
                    age = $window.stringFormat($scope.getResource("Resources.Labels.YearOld"), age);
                };

                $scope.employee.Age = age;
            });
        });

        getIdentificationDetailsAjax.success(function (msg) {
            $scope.$apply(function () {
                $scope.identifications = msg;
            });
        });

        getSocialNetworkDetailsAjax.success(function (msg) {
            $.each(msg, function (i) {
                msg[i].ProfileUrl = $window.stringFormat(msg[i].ProfileUrl, msg[i].SocialNetworkId);
            });

            $scope.$apply(function () {
                $scope.socialNetworks = msg;
            });
        });

        getExperiencesAjax.success(function (msg) {
            $.each(msg, function (i) {
                msg[i].StartedOnAgo = $window.moment($window.removeTimezone(msg[i].StartedOn)).fromNow();
                msg[i].EndedOnAgo = $window.moment($window.removeTimezone(msg[i].EndedOn)).fromNow();
            });

            $scope.$apply(function () {
                $scope.experiences = msg;
            });
        });

        getQualificationsAjax.success(function (msg) {
            $.each(msg, function (i) {
                msg[i].StartedOnAgo = $window.moment($window.removeTimezone(msg[i].StartedOn)).fromNow();
                msg[i].CompletedOnAgo = $window.moment($window.removeTimezone(msg[i].CompletedOn)).fromNow();
            });

            $scope.$apply(function () {
                $scope.qualifications = msg;
            });
        });

        $scope.getResource = function (func) {
            return $window.executeFunctionByName(func, $window);
        };
    });

    $(document).ready(function() {
        var tab = window.getQueryStringByName("data-tab");

        if (tab) {
            var el = $("[data-tab=" + tab + "]");
            if (el.length) {
                $("[data-tab]").removeClass("active");
                el.addClass("active");
            };
        };
    });
</script>
