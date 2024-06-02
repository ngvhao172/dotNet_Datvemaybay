function showModal(event) {
    // perform validation here
    var count = $(".card-booking").length;

    if (count == 0) {
        event.preventDefault();
        $('#exampleModal').modal('show');
        // prevent form submission
    } else {
        // allow form submission
        $("#paymentMethod").val("Creditcard");
        $("#pay-button").prop("type", "submit");
        // 
    }
}
$("#payWithMomo").on("click", () => {
    $("#paymentMethod").val("Momo");
    $("#ticket-processing").submit();
})
var creditCardList = [];

if(!@User.Identity.IsAuthenticated) {
    var cardsJSON = sessionStorage.getItem('creditCardList');

    if (cardsJSON) {
        var cards = JSON.parse(cardsJSON);
        if (cards.length > 0) {
            cards.forEach((card) => {
                var cardHtml = `
                <div class="row p-4 mb-5 m-0 card-booking" style="background: #8DD3BB; border-radius: 12px;">
                    <div class="col-md-1 col-12"><i class="fa-brands fa-cc-visa"></i></div>
                    <div class="col-md-4 col-12"><span class="" name="carnumber">${card.cardNumber}</span></div>
                    <div class="col-md-3 col-12"><span class="" name="nameoncard">${card.cardHolderName}</span></div>
                    <div class="col-md-3 col-12"><span class="" name="validation">${card.cardDate}</span></div>
                    <div class="col-md-1 col-12"><input type="radio" name="check" id="" checked></div>
                </div>`;

                // Thêm card vào container
                $("#card-container").append(cardHtml);
            });
        }
    } else {
        // Xử lý trường hợp không có dữ liệu trong sessionStorage
        console.log("Không có dữ liệu thẻ tín dụng trong sessionStorage.");
    }
}
$("#addNewCard").on('click', function () {
    var cardHolderName = $("#holdername").val();
    var cardDate = $("#expdate").val();
    var cardNumber = $("#cardnum").val();
    if (cardNumber) {
        // Tạo một thẻ div mới làm card
        //var $card = $('<div></div>').addClass('card').text(cardName);
        var cardHtml = `
                <div class="row p-4 mb-5 m-0 card-booking" style="background: #8DD3BB; border-radius: 12px;">
                    <div class="col-md-1 col-12"><i class="fa-brands fa-cc-visa"></i></div>
                    <div class="col-md-4 col-12"><span class="" name="carnumber">${cardNumber}</span></div>
                    <div class="col-md-3 col-12"><span class="" name="nameoncard">${cardHolderName}</span></div>
                    <div class="col-md-3 col-12"><span class="" name="validation">${cardDate}</span></div>
                    <div class="col-md-1 col-12"><input type="radio" name="check" id="" checked></div>
                </div>`;

        // Thêm card vào container
        $("#card-container").append(cardHtml);
        const newCreditCard = { CardNumber: cardNumber, CardHolderName: cardHolderName, ExpirationDate: cardDate }
        creditCardList.push(newCreditCard);
        $("#cardCreditList").val(JSON.stringify(creditCardList))

        sessionStorage.setItem('creditCardList', JSON.stringify(creditCardList));
        // Xóa nội dung trong input và ẩn modal
        $("#holdername").val('');
        $("#expdate").val('');
        $("#cardnum").val('');
        $('#exampleModal').modal('hide');

        if (@User.Identity.IsAuthenticated) {
            $.ajax({
                url: '/api/User/AddingNewCreditCard',
                method: "POST",
                data: {
                    cardHolderName: cardHolderName,
                    cardDate: cardDate,
                    cardNumber: cardNumber,
                },
                dataType: "json",
                success: function (data) {
                    console.log(data)
                }
            });
        }
    }
})
