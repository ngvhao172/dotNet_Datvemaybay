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
        "processing": true,
        "ajax": {
            "url": "/api/Management/ManageData",
            "type": "POST",
            "dataType": "json",
            "data": {
                dataType: "Customer",
                action: "GetAll"
            },
            "dataSrc": "data"
        },
        "columns": [
            { "data": "userId", },
            { "data": "userEmail" },
            { "data": "firstName" },
            { "data": "lastName" },
            { "data": "phoneNumber" },
            { "data": "address" },
            { "data": "dob" },
            {
                "data": "userId",
                "render": function (data, type, row) {
                    return '<button type="button" class="delete btn btn-outline-danger" data-id="' + data + '">Xoá</button>';
                }
            }

        ],
        "columnDefs": [
            {
                "targets": [7],
                "orderable": false,
            },
        ],
    });
    $("#dt-user").on('click', '.delete', function () {
        $('#error-message').show();
        var userId = $(this).attr("data-id");
        $.ajax({
            url: "/api/Management/ManageData",
            method: "POST",
            data: {
                dataType: "Customer",
                action: "GetById",
                user_id: userId
            },
            dataType: "json",
            success: function (response) {
                if (response.status) {
                    data = response.data;
                    $('#deleteModal').modal('show');
                    $('#delete_user').val(data.userId);
                    $("#deleteModal .modal-body").html('Bạn có chắc muốn xoá người dùng  <strong>' + data.firstName + ' ' + data.lastName + ' </strong>?');
                }
                
            }
        });
    });

    $("#deleteModal").on('submit', '#DeleteUserForm', function (event) {
        event.preventDefault();
        $('#delete_save').attr('disabled', 'disabled');
        var user_id = $('#delete_user').val();
        console.log(user_id);
        $.ajax({
            url: "/api/Management/ManageData",
            method: "POST",
            data: {
                dataType: "Customer",
                action: "Delete",
                user_id: user_id
            },
            dataType: "json",
            success: function (response) {
                $('#DeleteUserForm')[0].reset();
                $('#deleteModal').modal('hide');
                $('#delete_save').attr('disabled', false);
                if (response.status) {       
                    $('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
                    $('#error-delete-message strong').text(response.message);
                    $('#error-delete-message').show();
                    userData.ajax.reload(null, false);
                } else {
                    $('#error-delete-message').removeClass('alert-success').addClass('alert-warning');
                    $('#error-delete-message strong').text(response.message);
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