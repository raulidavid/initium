// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#press').click(function () {
    var url = '';
    var textValue = $('#textbox').val();

    window.location.href = url + '?name=' + textValue;
});