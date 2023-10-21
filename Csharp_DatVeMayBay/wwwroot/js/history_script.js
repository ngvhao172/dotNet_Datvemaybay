//QUỲNH: FIX LẠI CHỖ NÀY, THAM KHẢO CÁC FILE JS HÀO ĐÃ LÀM TRƯỚC ĐÓ

$(document).ready(function () {
    var historyData = $('#dt-history').DataTable({
        "oLanguage": {
            "sLengthMenu": "Hiện _MENU_ dòng",
            "oPaginate": {
                "sPrevious": "Trước",
                "sNext": "Sau",
                "sLast": "Cuối",
                "sFirst": "Đầu"
            },
            "sEmptyTable": "Không có dữ liệu"
        },
        "processing": true,
        "ajax": {
            "url": "/api/HistoryTickets/GetAllTicket",
            "type": "GET",
            "dataType": "json",
            "dataSrc": "data"
        },
        "columns": [
            { "data": "userId", },
            { "data": "userEmail" },
            { "data": "bookingId" },
            { "data": "bookingDatime" },
            { "data": "flightId" },
            { "data": "ticketId" },
            {
                "data": "ticketPrice",
                "render": function (data, type, row) {
                    return formatCurrency(data);
                }
            },
            { "data": "status" }
        ],
        "columnDefs": [
            {
                "targets": [7],
                "orderable": false,
            },
        ],
    });
    function formatCurrency(value) {
        // Sử dụng toLocaleString() với ngôn ngữ 'vi-VN' (Tiếng Việt, Việt Nam)
        // và các tùy chọn định dạng tiền tệ (style: 'currency', currency: 'VND')
        if (value) {
            return value.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' });
        }
        else {
            value = 0;
            return value.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' });
        }
    }
/*    $('#btn_search').click(function () {
        if ($('#search_fromdate').val() != '' && $('#search_todate').val() != '') {
            historyData.draw();
        }
    });
    $('#history_customer').click(function () {
        historyData.draw();
    });*/
})