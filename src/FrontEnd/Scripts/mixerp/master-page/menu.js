var menus;
var depth = 2;


function getPath() {
    var url = window.overridePath || window.location.pathname;
    return url.toString().toLowerCase();
};


$(document).ready(function () {
    loadSidebarState();
    var topMenu = $("#top-menu");
    var resetMenu = $("#reset-menu");
    var menuId = 0;

    if (window.supportsBrowserStorage()) {
        menuId = parseInt(localStorage["menuId"] || 0);
    };

    var ajaxMenu = getAjaxMenu();

    ajaxMenu.success(function (msg) {
        menus = JSON.parse(msg.d);
        loadMenu(topMenu);
        loadTree(menuId, createTree);
    });

    resetMenu.click(function () {
        $(this).addClass("initially hidden");
        window.depth = 2;
        loadTree(0, createTree);
    });
});

function getSidebarState() {
    if (window.supportsBrowserStorage()) {
        return localStorage["sidebar"];
    };

    return "";
};


function loadMenu(appendTo) {
    var anchors = "";

    var sorted = Enumerable.From(menus).OrderBy(function (x) { return x.Menu.Sort }).ToArray();

    $.each(sorted, function (i, v) {
        var anchor = "<a class='item' href='javascript:void(0);' onclick='javascript:loadTree(%s, createTree);'>%s</a>";
        anchor = sprintf(anchor, v.Menu.MenuId, v.Menu.MenuText);

        anchors += anchor;
    });

    appendTo.prepend(anchors);
};

function createTree() {
    var tree = $("#tree");

    var searchInput = $("#SearchInput");


    tree.jstree({
        "plugins": ["wholerow", "search", "types"],
        "types": {
            "default": {
                "icon": "open folder icon"
            },
            "file": {
                "icon": "file icon"
            },
            "active": {
                "icon": "star icon"
            }
        },
        "search": {
            "case_insensitive": true,
            "show_only_matches": true
        }
    }).bind("select_node.jstree", function (e, data) {
        var href = data.node.a_attr.href;
        document.location.href = href;
    }).bind("hover_node.jstree", function (e, data) {
        if (data.node.data) {
            var menuCode = data.node.data.menucode;
            searchInput.val(menuCode);
        }
    }).bind("ready.jstree", function (e, data) {
        $.each(data.instance._model.data, function (i, v) {
            var liClass;
            var dataSelected = false;

            if (v.li_attr && v.li_attr.class) {
                liClass = v.li_attr.class.toString();
            };

            if (v.data && v.data.selected) {
                if (v.data.selected.toString() === "true") {
                    dataSelected = true;
                    if (v.li_attr && v.li_attr.class) {
                        v.li_attr.class = v.li_attr.class.toString() + " jstree-selected";
                    };
                };
            };

            if (v.parents.length <= depth) {
                data.instance._open_to(i);
            };

            if (dataSelected) {
                data.instance._open_to(i);
                return;
            };

            if (liClass === "expanded") {
                data.instance._open_to(i);
                return;
            };
        });

        tree.toggle();
    });

    var to = false;
    searchInput.keyup(function (e) {
        if (to) {
            clearTimeout(to);
        }
        to = setTimeout(function () {
            var v = searchInput.val();
            $("#tree").jstree(true).search(v);
            var result = $(".jstree-search");
            result.prevAll(".jstree-wholerow").addClass("jstree-clicked");

            if (result.length >= 1) {
                if (e.which === 13) {
                    var href = result.first().attr("href");
                    if (href) {
                        window.location = href;
                    };
                };
            };
        }, 250);
    });
}

