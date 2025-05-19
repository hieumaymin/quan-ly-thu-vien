// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    // Enable jQuery validation
    $.validator.setDefaults({
        submitHandler: function (form) {
            form.submit();
        }
    });

    // Handle loan form submission
    $('form[asp-action="Create"]').on('submit', function (e) {
        if ($(this).valid()) {
            return true;
        }
        e.preventDefault();
        return false;
    });
});
