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
        "bInfo": false,
        "pagingType": "full_numbers",
        lengthMenu: [
            [5, 10, 20, -1],
            [5, 10, 20, 'All'],
        ],
        "processing": true,
        "serverSide": true,
        "order": [],
        "ajax": {
            url: "./action/action_history.php",
            type: "POST",
            'data': function (data) {
                var from_date = $('#search_fromdate').val();
                var to_date = $('#search_todate').val();

                data.action = 'listHistory';
                data.searchByFromdate = from_date;
                data.searchByTodate = to_date;
            },
            dataType: "json",
        },
        "columnDefs": [
            {
                targets: [7],
                "orderable": false,
            },
        ]
    });
    $('#btn_search').click(function () {
        if ($('#search_fromdate').val() != '' && $('#search_todate').val() != '') {
            historyData.draw();
        }
    });
    $('#history_customer').click(function () {
        historyData.draw();
    });
})