function loadTree(menuId, callback) {
    $("#tree").remove();
    $(".sidebar").append("<div id='tree' style='display:none;'><ul id='treeData'></ul></div>");

    var tree = $("#tree");
    var treeData = tree.find("ul");

    if (window.supportsBrowserStorage()) {
        localStorage["menuId"] = menuId;
    };


    $.each(menus, function () {
        var items;
        var li;

        if (menuId === 0) {
            items = getItems(this.Children);
            li = sprintf("<li id='node%s'>" +
                "<a id='anchorNode%1$s' href='javascript:void(0);' title='%s'>%2$s</a>" +
                "%s" +
                "</li>",
                this.Menu.MenuId,
                this.Menu.MenuText,
                items);
            treeData.append(li);
        } else {
            if (this.Menu.MenuId === menuId) {
                items = getItems(this.Children);
                li = sprintf("<li id='node%s'>" +
                    "<a id='anchorNode%1$s' href='javascript:void(0);' title='%s'>%2$s</a>" +
                    "%s" +
                    "</li>",
                    this.Menu.MenuId,
                    this.Menu.MenuText,
                    items);
                treeData.append(li);

                $(".remove.icon").parent().removeClass("initially hidden");

                depth = 3;
            };
        };
    });


    if (typeof callback === "function") {
        callback();
    };
};

function getItems(nav) {

    var menu = "";
    $.each(nav, function (i, v) {
        if (i === 0) {
            menu += "<ul>";
        };

        var childMenu = getItems(v.Children);
        var id = v.Menu.MenuId.toString();

        var url = isNullOrWhiteSpace(v.Menu.Url)
            ? "javascript:void(0);"
            : v.Menu.Url.replace("~", "");

        var cssClass = "";
        var dataJsTree = "";
        var dataSelected = "";

        if (isNullOrWhiteSpace(childMenu)) {
            dataJsTree = "data-jstree='{\"type\":\"file\"}'";
        };

        if (cleanUrl(url) === getPath()) {
            dataSelected = "data-selected='true'";
            cssClass = "class='jstree-selected expanded'";
            dataJsTree = "data-jstree='{\"type\":\"active\"}'";
        };

        var anchor = "<a href='" + url + "'>" + v.Menu.MenuText + "</a>";

        menu += sprintf("<li id='node%s' %s %s data-menucode='%s' %s>",
            id, cssClass, dataSelected, v.Menu.MenuCode, dataJsTree);


        menu += anchor;
        menu += childMenu;
        menu += "</li>";

        if (i === nav.length - 1) {
            menu += "</ul>";
        };
    });

    return menu;
};

function getAjaxMenu() {
    var url = "/Services/Menu.asmx/GetMenus";
    return getAjax(url);
};


function loadSidebarState() {
    var state = getSidebarState();

    if (state === "hidden") {
        toggleSidebar();
    };
};

function toggleSidebar(el) {
    var state = "visible";

    if ($(".sidebar").is(":visible")) {
        $("#Content").removeClass("thirteen wide column").addClass("sixteen wide column");
        state = "hidden";
    } else {
        $("#Content").removeClass("sixteen wide column").addClass("thirteen wide column");
    };

    if (window.supportsBrowserStorage()) {
        localStorage["sidebar"] = state;
    };

    $("body").hide();
    $(".sidebar").toggle();
    $("body").fadeIn();
};

var menuPolicy;
var menuColors = ["red", "purple", "green", "orange", "black", "violet", "yellow", "olive", "pink", "teal", "blue", "grey"];
var columnTemplate = "<div class=\"column\">\
                        <a class=\"ui link icons\" data-menu-id=\"{Id}\" href=\"javascript:void(0);\" onclick=\"showMenu({Id});\">\
                            <i class=\"ui {Icon} inverted circular {Color} large icon\"></i>\
                            <span class=\"text\">{Text}</span>\
                        </a>\
                    </div>";

function cleanUrl(url) {
    if (!url) {
        return "";
    };

    url = url.replace("~", "");
    url = url.split("?")[0];

    url = url.toLowerCase();
    return url;
};

function getCurrentPageMenu() {
    var currentPage = Enumerable.From(menuPolicy)
        .Where(function (x) { return cleanUrl(x.Url) === getPath(); }).ToArray();

    if (currentPage.length) {
        return currentPage[0];
    };

    return null;
};

