function workHistoryForm() {

    $("#company_name_check").click(function () { return false; });
    $("#job_title_check").click(function () { return false; });
    $("#start_date_check").click(function () { return false; });
    $("#end_date_check").click(function () { return false; });
    $("#job_description_check").click(function () { return false; });

    $("#start_date_check").prop("checked", true);
    $("#start_date_check").val(true);
    $("#end_date_check").prop("checked", true);
    $("#end_date_check").val(true);

    $("#companyname").keyup(function () {
        if ($(this).val().length != 0) {
            $("#company_name_check").prop("checked", true);
            $("#company_name_check").val(true);
        }
        else {
            $("#company_name_check").prop("checked", false);
            $("#company_name_check").val(false);
        }
    });

    $("#jobtitle").keyup(function () {
        if ($(this).val().length != 0) {
            $("#job_title_check").prop("checked", true);
            $("#job_title_check").val(true);
        }
        else {
            $("#job_title_check").prop("checked", false);
            $("#job_title_check").val(false);
        }
    });

    $("#textarea").keyup(function () {
        if ($(this).val().length != 0) {
            $("#job_description_check").prop("checked", true);
            $("#job_description_check").val(true);
        }
        else {
            $("#job_description_check").prop("checked", false);
            $("#job_description_check").val(false);
        }

        if ($("input:checked").length == $("input:checkbox").length) {
            $("#next").show();
        }
        else {
            $("#next").hide();
        }
    });

    $("#startdate").on("change", function () {
        if ($(this).val() > $("#enddate").val()) {
            $(this).val($("#enddate").val());
        }
    });

    $("#enddate").on("change", function () {
        if ($(this).val() < $("#startdate").val()) {
            $(this).val($("#startdate").val());
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