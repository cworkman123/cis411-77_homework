


var t = true;
$(document).ready(function () {
    $('.gamemap').click(function () {
        if (t) {
            $(this).toggleClass('player1');
            t = false;
        } else {
            $(this).toggleClass('player2');
            t = true;
        }
    });
    $('button').click(function () {
        $('.gamemap').removeClass('player1 player2');
    });

});
