$("#form").submit((e) => e.preventDefault());

$(document).ready(() => {
	$("#form").submit(() => {
	   const input = $("#input").val();
	   
	   $.ajax({
		   url: "Home/verifyGuess",
		   type: "POST",
		   data: {input}
	   }).done((data) => {
		   $("#hint").html(data);
		   if (data == "Equal") {
		       $("#hint").html("Congratulations! <br> You guessed correctly! <br><br> Would you like to play again?");
			   $("#resetButton").css("visibility", "visible");
		   }
		   $("#input").val("");
	   });
	});

	$("#resetButton").click(() => {
		$.ajax({
			url: "Home/newRandomNumber",
			type: "POST"
		});
		$("#hint").html("");
		$("#resetButton").css("visibility", "hidden");
	})    
})

