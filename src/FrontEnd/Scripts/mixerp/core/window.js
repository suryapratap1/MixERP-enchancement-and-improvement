var confirmAction = function () {
    return confirm(Resources.Questions.AreYouSure());
};

//Jason Bunting & Alex Nazarov
//http://stackoverflow.com/questions/359788/how-to-execute-a-javascript-function-when-i-have-its-name-as-a-string
function executeFunctionByName(functionName, context /*, args */) {
    var args = [].slice.call(arguments).splice(2);
    var namespaces = functionName.split(".");
    var func = namespaces.pop();
    for (var i = 0; i < namespaces.length; i++) {
        context = context[namespaces[i]];
    };

    if (typeof (context[func]) === "function") {
        return context[func].apply(this, args);
    };

    return undefined;
};