$(document).ready(function () {
	//
	// Save the changes.
	//
	$('#btnUpdate').click(function () {
		var updates = $.map($("#lstSelected option"), function (option, id) {
			return option.value;
		});
		var data = { 'updates': updates.join(", ") };
		$.ajax({
			type: "POST",
			url: "MapDeductionsPlans.aspx/Save",
			data: JSON.stringify(data),
			contentType: "application/json; charset=utf-8",
			dataType: "json",
			success: function (response) {
				window.location = "";
			},
			error: function (xhr, ajaxOptions, thrownError) {
				alert(xhr.responseText);
			}
		});
	});
});