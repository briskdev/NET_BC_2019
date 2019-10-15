// JavaScript source code
/*
 document.getElementById('ok').onclick = function () {
    var name = document.getElementById('name').value;
    var age = document.getElementById('age').value;

    var text = "Your name is " + name;
    text += " and you are " + age + " years old";

    document.getElementById('result').innerHTML = text;
    document.getElementById('ok').style.display = 'none';
};
*/

$(function () {
    $("#ok").click(function () {
        var name = $("#name").val();
        var age = parseInt($("#age").val());
        age += 5;

        var text = "Your name is " + name;
        text += " and you are " + age + " years old";

        $("#result").html(text);
        $("#ok").hide();
    });

    $("#plus").click(function () {
        var num1 = parseInt($("#num1").val());
        var num2 = parseInt($("#num2").val());
        var result = num1 + num2;

        $("#result").html(result);
    });

    $("#minus").click(function () {
        var num1 = parseInt($("#num1").val());
        var num2 = parseInt($("#num2").val());
        var result = num1 - num2;

        $("#result").html(result);
    });
});