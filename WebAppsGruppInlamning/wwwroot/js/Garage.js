// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    // Växla mellan att visa eller dölja alternativmenyn
    const dropdownSelected = document.querySelector('.dropdown-selected');
    const dropdownOptions = document.querySelector('.dropdown-options');

    if (dropdownSelected && dropdownOptions) {
        dropdownSelected.addEventListener('click', function () {
            dropdownOptions.style.display = dropdownOptions.style.display === 'block' ? 'none' : 'block';
        });
    }

    // Hämta bildata från backend
    async function fetchGarageData() {
        try {
            // Backend-anvisning:
            // Ersätt denna URL med den faktiska slutpunkten för att hämta garagedata.
            const response = await fetch('/api/garage');
            const cars = await response.json();

            // Fyll alternativen i dropdown-menyn med de hämtade bilarna
            cars.forEach(car => {
                const optionDiv = document.createElement('div');
                optionDiv.className = 'option';
                optionDiv.innerHTML = `${car.carType} - ${car.carColour} <span class="trashcan">&#x1F5D1;</span>`;

                // Lägg till klickhändelse för att välja denna bil
                optionDiv.addEventListener('click', function () {
                    dropdownSelected.textContent = `${car.carType} - ${car.carColour}`;
                    dropdownOptions.style.display = 'none';
                });

                // Lägg till klickhändelse för att ta bort bilen (papperskorgsikon)
                optionDiv.querySelector('.trashcan').addEventListener('click', async function (event) {
                    event.stopPropagation(); // Förhindra att alternativet väljs
                    const parentElement = this.parentElement;

                    // Backend-anvisning:
                    // Ersätt denna URL med den faktiska slutpunkten för att ta bort en bil.
                    const carId = car.carId; // Förutsatt att bilens ID finns tillgängligt
                    const deleteResponse = await fetch(`/api/garage/${carId}`, {
                        method: 'DELETE'
                    });

                    // Ta bort från DOM om raderingen lyckades
                    if (deleteResponse.ok) {
                        parentElement.remove();
                    } else {
                        console.error('Misslyckades med att ta bort bilen.');
                    }
                });

                dropdownOptions.appendChild(optionDiv);
            });
        } catch (error) {
            console.error('Fel vid hämtning av garagedata:', error);
        }
    }

    // Anropa funktionen för att hämta garagedata
    fetchGarageData();
});

