$(document).ready(function () {
	var getChangedTextboxes = function () {
		var result = [];
		var $textboxes = $("input.adjustment");
		for (var i = 0; i < $textboxes.length; i++) {
			var $textbox = $($textboxes[i]);
			if ($textbox.data("original") !== undefined && $textbox.data("original") !== $textbox.val()) {
				result.push($textbox);
			}
		}
		return result;
	}
	var isNavigationAllowed = function (e) {
		var textboxes = getChangedTextboxes();
		if (textboxes.length == 0) {
			return true;
		}
		for (var i = 0; i < textboxes.length; i++) {
			textboxes[i].addClass("warning");
		}
		e.preventDefault();
		alert("Please click 'Update' to save the changes,\nor 'Cancel' to rollback.");
		return false;
	};

	//
	// Popup with deduction details when we mouse hover the total deduction.
	//
	$('.deduction').hover(
		function () { $(this).closest("td").find(".popup").show(); },
		function () { $(this).closest("td").find(".popup").hide(); }
	);

	//
	// Making sure we cannot move on if there are pending changes.
	//
	$('tr.pager a, tr th a').click(function (e) {
		return isNavigationAllowed(e);
	});

	//
	// Table row highlighting.
	//
	$('table.highlightable tr').hover(
		function () { if (!$(this).hasClass("header")) { $(this).toggleClass("highlighted"); } },
		function () { if (!$(this).hasClass("header")) { $(this).toggleClass("highlighted"); } }
	);

	//
	// Selecting textbox content on focus (doesn't work in Chrome?!).
	//
	$("input.adjustment").focus(function () {
		$(this).data("original", $(this).val());
		$(this).select();
	});

	//
	// Navigate to "MapDeductionsPlans" if allowed.
	//
	$("#btnMapDeductionsPlans").click(function (e) {
		if (isNavigationAllowed(e)) {
			window.location = "MapDeductionsPlans.aspx";
		}
	});

	//
	// Navigate to "ImportAdjustments" if allowed.
	//
	$("#btnImportAdjustments").click(function (e) {
		if (isNavigationAllowed(e)) {
			window.location = "ImportAdjustments.aspx";
		}
	});

	//
	// Save the changes.
	//
	$("#btnUpdate").click(function () {
		var updates = $.map(getChangedTextboxes(), function ($textbox, id) {
			var $row = $textbox.closest("tr");
			var ssn = $row.find("div.ssn > input:hidden").val();
			var year = $row.find("div.year > input:hidden").val();
			return ssn + " " + year + " " + $textbox.val();
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