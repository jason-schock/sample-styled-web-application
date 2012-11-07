$(document).ready(function () {
	$('.deduction').hover(
		function () { $(this).closest("td").find(".popup").show(); },
		function () { $(this).closest("td").find(".popup").hide(); }
	);
	$('table.highlighted tr').hover(
		function () { if (!$(this).hasClass("GreenHeader")) { $(this).toggleClass("highlighted"); } },
		function () { if (!$(this).hasClass("GreenHeader")) { $(this).toggleClass("highlighted"); } }
	);
	$('tr.pager a, tr th a').click(function (e) {
		var $textboxes = $("input.adjustment");
		var stop = false;
		for (var i = 0; i < $textboxes.length; i++) {
			var $textbox = $($textboxes[i]);
			if ($textbox.data("original") !== undefined && $textbox.data("original") !== $textbox.val()) {
				$textbox.addClass("warning");
				stop = true;
			}
		}

		if (stop) {
			e.preventDefault();
			alert("Please save the changes before moving on.");
			return false;
		}
		return true;
	});
	$("input.adjustment").focus(function () {
		$(this).data("original", $(this).val());
		$(this).select();
	});
	$('#btnCancel').click(function () {
		alert("Cancelling to Calling Page...");
		window.location = "";
	});
	$("#btnMapDeductionsPlans").click(function () {
		window.location = "MapDeductionsPlans.aspx";
	});
	$("#btnUpdate").click(function () {
		var updates = [];
		$("input.edit").each(function (id, textbox) {
			var userId = $(textbox).closest("tr").find("span.name").next("input:hidden").val();
			updates.push(userId + "=" + $(textbox).val());
		});
		var data = { 'updates': updates.join(", ") };
		$.ajax({
			type: "POST",
			url: "Default.aspx/Save",
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