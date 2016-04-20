/*
 ## FUNCTIONS ##
 */
// Function to show modal dialog
function showModal(selector) {
    $(selector).modal({
        backdrop: "static",
        show: true
    });
}

function submitHandbookForm() {
    var validator = $("#frm_handbook").validate({ /* settings */ });

    // Submit the form
    if ($("#frm_handbook").valid()) {
        showModal("#modal_handbook_overlay");

        // Set a timeout delay before web submit the form
        setTimeout(function () {
            $("#frm_handbook").submit();
        }, 1000);
    } else {
        validator.focusInvalid();
    }
}

/*
 ## DOCUMENT READY ##
 */
$(document).ready(function () {

});