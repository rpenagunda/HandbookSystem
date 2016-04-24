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
    var validator = $("#frm_edituser").validate({ /* settings */ });

    // Submit the form
    if ($("#frm_edituser").valid()) {
        showModal("#modal_edituser_overlay");

        // Set a timeout delay before web submit the form
        setTimeout(function () {
            $("#frm_edituser").submit();
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