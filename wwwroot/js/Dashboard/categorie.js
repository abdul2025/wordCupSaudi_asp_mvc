document.addEventListener('DOMContentLoaded', function () {
    var editModal = document.getElementById('editModal');

    editModal.addEventListener('show.bs.modal', function (event) {
        // Button that triggered the modal
        var button = event.relatedTarget;

        // Extract info from data-* attributes
        var categoryId = button.getAttribute('data-category-id');
        var categoryName = button.getAttribute('data-category-name');
        var categoryDescription = button.getAttribute('data-category-description');
        var categoryIcon = button.getAttribute('data-category-icon');
        var categoryImage = button.getAttribute('data-category-image');

        // Update the modal's fields
        editModal.querySelector('input[name="Name"]').value = categoryName;
        editModal.querySelector('textarea[name="Description"]').value = categoryDescription;
        editModal.querySelector('input[name="Icon"]').value = categoryIcon;

        // Handle the image preview if necessary
        var imageField = editModal.querySelector('input[name="Image"]');
        if (imageField) {
            var imagePreview = editModal.querySelector('#imagePreview');
            if (imagePreview) {
                imagePreview.src = `/images/${categoryImage}`;
            }
        }

        // If you need to submit the form with the ID
        var form = editModal.querySelector('form');
        form.action = `/Dashboard/EditCategories/${categoryId}`;
    });
});


// JavaScript to handle dynamic population of modal data and form action
const deleteButtons = document.querySelectorAll('button[data-bs-toggle="modal"]');
deleteButtons.forEach(button => {
    button.addEventListener('click', function() {
        const categoryId = this.getAttribute('data-bs-action').split('/').pop(); // Extract ID from the URL
        const categoryName = this.getAttribute('data-category-name');
        
        // Update the modal with category name and ID
        document.getElementById('categoryNameToDelete').textContent = categoryName;
        document.getElementById('deleteCategoryId').value = categoryId;

        // Set the form action dynamically to point to the correct URL
        const deleteForm = document.getElementById('deleteForm');
        deleteForm.action = '/Dashboard/DeleteCategories/' + categoryId;
    });
});
