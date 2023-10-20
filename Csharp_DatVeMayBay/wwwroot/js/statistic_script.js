$(document).ready(function () {
    var statisticData = $('#dt-statistic').DataTable({
        "oLanguage": {
            "sEmptyTable": "Không có dữ liệu"
        },
        "processing": true,
        "ordering": false,
        "ajax": {
            "url": "/api/Statistic/GetStatistic",
            "type": "GET",
            "dataType": "json",
            "dataSrc": "data"
        },
        "columns": [
            { "data": "totalTickets", },
            { "data": "totalRevenue" }
        ],
    });

    $('#btn_search').click(function () {
        var fromDate = $('#search_fromdate').val();
        var toDate = $('#search_todate').val();
        if (fromDate !== "" && toDate !== "") {
            statisticData.ajax.url("/api/Statistic/GetStatistic?fromDate=" + fromDate + "&toDate=" + toDate).load();
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
