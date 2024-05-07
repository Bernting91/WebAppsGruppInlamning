// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const carSelect = document.getElementById('carSelect');
    const wheelsSelect = document.getElementById('wheelsSelect');
    const colorSelect = document.getElementById('colorSelect');
    const carImage = document.querySelector('.main-content img');
    const buildCarBtn = document.querySelector('.build-car-btn');

    function updateCarImage() {
        const carType = carSelect.value.toLowerCase();
        const wheelsType = wheelsSelect.value.toLowerCase();
        const color = colorSelect.value.toLowerCase();
        const imagePath = `/lib/images/${carType}_${color}_${wheelsType}.webp`;
        carImage.src = imagePath;
    }
    carSelect.addEventListener('change', updateCarImage)
    wheelsSelect.addEventListener('change', updateCarImage)
    colorSelect.addEventListener('change', updateCarImage)
});





