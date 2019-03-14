let sessionID;
newRandomNumber();

$("#form").submit((e) => {
    e.preventDefault();
    verifyGuess();
})

$("#resetButton").click(() => {
    newRandomNumber();
    $("#hint").html("");
    $("#resetButton").css("visibility", "hidden");
})  

function newRandomNumber() {
    $.ajax({
        url: "Home/newRandomNumber",
        type: "POST"
    }).done((data) => {
        sessionID = data;
    });
}

function verifyGuess() {
    const input = $("#input").val();
    $.ajax({
        url: "Home/verifyGuess",
        type: "POST",
        data: { input, sessionID }
    }).done((data) => {
        if (data == "Equal") {
            $("#hint").html("Congratulations! <br> You guessed correctly! <br><br> Would you like to play again?");
            $("#resetButton").css("visibility", "visible");
        } else {
            $("#hint").html(data);
        }
        $("#input").val("");
    });
}
