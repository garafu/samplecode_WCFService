/// <reference path="jquery-1.11.1.js" />

var btngettitle_onclick = function (event) {
    $.ajax({
        async: true,
        type: 'GET',
        url: 'http://localhost:8000/Service/Title?isbn=1234567890'
    }).done(function (data, textStatus, jqXHR) {
    }).fail(function (jqXHR, textStatus, errorThrown) {
    });
};

var btngetbook_onclick = function (event) {
    $.ajax({
        async: true,
        type: 'GET',
        url: 'http://localhost:8000/Service/Book/hoge'
    }).done(function (data, textStatus, jqXHR) {
    }).fail(function (jqXHR, textStatus, errorThrown) {
    });
};

var btnaddbook_onclick = function (event) {
    var book = {
        title: 'Romeo and Juliet',
        author: 'William Shakespeare',
        isbn: 'shinchosha',
        publisher: '4102020012'
    };

    $.ajax({
        async: true,
        contentType: 'application/json',
        data: JSON.stringify(book),
        type: 'POST',
        url: 'http://localhost:8000/Service/Add'
    }).done(function (data, textStatus, jqXHR) {
    }).fail(function (jqXHR, textStatus, errorThrown) {
    });
};

var doncument_onready = function () {
    $('#btngettitle').on('click', btngettitle_onclick);
    $('#btngetbook').on('click', btngetbook_onclick);
    $('#btnaddbook').on('click', btnaddbook_onclick);
};

$(document).ready(doncument_onready);