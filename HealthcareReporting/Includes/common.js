$(document).ready(function () {
	//
	// Reload the page, lose all the changes.
	//
	$('#btnCancel').click(function () {
		alert("Cancelling to Calling Page...");
		window.location = "";
	});

	//
	// Setup default ajax settings
	//
	$.ajaxSetup({
		global: false,
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		type: "POST",
		success: function (response) {
			window.location = "";
		},
		error: function (xhr, ajaxOptions, thrownError) {
			alert(xhr.responseText);
		}
	});
});