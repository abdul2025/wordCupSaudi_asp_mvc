document.addEventListener('DOMContentLoaded', function () {
    var editModal = document.getElementById('editModal');

    editModal.addEventListener('show.bs.modal', function (event) {
        // Button that triggered the modal
        var button = event.relatedTarget;

        // Extract data-* attributes
        var categoryId = button.getAttribute('data-category-id');
        var categoryName = button.getAttribute('data-category-name');

        // Update modal fields
        editModal.querySelector('input[name="Id"]').value = categoryId;
        editModal.querySelector('input[name="Name"]').value = categoryName;

        // Update form action dynamically
        var form = editModal.querySelector('form');
        form.action = `/Dashboard/EditTransportationCategorie/${categoryId}`;
    });
});



document.addEventListener('DOMContentLoaded', function () {
    const deleteButtons = document.querySelectorAll('button[data-bs-target="#catTModaldelete"]');

    deleteButtons.forEach(button => {
        button.addEventListener('click', function () {
            // Extract data-* attributes
            const categoryId = this.getAttribute('data-category-id');
            const categoryName = this.getAttribute('data-category-name');

            // Update modal content with category info
            document.getElementById('catTNameToDelete').textContent = categoryName;
            document.getElementById('deleteCategoryId').value = categoryId;

            // Update form action dynamically
            const deleteForm = document.getElementById('deleteForm');
            deleteForm.action = `/Dashboard/DeleteTrans/${categoryId}`;
        });
    });
});


