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

document.getElementById("buildCar").addEventListener("click", function () {
    var carSelectSelection = document.getElementById("carSelect").value;
    var wheelsSelectSelection = document.getElementById("wheelsSelect").value;
    var colorSelectSelection = document.getElementById("colorSelect").value;

    var data = {
        CarType: carSelectSelection,
        Colour: colorSelectSelection,
        TyreType: wheelsSelectSelection
    };

    console.log(carSelectSelection);
    console.log(colorSelectSelection);
    console.log(wheelsSelectSelection)

    $.ajax({
        type: "POST",
        url: "/api/Car/add",
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (response) {
            console.log(response);
            alert(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            console.error(xhr.responseText);
        }
    });
});






