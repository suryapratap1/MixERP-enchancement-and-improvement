<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Attendance.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Attendance" %>
<div id="Attendance" data-ng-controller="AttendanceController" data-ng-cloak style="display: none;">
    <div class="ui huge header">Attenance</div>
    <div class="ui divider"></div>
    <div class="ui form bpad16" style="width: 440px;">
        <div class="two fields">
            <div class="ui field">
                <label>For Date</label>
                <input type="text" id="DateInputDate" class="date" />
            </div>
            <div class="ui field">
                <label>&nbsp;</label>
                <a href="javascript:void(0);" data-ng-click="show();" class="ui green button">Show</a>
            </div>
        </div>
    </div>

    <div class="ui link cards">
        <div class="attendance card" data-ng-repeat="employee in employees" data-attendance-id="{{employee.Attendance.AttendanceId}}" data-employee-id="{{employee.EmployeeId}}">
            <div class="image">
                <img data-ng-src="/api/core/attachment/document/400/200/{{employee.Photo}}">
            </div>
            <div class="content">
                <div class="header">{{employee.EmployeeCode}} ({{employee.EmployeeName}})</div>
                <div class="meta">
                    <a>{{employee.CurrentDepartment}}</a>
                </div>
                <div class="vpad8">
                    <div class="ui form">
                        <div class="ui toggle vpad8 checkbox">
                            <input id="PresentCheckBox{{employee.EmployeeId}}" type="checkbox" checked="checked"
                                data-employee-id="{{employee.EmployeeId}}" 
                                data-ng-model="employee.Attendance.WasPresent"
                                onclick="toggleAttendance(this);">
                            <label for="PresentCheckBox{{employee.EmployeeId}}" class="pointer">Is Present</label>
                        </div>
                        <div class="three fields present" style="display: none;">
                            <div class="ui field">
                                <label>Check In Time</label>
                                <input type="text" class="check-in time" data-ng-model="employee.Attendance.CheckInTime" />
                            </div>
                            <div class="ui field">
                                <label>Check Out Time</label>
                                <input type="text" class="check-out time" data-ng-model="employee.Attendance.CheckOutTime" />
                            </div>
                            <div class="ui field">
                                <label>Overtime Hours</label>
                                <input type="text" class="overtime-hours decimal" data-ng-model="employee.Attendance.OvertimeHours" />
                            </div>
                        </div>
                        <div class="vpad8 absent" style="display: none;">
                            <div class="ui field">
                                <label>Reason</label>
                                <textarea rows="1" data-ng-model="employee.Attendance.ReasonForAbsenteeism"></textarea>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="extra content">
                <span>
                    <i class="user icon"></i>
                    {{employee.Office}}
                </span>
            </div>
        </div>
    </div>
    <div class="vpad8">
        <a href="javascript:void(0);" onclick="updateAll()" class="ui teal button">Update All</a>
    </div>
    {{success()}}
</div>
<script>
    $("#DateInputDate").val(window.today);

    MixERPApp.controller("AttendanceController", function ($timeout, $scope, $sce, $window) {
        function requestEmployees() {
            var url = "/api/hrm/employee-view/all";
            return window.getAjaxRequest(url);
        };

        function requestAttendance(date) {
            var url = "/api/hrm/attendance/get-where/-1/";

            var filters = [];
            filters.push(window.getAjaxColumnFilter("WHERE", "attendance_date", window.FilterConditions.IsEqualTo, date));
            var data = JSON.stringify(filters);

            return window.getAjaxRequest(url, "POST", data);
        };

        $scope.show = function() {
            var requestEmployeesAjax = requestEmployees();

            requestEmployeesAjax.success(function (employees) {
                var date = window.parseLocalizedDate($("#DateInputDate").val());

                var requestAttendanceAjax = requestAttendance(date);

                requestAttendanceAjax.success(function (attendance) {
                    $.each(employees, function (i, v) {
                        var employee = v;

                        var a = $window.Enumerable.From(attendance)
                            .Where(function (x) { return x.EmployeeId === employee.EmployeeId }).FirstOrDefault() || new Object();

                        a.CheckInTime = (a.CheckInTime || "").toString().toTime();
                        a.CheckOutTime = (a.CheckOutTime || "").toString().toTime();
                        employees[i].Attendance = a;
                    });

                    $scope.$apply(function () {
                        $scope.employees = employees;
                    });
                });
            });
        };

        $scope.show();

        $scope.success = function() {
            $timeout(function() {
                var checkboxes = $(":checkbox");
                checkboxes.each(function() {
                    toggleAttendance(this);
                });

                $window.loadDatepicker();
                $window.setRegionalFormat();
                $("#Attendance").fadeIn(500);
            }, 500);
        };
    });

    function toggleAttendance(sender) {
        sender = $(sender);
        var isPresent = sender.is(":checked");
        var employeeId = sender.attr("data-employee-id");
        var el = $('.card[data-employee-id="' + employeeId + '"]');

        if (isPresent) {
            el.find(".absent").hide();
            el.find(".present").fadeIn(200);
        } else {
            el.find(".present").hide();
            el.find(".absent").fadeIn(200);
        };
    };

    function getTime(el) {
        var time = el.val();
        var regex = /^\s*([01]?\d|2[0-3]):?([0-5]\d)\s*$/;

        if (regex.test(time)) {
            return time;
        };

        return null;
    };

    function getAttendance(card) {
        var attendanceId = (card.attr("data-attendance-id") || null);
        var employeeId = card.attr("data-employee-id");
        var isPresent = card.find("input:checkbox").is(":checked");
        var checkInTime = window.getTime(card.find("input.check-in"));
        var checkOutTime = window.getTime(card.find("input.check-out"));
        var overTimeHours = card.find("input.overtime-hours").val();
        var reason = card.find("textarea").val();

        var attendance = new Object();
        attendance.attendance_id = attendanceId;
        attendance.office_id = window.metaView.OfficeId;
        attendance.employee_id = employeeId;
        attendance.attendance_date = window.parseLocalizedDate($("#DateInputDate").val());
        attendance.was_present = isPresent;
        attendance.check_in_time = isPresent ? checkInTime : null;
        attendance.check_out_time = isPresent ? checkOutTime : null;
        attendance.overtime_hours = overTimeHours;
        attendance.was_absent = !attendance.was_present;
        attendance.reason_for_absenteeism = attendance.was_absent ? reason : null;
        attendance.audit_user_id = window.userId;
        attendance.audit_ts = new Date();

        return attendance;
    };

    function request(attendnaces) {
        var url = "/api/hrm/attendance/bulk-import";
        var data = JSON.stringify(attendnaces);

        return window.getAjaxRequest(url, "POST", data);
    };

    function sendRequest(attendances) {
        var ajax = request(attendances);

        ajax.success(function () {
            window.location = window.location.pathname;
        });

    };

    function updateAll() {
        var cards = $(".attendance.card");
        var attendances = [];

        cards.each(function () {
            var el = $(this);
            attendances.push(getAttendance(el));
        });

        sendRequest(attendances);
    };
</script>
