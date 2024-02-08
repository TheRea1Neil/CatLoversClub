$("#buttonSubmit").click(function () {
    alert("From " + $("#txtFrom").val() +
        ", Subject= " + $("#txtSubject").val() +
        ", Messge" + $("#txtMessage").val());

    $("#imgGanderson").fadeOut("slow")
});


$("#CatSubmit").click(function () {
    alert("Get Ready for the savings!");
        // Get the value of the hours input
        var hours = parseInt($("#hours").val());

        // Get the value of the pricePerHour input and remove the dollar sign
        var pricePerHour = parseInt($("#pricePerHour").val().replace(/\D/g, ''));

        // Multiply hours by pricePerHour
        var result = hours * pricePerHour;

        // Update the text of the output h3 tag
        $("#output").text("$" + result + "! WOW!!!");
    });
