$(document).ready(function () {
    debugger;
    $('.dateTimeInput').datepicker();

    $('#dateTimeFrom').datepicker({
        format: " yyyy", // Notice the Extra space at the beginning
        viewMode: "years",
        minViewMode: "years"
    });

    $("#valuationsForm").on("submit", function () {
        var periodFrom = $('#PeriodFrom').val();
        var periodTo = $('#PeriodTo').val();
        $('#Period').val(periodFrom - periodTo);
    });
});