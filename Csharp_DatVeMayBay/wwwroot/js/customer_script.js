//QUỲNH: FIX LẠI CHỖ NÀY, THAM KHẢO CÁC FILE JS HÀO ĐÃ LÀM TRƯỚC ĐÓ

$(document).ready(function () {
    var userData = $('#dt-user').DataTable({
        "oLanguage": {
            "sLengthMenu": "Hiện _MENU_ người dùng",
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
            url: "./action/action_user.php",
            type: "POST",
            data: { action: 'listUser' },
            dataType: "json"
        },
        "columnDefs": [
            {
                "targets": [7],
                "orderable": false,
            },
        ],
    });
    $("#dt-user").on('click', '.delete', function () {
        $('#error-message').show();
        var userId = $(this).attr("id");
        var action = 'getUser';
        $.ajax({
            url: "./action/action_user.php",
            method: "POST",
            data: { id: userId, action: action },
            dataType: "json",
            success: function (data) {
                $('#deleteModal').modal('show');
                $('#delete_user').val(data.id);
                $("#deleteModal .modal-body").text('Bạn có chắc muốn xoá người dùng: ' + data.email);
                $('#delete_action').val('userDelete');
            }
        });
    });
    $("#deleteModal").on('submit', '#DeleteUserForm', function (event) {
        event.preventDefault();
        $('#delete_save').attr('disabled', 'disabled');
        var formData = $(this).serialize();
        $.ajax({
            url: "./action/action_user.php",
            method: "POST",
            data: formData,
            dataType: "json",
            success: function (data) {
                $('#DeleteUserForm')[0].reset();
                $('#deleteModal').modal('hide');
                $('#delete_save').attr('disabled', false);
                if (data.success) {
                    $('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
                    $('#error-delete-message strong').text(data.message);
                    $('#error-delete-message').show();
                    userData.ajax.reload(null, false);
                } else {
                    $('#error-delete-message').removeClass('alert-success').addClass('alert-warning');
                    $('#error-delete-message strong').text(data.message);
                    $('#error-delete-message').show();
                }
            }
        });
        if ($('#error-delete-message').hasClass('show')) {
            setTimeout(function () {
                $('#error-delete-message').fadeOut();
            }, 5000);
        }
    });
    $('#error-delete-message .btn-close').on('click', function () {
        $('#error-delete-message').fadeOut();
    });
})