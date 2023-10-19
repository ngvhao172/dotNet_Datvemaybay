//QUỲNH: FIX LẠI CHỖ NÀY, THAM KHẢO CÁC FILE JS HÀO ĐÃ LÀM TRƯỚC ĐÓ

$(document).ready(function () {
    var statisticData = $('#dt-statistic').DataTable({
        "oLanguage": {
            "sEmptyTable": "Không có dữ liệu"
        },
        "paging": false,
        "bInfo": false,
        lengthMenu: [
            [5, 10, 20, -1],
            [5, 10, 20, 'All'],
        ],
        "processing": true,
        "searching": false,
        "serverSide": true,
        "ordering": false,
        "ajax": {
            url: "./action/action_statistic.php",
            type: "POST",
            'data': function (data) {
                var from_date = $('#search_fromdate').val();
                var to_date = $('#search_todate').val();

                data.action = 'listStatistic';
                data.searchByFromdate = from_date;
                data.searchByTodate = to_date;
            },
            dataType: "json",
        },
    });
    $('#btn_search').click(function () {
        if ($('#search_fromdate').val() != '' && $('#search_todate').val() != '') {
            statisticData.draw();
        }
    });
    $('#statistic').click(function () {
        $('#search_fromdate').val('')
        $('#search_todate').val('')
        statisticData.draw();
    });
})