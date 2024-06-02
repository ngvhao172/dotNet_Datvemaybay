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
            "url": "/api/Management/ManageData",
            "type": "POST",
            "dataType": "json",
            "data": function () {
                return {
                    dataType: "Statistic",
                    action: "GetAll",
                    fromDate: $('#search_fromdate').val(),
                    toDate: $('#search_todate').val()
                };
            },
            "dataSrc": "data"
        },
        "columns": [
            { "data": "totalTickets", },
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

        if (fromDate !== "" && toDate !== "") {
            statisticData.ajax.data = {
                dataType: "Statistic",
                action: "GetAll",
                fromDate: fromDate,
                toDate: toDate
            };
            statisticData.ajax.reload();
        } else {
        }   
    });

    $('#statistic').click(function () {
        $('#search_fromdate').val('');
        $('#search_todate').val('');
        statisticData.ajax.reload();
    });
});
