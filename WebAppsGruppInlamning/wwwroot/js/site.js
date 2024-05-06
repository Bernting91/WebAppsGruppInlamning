// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// JavaScript functions for showing and hiding the hover image

function openModal(pageName) {
            var modal = document.getElementById('myModal');
            modal.style.display = "block";
            modal.dataset.pageName = pageName;
        }
        
        function navigateTo() {
            var modal = document.getElementById('myModal');
            window.location.href = '/' + modal.dataset.pageName;
        }
        
        window.onclick = function (event) {
            var modal = document.getElementById('myModal');
            if (event.target == modal) {
                modal.style.display = "none";
            }
}
function showTooltip(mechanicName) {
    var additionalModal = document.getElementById('additionalModal');
    var additionalModalImage = document.getElementById('additionalModal-image');
    var additionalModalText = document.getElementById('additionalModal-text');

    switch (mechanicName) {
        case 'Minh':
            additionalModalImage.src = '/lib/Images/testCar.webp'; 
            additionalModalText.innerText = 'Additional text about Minh';
            break;
        case 'Robert':
            additionalModalImage.src = '/lib/Images/Robertmechanic.jpg'; 
            additionalModalText.innerText = 'Dont choose me, I know nothing.';
            break;
        case 'Tim':
            additionalModalImage.src = '/lib/Images/TimMechanic.webp'; 
            additionalModalText.innerText = 'I know DnD';
            break;
        case 'Emil':
            additionalModalImage.src = '/lib/Images/testCar.webp'; 
            additionalModalText.innerText = 'Additional text about Emil';
            break;

        default:
            additionalModalImage.src = '';
            additionalModalText.innerText = '';
            break;
    }

    additionalModal.style.display = 'block';
}

function hideTooltip() {
    var additionalModal = document.getElementById('additionalModal');
    additionalModal.style.display = 'none';
}
window.addEventListener('click', function (event) {
    var modal = document.getElementById('myModal');
    var additionalModal = document.getElementById('additionalModal');
    var clickedElement = event.target;

    if (clickedElement.classList.contains('image-wrapper') || clickedElement.tagName === 'IMG') {
        return; // Do nothing if the clicked element is one of the images
    }

    if (!modal.contains(clickedElement) && clickedElement.id !== 'myModal' && clickedElement !== additionalModal && clickedElement !== modal) {
        modal.style.display = 'none';
        additionalModal.style.display = 'none';
    }
});
