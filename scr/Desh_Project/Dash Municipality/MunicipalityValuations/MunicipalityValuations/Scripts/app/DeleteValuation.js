$(document).ready(function() {

    var valuationId = $(this).attr("data-valuationId");
    var municipalityId = $(this).attr('data-municipalityId');
    
    $('#deleteValuation').on("click", function (e) {

        var flag = swal({
            title: "Are you sure you want to delete this valuation ?",
            text: "You will not be able to recover this valuation!",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-danger",
            confirmButtonText: "Yes, delete it!",
            cancelButtonText: "No, cancel plx!",
            closeOnConfirm: false,
            closeOnCancel: false
        },
            function (isConfirm) {
             if (isConfirm) {
                
                 $.ajax({

                url: '/home/DeleteMunicipalityValuations',

                type: 'POST',

                data: { id: valuationId },

                dataType: 'json',

                success: function(result) {

                    swal("Deleted!", "Your imaginary file has been deleted.", "success");
       
                    window.location.href = '/Home/ViewMunicipalityValuations?id='+municipalityId;
                },
                error: function () { swal("Error!", "Fail to delete.", "Error"); }

            });

             }
             else {
            swal("Cancelled", "Your imaginary file is safe :)", "error");
    }
});
        
    });
    //$('a.edit').on('click', function() {
    //    var myModal = $('#myModal');

    //    // now get the values from the table
    //    var firstName = $(this).closest('tr').find('td.firstName').html();
    //    var lastName = $(this).closest('tr').find('td.lastName').html();
    //    ....

    //    // and set them in the modal:
    //    $('.firstName', myModal).val(firstName);
    //    $('.lastNameName', myModal).val(lastName);
    //    ....

    //    // and finally show the modal
    //    myModal.modal({ show: true });

    //    return false;
    //});

    $('#editValuation').on("click", function(e) {
        var modal =$('#ValuationModal');
        var period = $(this).closest('input').find('#PeriodFrom').html();
        $(modal).load(this.href, function() {

           
        });
    });
});