$(document).ready(function () {
	var flightData = $('#dt-flight').DataTable({
		"oLanguage": {
			"sLengthMenu": "Hiện _MENU_ chuyến bay",
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
			"dataSrc": "data",
			"data": function () {
				return {
					dataType: "Flight",
					action: "GetAll",
					fromDate: $('#search_fromdate').val(),
					toDate: $('#search_todate').val()
				};
			},
			"dataType": "json"
		},
		"columns": [
			{ "data": "flightId" },
			{ "data": "airline.airlineName" },
			{ "data": "departureAirport.airportName" },
			{ "data": "arrivalAirport.airportName" },
			{ "data": "departureDatetime" },
			{ "data": "arrivalDatetime" },
			{
				"data": "economyPrice",
				"render": function (data, type, row) {
					return formatCurrency(data);
				}
			},
			{
				"data": "bussinessPrice",
				"render": function (data, type, row) {
					return formatCurrency(data);
				}
			},
			{
				"data": "flightId",
				"render": function (data, type, row) {
					return '<button type="button" class="update btn btn-outline-success" data-id="' + data + '">Sửa</button>';
				}
			},
			{
				"data": "flightId",
				"render": function (data, type, row) {
					return '<button type="button" class="delete btn btn-outline-danger" data-id="' + data + '">Xoá</button>';
				}
			}
		],
		"columnDefs": [
			{
				"targets": [8, 9],
				"orderable": false,
			},
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
	var flightDataToday = $('#dt-flight-today').DataTable({
		"oLanguage": {
			"sLengthMenu": "Hiện _MENU_ chuyến bay",
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
			url: "/api/Management/ManageData",
			type: "POST",
		/*	'data': function (data) {
				var from_date = $('#search_fromdate').val();
				var to_date = $('#search_todate').val();
				data.searchByFromdate = from_date;
				data.searchByTodate = to_date;
			},*/
			"data": {
				dataType: "Flight",
				action: "GetToday"
			},
			dataType: "json",
			"dataSrc": "data",
		},
		"columns": [
			{ "data": "flightId" },
			{ "data": "airline.airlineName" },
			{ "data": "departureAirport.airportName" },
			{ "data": "arrivalAirport.airportName" },
			{ "data": "departureDatetime" },
			{ "data": "arrivalDatetime" },
			{
				"data": "economyPrice",
				"render": function (data, type, row) {
					return formatCurrency(data);
				}
			},
			{
				"data": "bussinessPrice",
				"render": function (data, type, row) {
					return formatCurrency(data);
				}
			},
			{
				"data": "flightId",
				"render": function (data, type, row) {
					return '<button type="button" class="update btn btn-outline-success" data-id="' + data + '">Sửa</button>';
				}
			},
			{
				"data": "flightId",
				"render": function (data, type, row) {
					return '<button type="button" class="delete btn btn-outline-danger" data-id="' + data + '">Xoá</button>';
				}
			}
		],
		"columnDefs": [
			{
				"targets": [8, 9],
				"orderable": false,
			},
		],
	});
	$.ajax({
		url: '/api/Management/ManageData',
		type: 'POST',
		dataType: 'json',
		"data": {
			dataType: "Airline",
			action: "GetAll"
		},
		success: function (data) {
			var options = '<option value="">Chọn hãng bay</option>';
			$.each(data.data, function (key, value) {
				options += '<option value="' + value.airlineId + '">' + value.airlineName + '</option>';
			});
			$('#airline_id').html(options);
		}
	});
	$.ajax({
		url: '/api/Management/ManageData',
		type: 'POST',
		dataType: 'json',
		"data": {
			dataType: "Airport",
			action: "GetAll"
		},
		success: function (data) {
			var options1 = '<option value="">Chọn sân bay khởi hành</option>';
			var options2 = '<option value="">Chọn sân bay đích</option>';
			$.each(data.data, function (key, value) {
				options1 += '<option value="' + value.airportId + '">' + value.airportName + '</option>';
				options2 += '<option value="' + value.airportId + '">' + value.airportName + '</option>';
			});
			$('#departure_airport_id').html(options1);
			$('#arrival_airport_id').html(options2);
		}
	});
	$('#addFlight').click(function () {
		$('#error-message').hide();
		$('#FlightModal').modal('show');
		$('#FlightForm')[0].reset();
		$('.modal-title').html("<i class='fa fa-plus'></i>Thêm chuyến bay");
		$('#action').val('addFlight');
		$('#save').val('Thêm');
	});
	$("#dt-flight, #dt-flight-today").on('click', '.update', function () {
		$('#error-message').hide();
		var flightId = $(this).attr("data-id");
		$.ajax({
			url: '/api/Management/ManageData',
			method: "POST",
			data: {
				dataType: "Flight",
				action: "GetById",
				flight_id: flightId
			},
			dataType: "json",
			success: function (response) {
				if (response.status) {
					data = response.data;
					$('#FlightModal').modal('show');
					$('#flight_id').val(data.flightId);
					$('#airline_id').val(data.airlineId);
					$('#departure_airport_id').val(data.departureAirportId);
					$('#arrival_airport_id').val(data.arrivalAirportId);
					$('#departure_datetime').val(data.departureDatetime);
					$('#arrival_datetime').val(data.arrivalDatetime);
					$('#economy_price').val(data.economyPrice);
					$('#business_price').val(data.bussinessPrice);
					$('.modal-title').html("<i class='fa fa-plus'></i>Sửa chuyến bay");
					$('#save').val('Sửa');
				}
			}
		});
	});

	$("#FlightModal").on('submit', '#FlightForm', function (event) {
		event.preventDefault();

		var flightId = $("#flight_id").val();
		var airlineId = $("#airline_id").val();
		var departureAirportId = $("#departure_airport_id").val();
		var arrivalAirportId = $("#arrival_airport_id").val();
		var departureDatetime = $("#departure_datetime").val();
		var arrivalDatetime = $("#arrival_datetime").val();
		var economyPrice = $("#economy_price").val();
		var bussinessPrice = $("#business_price").val();
		let action;
		if ($('#save').val() == "Sửa") {
			action = "Update"
		}
		else {
			action = "Add"
		}
		$.ajax({
			url: '/api/Management/ManageData',
			method: "POST",
			data: {
				action: action,
				dataType: "Flight",
				flight_id: flightId,
				airline_id: airlineId,
				departure_airport_id: departureAirportId,
				arrival_airport_id: arrivalAirportId,
				departure_datetime: departureDatetime,
				arrival_datetime: arrivalDatetime,
				economy_price: economyPrice,
				business_price: bussinessPrice,
			},
			dataType: "json",
			success: function (response) {
				if (response.status) {
					data = response.data;
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(response.message);
					$('#error-delete-message').show();
					$('#FlightForm')[0].reset();
					$('#FlightModal').modal('hide');
					flightData.ajax.reload(null, false);
					flightDataToday.ajax.reload(null, false);
				} else {
					$('#error-message').removeClass("alert-success").addClass("alert-warning");
					$('#error-message strong').text(response.message);
					$('#error-message').show();
				}
				/*$('#save').attr('disabled', false);
				if (data.success) {
					$('#error-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-message strong').text(data.message);
					$('#error-message').show();
					flightData.ajax.reload(null, false);
					flightDataToday.ajax.reload(null, false);
				} else {
					if ($('#error-message').hasClass("alert-success")) {
						$('#error-message').removeClass("alert-success").addClass("alert-warning");
					}
					$('#error-message strong').text(data.message);
					$('#error-message').show();
				}*/
			}
		})
		if ($('#error-message').hasClass('show')) {
			setTimeout(function () {
				$('#error-message').fadeOut();
			}, 5000);
		}
		if ($('#error-delete-message').hasClass('show')) {
			setTimeout(function () {
				$('#error-delete-message').fadeOut();
			}, 5000);
		}
	});
	$("#deleteModal").on('submit', '#DeleteFlightForm', function (event) {
		event.preventDefault();
		$('#delete_save').attr('disabled', 'disabled');
		var flight_id = $('#delete_flight_id').val();
		$.ajax({
			url: '/api/Management/ManageData',
			method: "POST",
			data: {
				dataType: "Flight",
				action: "Delete",
				flight_id: flight_id	
			},
			dataType: "json",
			success: function (response) {
				$('#DeleteFlightForm')[0].reset();
				$('#deleteModal').modal('hide');
				$('#delete_save').attr('disabled', false);
				if (response.status) {
					data = response.data;
					$('#error-delete-message').removeClass('alert-warning').addClass('alert-success');
					$('#error-delete-message strong').text(response.message);
					$('#error-delete-message').show();
					flightData.ajax.reload(null, false);
					flightDataToday.ajax.reload(null, false);
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
	$("#dt-flight, #dt-flight-today").on('click', '.delete', function () {
		$('#error-message').hide();
		var flightId = $(this).attr("data-id");
		$.ajax({
			url: '/api/Management/ManageData',
			method: "POST",
			data: {
				dataType: "Flight",
				action: "GetById",
				flight_id: flightId
			},
			dataType: "json",
			success: function (response) {
				if (response.status) {
					data = response.data;
					$('#deleteModal').modal('show');
					$('#delete_flight_id').val(data.flightId);
					$("#deleteModal .modal-body").html('Bạn có chắc muốn xoá chuyến bay có mã:  <strong>' + data.flightId + ' </strong>?');
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
	var tabclick = "today";
	$('#btn_search').click(function () {
		if ($('#search_fromdate').val() != '' || $('#search_todate').val() != '') {
			if (tabclick === "allflight") {
				flightData.draw();
			} else {
				flightDataToday.draw();
			}
		}
	});
	$('#today_flight').click(function () {
		tabclick = "today";
		$('#search_fromdate').val('');
		$('#search_todate').val('');
		flightDataToday.draw();
	});
	$('#all_flight').click(function () {
		tabclick = "allflight";
		$('#search_fromdate').val('');
		$('#search_todate').val('');
		flightData.draw();
	});
	$('#btn_search').click(function () {
		var fromDate = $('#search_fromdate').val();
		var toDate = $('#search_todate').val();

		if (fromDate !== "" && toDate !== "") {
			flightData.ajax.data = {
				dataType: "Statistic",
				action: "GetAll",
				fromDate: fromDate,
				toDate: toDate
			};
			flightData.ajax.reload();
		} else {
		}
	});
})