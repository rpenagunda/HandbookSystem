using System.Collections.Generic;
using System.Web.Mvc;

namespace HandbookSystem.Helper
{
    public static class Extensions
    {
        // Helper method to generate the modal dialog components 
        public static MvcHtmlString GenerateModalDialog(this HtmlHelper helper, string modalId, string modalBody, string modalHeader = null, string modalFooter = null, string modalButton = null)
        {
            return MvcHtmlString.Create("" + "<div class='modal fade' id='" + modalId + "' tabindex='-1' role='dialog' aria-hidden='true'>" +
                                            "<div class='modal-dialog'><div class='modal-content'>" +
                                                (string.IsNullOrEmpty(modalHeader) ? "" :
                                                "<div class='modal-header'>" +
                                                    modalHeader +
                                                "</div>") +
                                                "<div class='modal-body'>" +
                                                    modalBody +
                                                "</div>" +
                                                "<div class='modal-footer'>" + (string.IsNullOrEmpty(modalFooter) ?
                                                "<a href='#' class='btn btn-primary " + modalButton + "' data-dismiss='modal'>OK</a>" : modalFooter) +
                                                "</div>" +
                                            "</div></div>" +
                                        "</div>");
        }

        // Return values of publish dropdown list
        public static List<SelectListItem> PublishList()
        {
            // SelectListItem
            var items = new List<SelectListItem>
            {
                new SelectListItem {Text = "Yes", Value = "True"},
                new SelectListItem {Text = "No", Value = "False"}
            };

            return items;
        }
    }
}