/*
 * 
}*/


function getSpaWithAjax(actionUrl, targetElementId) {

    $.get(actionUrl, function (response) {
        $("#" + targetElementId).replaceWith(response);
    });
}

function getSpaListWithAjax(actionUrl, targetElementId) {

    $.get(actionUrl, function (response) {
        $("#" + targetElementId).html(response);
    });
}

function getSpaDeleteWithAjax(actionUrl, targetElementId) {

    $.get(actionUrl, function (response) {
        console.log("Ajax delete response:", response);
        $("#" + targetElementId).replaceWith("");
    })
        .fail(function (errorData) {
            console.log("errorData.status:", errorData.status);
            console.log("errorData.statusText:", errorData.statusText);
            getSpaListWithAjax('AjaxPeople/SpaPeopleList', 'spaPeopleList');
            alert("List is out of date, refrecing it.");
        })
}


function ajaxPeopleList(actionUrl) {
    $.get(actionUrl, function (response) {
        document.getElementById("result").innerHTML = response;
    });
}
function ajaxPost(actionUrl, inputId) {
    let inputElement = $("#" + inputId);
    let data = {
        [inputElement.attr("name")]: inputElement.val()
    }
    $.post(actionUrl, data, function (response) {
        document.getElementById("result").innerHTML = response;
    })
}

//getSpaWithAjax('AjaxPeople/SpaPeopleList', 'spaPeopleList');