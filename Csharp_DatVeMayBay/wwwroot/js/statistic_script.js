$(document).ready(function () {
    var statisticData = $('#dt-statistic').DataTable({
        "oLanguage": {
            "oPaginate": {
                "sPrevious": "Trước",
                "sNext": "Sau",
                "sLast": "Cuối",
                "sFirst": "Đầu"
            },
            "sEmptyTable": "Không có dữ liệu"
        },
        "processing": true,
        "ordering": false,
        "ajax": {
            "url": "/api/Statistic/GetStatistic",
            "type": "POST",
            "dataType": "json",
            "dataSrc": "data"
        },
        "columns": [
            { "data": "totalTickets" },
            { "data": "totalTicketsPaid" },
            {
                "data": "totalRevenue",
                "render": function (data, type, row) {
                    return formatCurrency(data);
                }
            }
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

    $('#btn_search').click(function () {
        var fromDate = $('#search_fromdate').val();
        var toDate = $('#search_todate').val();
        statisticData.ajax.url("/api/Statistic/GetStatistic?fromDate=" + fromDate + "&toDate=" + toDate).load();
        if (fromDate !== "" && toDate !== "") {
           
        } else {
            statisticData.ajax.url("/api/Statistic/GetStatistic").load();
        }
    });

    $('#statistic').click(function () {
        $('#search_fromdate').val('');
        $('#search_todate').val('');
        statisticData.ajax.reload();
    });
});
