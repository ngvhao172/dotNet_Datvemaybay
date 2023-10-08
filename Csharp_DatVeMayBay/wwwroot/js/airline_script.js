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
			url: "./action/action_airline.php",
			type: "POST",
			data: { action: 'listAirline' },
			dataType: "json"
		},
		"columnDefs": [
			{
				"targets": [3, 4],
				"orderable": false,
			},
		],
	});
	$('#addAirline').click(function () {
		$('#airline_logo img').hide();
		$('#error-message').hide();
		$('#AirlineModal').modal('show');
		$('#AirlineForm')[0].reset();
		$('.modal-title').html("<i class='fa fa-plus'></i>Thêm hãng bay");
		$('#action').val('addAirline');
		$('#save').val('Thêm');
	});
	$("#dt-airline").on('click', '.update', function () {
		$('#error-message').hide();
		var airlineId = $(this).attr("id");
		var action = 'getAirline';
		$.ajax({
			url: './action/action_airline.php',
			method: "POST",
			data: { airline_id: airlineId, action: action },
			dataType: "json",
			success: function (data) {
				$('#AirlineModal').modal('show');
				$('#airline_id').val(data.airline_id);
				$('#airline_name').val(data.airline_name);
				$('#img_uploaded').html(data.airline_logo);
				$('.modal-title').html("<i class='fa fa-plus'></i>Sửa hãng bay");
				$('#action').val('updateAirline');
				$('#save').val('Sửa');
			}
		});
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
		$.ajax({
			url: "./action/action_airline.php",
			method: "POST",
			data: new FormData(this),
			contentType: false,
			processData: false,
			dataType: "json",
			success: function (data) {
				if ($('#save').val() === "Sửa") {
					if (data.success) {
						$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
						$('#error-delete-message strong').text(data.message);
						$('#error-delete-message').show();
						$('#AirlineForm')[0].reset();
						$('#AirlineModal').modal('hide');
						airlineData.ajax.reload(null, false);
					} else {
						$('#error-message').removeClass("alert-success").addClass("alert-warning");
						$('#error-message strong').text(data.message);
						$('#error-message').show();
					}
					return;
				}
				$('#save').attr('disabled', false);
				if (data.success) {
					$('#error-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-message strong').text(data.message);
					$('#error-message').show();
					$('#AirlineForm')[0].reset();
					airlineData.ajax.reload(null, false);
				} else {
					if ($('#error-message').hasClass("alert-success")) {
						$('#error-message').removeClass("alert-success").addClass("alert-warning");
					}
					$('#error-message strong').text(data.message);
					$('#error-message').show();
				}
			}
		})
		if ($('#error-message').hasClass('show')) {
			setTimeout(function () {
				$('#error-message').fadeOut();
			}, 5000);
		}
	});
	$("#deleteModal").on('submit', '#DeleteAirlineForm', function (event) {
		event.preventDefault();
		$('#delete_save').attr('disabled', 'disabled');
		var formData = $(this).serialize();
		$.ajax({
			url: "./action/action_airline.php",
			method: "POST",
			data: formData,
			dataType: "json",
			success: function (data) {
				$('#DeleteAirlineForm')[0].reset();
				$('#deleteModal').modal('hide');
				$('#delete_save').attr('disabled', false);
				if (data.success) {
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(data.message);
					$('#error-delete-message').show();
					airlineData.ajax.reload(null, false);
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
	$("#dt-airline").on('click', '.delete', function () {
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
	});
	$('#error-message .btn-close').on('click', function () {
		$('#error-message').fadeOut();
	});
	$('#error-delete-message .btn-close').on('click', function () {
		$('#error-delete-message').fadeOut();
	});

})