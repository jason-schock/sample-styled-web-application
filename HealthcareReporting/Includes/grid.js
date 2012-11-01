$(document).ready(function () {
	$('.deduction').hover(
		function () { $(this).closest("td").find(".popup").show(); },
		function () { $(this).closest("td").find(".popup").hide(); }
	);
	$('table.highlighted tr').hover(
		function () { $(this).toggleClass("highlighted"); },
		function () { $(this).toggleClass("highlighted"); }
	);
	$('tr.pager a, tr th a').click(function (e) {
		var edits = $("input.edit");
		for (var i = 0; i < edits.length; i++) {
			var textbox = $(edits[i]);
			var originalValue = textbox.closest("td").find("span.adjustment").text();
			if (originalValue != textbox.val()) {
				e.preventDefault();
				alert("Please save the changes before moving on.");
				return false;
			}
		}
		return true;
	});
	$("span.adjustment").click(function () {
		var $td = $(this).parent();
		if ($td.find("input.edit").length > 0) {
			return;
		}
		$(this).hide();

		$td.append("<input class='edit' type='text' value='" + $(this).text() + "'>");
		$td.find("input.edit").focus();
		$td.find("input.edit").select();
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
				$("input.edit").closest("td").addClass("attention");
				window.location = "";
			},
			error: function (xhr, ajaxOptions, thrownError) {
				alert(xhr.responseText);
			}
		});
	});
});