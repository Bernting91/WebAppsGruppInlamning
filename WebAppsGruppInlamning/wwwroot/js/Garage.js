// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const dropdownSelected = document.querySelector('.dropdown-selected');
    const dropdownOptions = document.querySelector('.dropdown-options');
    const trashcanIcons = document.querySelectorAll('.trashcan-icon');
    const wrenchIcons = document.querySelectorAll('.wrench-icon');
    const editModal = document.querySelector('.edit-modal');
    const closeModal = editModal.querySelector('.close');

    if (dropdownSelected && dropdownOptions) {
        dropdownSelected.addEventListener('click', function () {
            dropdownOptions.style.display = dropdownOptions.style.display === 'none' ? 'block' : 'none';
        });

        dropdownOptions.addEventListener('click', function (event) {
            const option = event.target.closest('.option');
            if (option) {
                dropdownSelected.textContent = option.textContent;
                dropdownOptions.style.display = 'none';
            }
        });
    }

    trashcanIcons.forEach(icon => {
        icon.addEventListener('click', function (event) {
            event.stopPropagation();

            const optionElement = icon.closest('.option');
            const carId = optionElement.dataset.carId;

            $.ajax({
                type: "DELETE",
                url: `/api/Car/delete?id=${carId}`,
                contentType: "application/json",
                success: function (response) {
                    console.log("Car successfully deleted from database.");
                    optionElement.remove();
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.error(xhr.responseText);
                    alert("Error: Unable to delete the car.");
                }
            });
        });
    });

    wrenchIcons.forEach(icon => {
        icon.addEventListener('click', function (event) {
            event.stopPropagation();

            const optionElement = icon.closest('.option');
            const carId = optionElement.dataset.carId;
            const carType = optionElement.dataset.carType;
            const tyreType = optionElement.dataset.tyreType;
            const colour = optionElement.dataset.colour;

            document.getElementById("carId").value = carId;
            document.getElementById("carType").value = carType;
            document.getElementById("tyreType").value = tyreType;
            document.getElementById("colour").value = colour;
            editModal.style.display = "flex";
        });
    });

    closeModal.addEventListener('click', function () {
        editModal.style.display = 'none';
    });

    window.submitEdit = function () {
        const carId = document.getElementById("carId").value;
        const carType = document.getElementById("carType").value;
        const tyreType = document.getElementById("tyreType").value;
        const colour = document.getElementById("colour").value;
        const data = {
            carId: carId,
            carType: carType,
            tyreType: tyreType,
            colour: colour
        };

        $.ajax({
            type: "PUT",
            url: "/api/Car/update",
            contentType: "application/json",
            data: JSON.stringify(data),
            success: function (response) {
                console.log(response);
                alert(response);
                location.reload(); 
            },
            error: function (xhr, textStatus, errorThrown) {
                console.error(xhr.responseText);
                alert("Error updating the car.");
            }
        });
        editModal.style.display = "none";
    };
});
