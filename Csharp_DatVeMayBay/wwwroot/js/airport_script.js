$(document).ready(function () {
	var airportData = $('#dt-airport').DataTable({
		"oLanguage": {
			"sLengthMenu": "Hiện _MENU_ sân bay",
			"oPaginate": {
				"sPrevious": "Trước",
				"sNext": "Sau",
				"sLast": "Cuối",
				"sFirst": "Đầu"
			},
			"sEmptyTable": "Không có dữ liệu"
		},
		"ajax": {
			"url": "/api/Management/ManageData",
			"type": "POST",
			"dataType": "json",
			"data": {
				dataType: "Airport",
				action: "GetAll"
			},
			"dataSrc": "data"
		},
		"processing": true,
		"columns": [
			{ "data": "airportId"},
			{ "data": "airportName" },
			{ "data": "airportLocation" },
			{ "data": "airportCode" },
			{
				"data": "airportId",
				"render": function (data, type, row) {
					return '<button type="button" class="update btn btn-outline-success" data-id="' + data + '">Sửa</button>';
				}
			},
			{
				"data": "airportId",
				"render": function (data, type, row) {
					return '<button type="button" class="delete btn btn-outline-danger" data-id="' + data + '">Xoá</button>';
				}
			}
		],
		"columnDefs": [
			{
				"targets": [4, 5],
				"orderable": false,
			},
		]
	});
	$('#addAirport').click(function () {
		$('#error-message').hide();
		$('#AirportModal').modal('show');
		$('#AirportForm')[0].reset();
		$('.modal-title').html("<i class='fa fa-plus'></i>Thêm sân bay");
		$('#action').val('addAirport');
		$('#save').val('Thêm');
	});
	$("#dt-airport").on('click', '.update', function () {
		$('#error-message').hide();
		var airportId = $(this).attr("data-id");
		$.ajax({
			url: '/api/Management/ManageData',
			method: "POST",
			data: {
				dataType: "Airport",
				action: "GetById",
				airport_id: airportId
			},
			dataType: "json",
			success: function (response) {
				if (response.status) {
					data = response.data;
					$('#AirportModal').modal('show');
					$('#airport_id').val(data.airportId);
					$('#airport_name').val(data.airportName);
					$('#airport_location').val(data.airportLocation);
					$('#airport_code').val(data.airportCode);
					$('.modal-title').html("<i class='fa fa-plus'></i>Sửa sân bay");
					$('#save').val('Sửa');
				}
				
			}
		});
	});

	$("#AirportModal").on('submit', '#AirportForm', function (event) {
		event.preventDefault();
		var airportName = $("#airport_name").val();
		var airportId = $("#airport_id").val();
		var airportCode = $("#airport_code").val();
		var airportLocation = $("#airport_location").val();
		let action;
		if ($('#save').val() == "Sửa") {
			action = "Update"
		}
		else {
			action = "Add"
		}
		$.ajax({
			url: "/api/Management/ManageData",
			method: "POST",
			data: {
				action: action,
				dataType: "Airport",
				airport_name: airportName,
				airport_id: airportId,
				airport_code: airportCode,
				airport_location: airportLocation,
			},
			dataType: "json",
			success: function (response) {
				if (response.status) {
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(response.message);
					$('#error-delete-message').show();
					$('#AirportForm')[0].reset();
					$('#AirportModal').modal('hide');
					airportData.ajax.reload(null, false);
				} else {
					$('#error-message').removeClass("alert-success").addClass("alert-warning");
					$('#error-message strong').text(response.message);
					$('#error-message').show();
				}
			}
				/*$('#save').attr('disabled', false);
				if (data.success) {
					$('#error-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-message strong').text(data.message);
					$('#error-message').show();
					$('#AirportForm')[0].reset();
					airportData.ajax.reload(null, false);
				} else {
					if ($('#error-message').hasClass("alert-success")) {
						$('#error-message').removeClass("alert-success").addClass("alert-warning");
					}
					$('#error-message strong').text(data.message);
					$('#error-message').show();
				}*/
			/*}*/
		})
		if ($('#error-message').hasClass('show')) {
			setTimeout(function () {
				$('#error-message').fadeOut();
			}, 10000);
		}
	});
	$("#deleteModal").on('submit', '#DeleteAirportForm', function (event) {
		event.preventDefault();
		$('#delete_save').attr('disabled', 'disabled');
		var airportId = $('#delete_airport_id').val();
		$.ajax({
			url: "/api/Management/ManageData",
			method: "POST",
			data: {
				dataType: "Airport",
				action: "Delete",
				airport_id: airportId
			},
			dataType: "json",
			success: function (response) {
				$('#DeleteAirportForm')[0].reset();
				$('#deleteModal').modal('hide');
				$('#delete_save').attr('disabled', false);
				if (response.status) {
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(response.message);
					$('#error-delete-message').show();
					airportData.ajax.reload(null, false);
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
	$("#dt-airport").on('click', '.delete', function () {
		$('#error-message').hide();
		var airportId = $(this).attr("data-id");
		$.ajax({
			url: "/api/Management/ManageData",
			method: "POST",
			data: {
				dataType: "Airport",
				action: "GetById",
				airport_id: airportId
			},
			dataType: "json",
			success: function (response) {
				if (response.status) {
					data = response.data;
					$('#deleteModal').modal('show');
					$('#delete_airport_id').val(data.airportId);
					$("#deleteModal .modal-body").html('Bạn có chắc muốn xoá sân bay <strong>' + data.airportName + '</strong>?');
					$('#delete_action').val('airportDelete');
				}
				
			}
		})
	});
	$('#error-message .btn-close').on('click', function () {
		$('#error-message').fadeOut();
	});
	$('#error-delete-message .btn-close').on('click', function () {
		$('#error-delete-message').fadeOut();
	});

})