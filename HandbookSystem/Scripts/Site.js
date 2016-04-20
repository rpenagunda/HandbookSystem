/*
 ## DOCUMENT READY ##
 */
$(document).ready(function () {
    /** SETTING ATTRIBUTE **/
    // Turn off autocomplete
    $(".val-autocomplete-off").attr("autocomplete", "off");

    // Auto-size text-area
    $('.auto-size-textarea').autosize({ append: "\n" });
});