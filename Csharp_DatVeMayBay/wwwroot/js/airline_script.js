$(document).ready(function () {
	var airlineData = $('#dt-airline').DataTable({
		"oLanguage": {
			"sLengthMenu": "Hiện _MENU_ hãng bay",
			"oPaginate": {
				"sPrevious": "Trước",
				"sNext": "Sau",
				"sLast": "Cuối",
				"sFirst": "Đầu"
			},
			"sEmptyTable": "Không có dữ liệu"
		},
		"ajax": {
			"url": "/api/Airlines/GetAllAirlines",
			"type": "POST",
			"dataType": "json",
			"dataSrc": "data"
		},
		"processing": true,
		"columns": [
			{
				"data": "airlineId",
			},
			{ "data": "airlineName" },
			{ "data": "airlineCode" },
			{
				"data": "airlineLogo",
				"render": function (data, type, row) {
					return '<img src="' + data.substring(1) + '" class="img-thumbnail img-fluid"  style="max-height: 100px; max-width: 140px"/>';
				}
			},
			{
				"data": "airlineId",
				"render": function (data, type, row) {
					return '<button type="button" class="update btn btn-outline-success" data-id="' + data + '">Sửa</button>';
				}
			},
			{
				"data": "airlineId",
				"render": function (data, type, row) {
					return '<button type="button" class="delete btn btn-outline-danger" data-id="' + data + '">Xoá</button>';
				}
			}
		],
		"columnDefs": [
			{
				"targets": [3,4],
				"orderable": false,
			},
		]
	});
	 $('#addAirport').click(function(){
		$('#error-message').hide();
		$('#AirportModal').modal('show');
		$('#AirportForm')[0].reset();
		$('.modal-title').html("<i class='fa fa-plus'></i>Thêm sân bay");
		$('#action').val('addAirport');
		$('#save').val('Thêm');
	});	
	$("#dt-airline").on('click', '.update', function () {
		$('#error-message').hide();
		var airlineId = $(this).attr("data-id");
		$('.modal-title').html("<i class='fa fa-plus'></i>Sửa hãng bay");
		$.ajax({
			url: '/api/Airlines/GetAirLineById',
			method: "POST",
			data: { airline_id: airlineId},
			dataType: "json",
			success: function (data) {
				$('#AirlineModal').modal('show');
				$('#airline_id').val(data.data.airlineId);
				$('#airline_name').val(data.data.airlineName);
				$('#airline_code').val(data.data.airlineCode);
				$('#img_uploaded').html(data.data.airlineLogo);
				$('.modal-title').html("<i class='fa fa-plus'></i>Sửa hãng bay");
				$('#save').val('Sửa');
			}
		});
	});
	$("#dt-airline").on('click', '.delete', function () {
		$('#error-message').hide();
		var airlineId = $(this).attr("data-id");
		$.ajax({
			url: "/api/Airlines/GetAirLineById",
			method: "POST",
			data: { airline_id: airlineId},
			dataType: "json",
			success: function (data) {
				$('#deleteModal').modal('show');
				$('#delete_airline_id').val(data.data.airlineId);
				$("#deleteModal .modal-body").text('Bạn có chắc muốn xoá hãng bay ' + data.data.airlineName + '?');
				$('#delete_action').val('airlineDelete');
			}
		})
	});

	$('#addAirline').click(function () {
		$('#airline_logo img').hide();
		$('#error-message').hide();
		$('#AirlineModal').modal('show');
		$('#AirlineForm')[0].reset();
		$('.modal-title').html("<i class='fa fa-plus'></i>Thêm hãng bay");
		$('#save').val('Thêm');
	});

	$("#AirlineModal").on('submit', '#AirlineForm', function (event) {
		event.preventDefault();
		var extension = $('#airline_logo').val().split('.').pop().toLowerCase();
		if ($.inArray(extension, ['gif', 'jpg', 'png', 'jpeg']) == -1) {
			if ($('#error-message').hasClass("alert-success")) {
				$('#error-message').removeClass("alert-success").addClass("alert-warning");
			}
			$('#error-message strong').text("Không phải file ảnh");
			$('#error-message').show();
			$('#airline_logo').val('');
			return false;
		}
		let urlValue;
		if ($('#save').val() == "Sửa") {
			urlValue = "/api/Airlines/UpdateAirline"
		}
		else {
			urlValue = "/api/Airlines/AddAirline"
		}
		$.ajax({
			url: urlValue,
			method: "POST",
			data: new FormData(this),
			contentType: false,
			processData: false,
			dataType: "json",
			success: function (data) {
				if (data.data.status) {
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(data.data.message);
					$('#error-delete-message').show();
					$('#AirlineForm')[0].reset();
					$('#AirlineModal').modal('hide');
					airlineData.ajax.reload(null, false);
				} else {
					$('#error-message').removeClass("alert-success").addClass("alert-warning");
					$('#error-message strong').text(data.data.message);
					$('#error-message').show();
				}
			}
		})
		if ($('#error-message').hasClass('show')) {
			setTimeout(function () {
				$('#error-message').fadeOut();
			}, 2000);
		}
	});
	$("#deleteModal").on('submit', '#DeleteAirlineForm', function (event) {
		event.preventDefault();
		$('#delete_save').attr('disabled', 'disabled');
		var airline_id = $("#delete_airline_id");
		$.ajax({
			url: "/api/Airlines/DeleteAirline",
			method: "POST",
			data: airline_id,
			dataType: "json",
			success: function (data) {
				$('#DeleteAirlineForm')[0].reset();
				$('#deleteModal').modal('hide');
				$('#delete_save').attr('disabled', false);
				if (data.data.status) {
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(data.data.message);
					$('#error-delete-message').show();
					airlineData.ajax.reload(null, false);
				} else {
					$('#error-delete-message').removeClass('alert-success').addClass('alert-warning');
					$('#error-delete-message strong').text(data.data.message);
					$('#error-delete-message').show();
				}
			}
		});
		if ($('#error-delete-message').hasClass('show')) {
			setTimeout(function () {
				$('#error-delete-message').fadeOut();
			}, 2000);
		}
	});
/*	$("#dt-airline").on('click', '.delete', function () {
		$('#error-message').hide();
		var airlineId = $(this).attr("id");
		var action = 'getAirline';
		$.ajax({
			url: "./action/action_airline.php",
			method: "POST",
			data: { airline_id: airlineId, action: action },
			dataType: "json",
			success: function (data) {
				$('#deleteModal').modal('show');
				$('#delete_airline_id').val(data.airline_id);
				$("#deleteModal .modal-body").text('Bạn có chắc muốn xoá hãng bay có mã: ' + data.airline_id);
				$('#delete_action').val('airlineDelete');
			}
		})
	});*/
	$('#error-message .btn-close').on('click', function () {
		$('#error-message').fadeOut();
	});
	$('#error-delete-message .btn-close').on('click', function () {
		$('#error-delete-message').fadeOut();
	});

})