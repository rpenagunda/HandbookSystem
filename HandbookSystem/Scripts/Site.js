/*
 ## DOCUMENT READY ##
 */
$(document).ready(function () {
    // WYSIWYG EDITOR (TINYMCE)
    tinymce.init({
        selector: 'textarea',
        height: 500,
        plugins: [
          'advlist autolink lists link image charmap preview anchor',
          'searchreplace code',
          'insertdatetime table contextmenu paste code',
          'autoresize'
        ],
        autoresize_bottom_margin: 10,
        toolbar: 'undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image'
    });

    /** SETTING ATTRIBUTE **/
    // Turn off autocomplete
    $(".val-autocomplete-off").attr("autocomplete", "off");

    // Auto-size text-area
    $('.auto-size-textarea').autosize({ append: "\n" });
});