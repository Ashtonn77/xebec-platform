function select2() {
    var items;

    $(".select2Multi").select2({
        placeholder: "--Select Job Type--"
    });

    $("#select2DDB").on("select2:select select2:unselect", function () {
        items = $(this).val();
        DotNet.invokeMethodAsync('XebecPortal.Client', 'UpdateModel', items.toString());
    })
}