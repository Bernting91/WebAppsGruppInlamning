// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const dropdownSelected = document.querySelector('.dropdown-selected');
    const dropdownOptions = document.querySelector('.dropdown-options');

    if (dropdownSelected && dropdownOptions) {
        dropdownSelected.addEventListener('click', function () {
            dropdownOptions.style.display = dropdownOptions.style.display === 'block' ? 'none' : 'block';
        });
    }
    document.querySelectorAll('.option').forEach(function (option) {
        option.addEventListener('click', function () {
            dropdownSelected.textContent = this.textContent;
            dropdownOptions.style.display = 'none';
        });
    });

    // tar bort iconen soptunna
    document.querySelectorAll('.trashcan').forEach(function (icon) {
        icon.addEventListener('click', function (event) {
            event.stopPropagation();
            this.parentElement.remove();
        });
    });
});


