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
			url: "MapDeductionsPlans.aspx/Save",
			data: JSON.stringify(data)
		});
	});
});