function getMenuPolicy() {
    var url = "/api/policy/procedures/get-menu/execute";

    var annotation = new Object();
    annotation.UserId = window.metaView.UserId;
    annotation.OfficeId = window.metaView.OfficeId;
    annotation.Culture = window.metaView.Culture;

    var data = JSON.stringify(annotation);

    return window.getAjaxRequest(url, "POST", data, false);
};


function showMenu(menuId) {
    if (isParentMenu(menuId)) {
        if (typeof (window.loadTree) === "function") {
            window.loadTree(menuId, window.createTree);
        };
    };

    var children = Enumerable.From(menuPolicy)
        .Where(function (x) { return x.ParentMenuId === menuId })
        .OrderBy(function (x) { return x.MenuId })
        .OrderBy(function (x) { return x.Sort }).ToArray();

    if (children.length) {
        window.createMenus(children, menuId);
    };
};

function getParentMenu(menu) {
    var parent = Enumerable.From(menuPolicy)
        .Where(function (x) { return x.MenuId === menu.ParentMenuId; }).ToArray();


    if (parent.length) {
        return parent[0];
    };

    return null;
};

function isParentMenu(menuId) {
    var result = Enumerable.From(menuPolicy)
        .Where(function (x) { return x.MenuId === menuId }).ToArray();

    if (result.length) {
        if (!result[0].ParentMenuId) {
            return true;
        };
    };

    return false;
};

function hasChildren(menuId) {
    var children = Enumerable.From(menuPolicy)
        .Where(function (x) { return x.ParentMenuId === menuId }).ToArray();

    return children.length > 0;
};

function createMenus(items, menuId) {
    $("#menu-cols").html("").hide();

    $.each(items, function (i, v) {
        createMenu(i, v);
    });

    var parent = Enumerable.From(menuPolicy).Where(function (x) { return x.MenuId === menuId }).ToArray();

    if (parent.length) {
        createMenu(items.length + 1, { MenuId: parent[0].ParentMenuId || 0, MenuText: "Back", Icon: "chevron left" });
    };

    $("#PhoneMenu").show();
    $("#menu-cols").fadeIn(600);
};

function createMenu(index, menu) {
    var column = columnTemplate;
    column = column.replace(/{Id}/g, menu.MenuId || 0);
    column = column.replace(/{Icon}/g, menu.Icon || "user");
    column = column.replace(/{Color}/g, menuColors[index % menuColors.length]);
    column = column.replace(/{Text}/g, menu.MenuText);

    column = $(column);

    if (!hasChildren(menu.MenuId)) {
        column.find("a").attr("href", (menu.Url || "").replace("~", ""));
    };

    $("#menu-cols").append($(column));
};

function addSection(el, menu, active, divide) {
    var section = $("<a class='section' href='javascript:void(0);' />");
    section.html(menu.MenuText);
    section.attr("onclick", "showMenu(" + menu.MenuId + ");");

    if (active) {
        section.addClass("active");
    };

    if (divide) {
        var divider = $("<i class=\"right chevron icon divider\"></i>");
        el.prepend(divider);
    };

    el.prepend(section);
};

function showBreadcrumb() {
    var menu = getCurrentPageMenu();
    if (menu) {
        $("#PhoneMenu").hide();
    };

    var container = $("<div class='cellphone only' />");

    var breadcrumb = $("<div class='ui large breadcrumb'/>");

    addSection(breadcrumb, menu, true);

    do {
        menu = getParentMenu(menu);

        if (menu) {
            addSection(breadcrumb, menu, false, true);
        };
    } while (menu != null);

    container.append(breadcrumb);
    container.append($("<div class=\"ui mobile divider\" />"));

    $("#MainContent").prepend(container);
};

$(document).ready(function () {
    var ajaxMenu = getMenuPolicy();

    ajaxMenu.success(function (msg) {
        menuPolicy = msg;
        showMenu(0);
        showBreadcrumb();
    });

    ajaxMenu.fail(function (xhr) {
        alert(JSON.stringify(xhr));
    });
});