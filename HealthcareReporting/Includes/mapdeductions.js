$(document).ready(function () {
	$('#btnCancel').click(function () {
		alert("Cancelling to Calling Page...");
		window.location = "";
	});
	$('#btnUpdate').click(function () {
		var updates = [];
		$("#lstSelected option").each(function (id, option) {
			updates.push(option.value);
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