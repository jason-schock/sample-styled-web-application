$(document).ready(function () {
	//
	// Reload the page, lose all the changes.
	//
	$('#btnCancel').click(function () {
		alert("Cancelling to Calling Page...");
		window.location = "";
	});
});