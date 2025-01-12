document.addEventListener('DOMContentLoaded', function () {
    var editModal = document.getElementById('editModal');
    var deleteModal = document.getElementById('deleteModal');

    if (editModal) {
        editModal.addEventListener('show.bs.modal', function (event) {
            console.log('Edit Action');
            // Button that triggered the modal
            var button = event.relatedTarget;

            // Extract data-* attributes
            var id = button.getAttribute('data-id');
            var name = button.getAttribute('data-name');
            var url = button.getAttribute('data-url');

            // Update modal fields
            editModal.querySelector('input[name="Id"]').value = id;
            editModal.querySelector('input[name="Name"]').value = name;

            // Update form action dynamically
            var form = editModal.querySelector('form');
            form.action = `${url}${id}`;
        });
    }

    if (deleteModal) {
        deleteModal.addEventListener('show.bs.modal', function (event) {
            console.log('Del Action');
            var button = event.relatedTarget;

            // Extract data-* attributes
            var id = button.getAttribute('data-id');
            var name = button.getAttribute('data-name');
            var url = button.getAttribute('data-url');

            // Update modal content with category info
            document.getElementById('data-name').textContent = name;
            document.getElementById('deleteId').value = id;

            // Update form action dynamically
            var form = deleteModal.querySelector('form');
            form.action = `${url}${id}`;
        });
    }
});
