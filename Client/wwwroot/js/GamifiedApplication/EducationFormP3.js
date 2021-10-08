function educationalForm() {
    
    $("#institution_check").click(function () { return false; });
    $("#qualification_check").click(function () { return false; });
    $("#eduStartDate_check").click(function () { return false; });
    $("#eduEndDate_check").click(function () { return false; });

    $("#eduStartDate_check").prop("checked", true);
    $("#eduStartDate_check").val(true);
    $("#eduEndDate_check").prop("checked", true);
    $("#eduEndDate_check").val(true);

    $("#institution").keyup(function () {
        if ($(this).val().length != 0) {
            $("#institution_check").prop("checked", true);
            $("#institution_check").val(true);
        }
        else {
            $("#institution_check").prop("checked", false);
            $("#institution_check").val(false);
        }
    });

    $("#qualification").keyup(function () {
        if ($(this).val().length != 0) {
            $("#qualification_check").prop("checked", true);
            $("#qualification_check").val(true);
        }
        else {
            $("#qualification_check").prop("checked", false);
            $("#qualification_check").val(false);
        }
    });

    $("#dateStart").change(function () {
        if ($(this).val() > $("#dateEnd").val()) {
            $(this).val($("#dateEnd").val());
        }
    });

    $("#dateEnd").change(function () {
        if ($(this).val() < $("#dateStart").val()) {
            $(this).val($("#dateStart").val());
        }
    });

    $("input:text").keyup(function () {
        if ($("input:checked").length == $("input:checkbox").length) {
            $("#next").show();
        }
        else {
            $("#next").hide();
        }
    });
}