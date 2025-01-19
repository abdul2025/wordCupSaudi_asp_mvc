document.addEventListener('DOMContentLoaded', function () {
    var editModal = document.getElementById('editModal');
    var deleteModal = document.getElementById('deleteModal');

    if (editModal) {
        editModal.addEventListener('show.bs.modal', function (event) {
            console.log('Edit Action');
            
            // Button that triggered the modal
            var button = event.relatedTarget;
        
            // Extract all data-* attributes dynamically
            Array.from(button.attributes)
                .filter(attr => attr.name.startsWith('data-')) // Select only data-* attributes
                .forEach(attr => {
                    const attributeName = attr.name.replace('data-', ''); // Get the part after "data-"
                    const input = editModal.querySelector(`input[name="${attributeName}"]`); // Find matching input
                    console.log(`Value: ${input}, attributeName: ${attributeName}-`)
                    
                    if (input) {
                        console.log(`Value: ${input.value}, attributeName: ${attributeName}-${attr.value}`)
                        input.value = attr.value; // Set the input value
                    };
                });
        
            // Update form action dynamically
            var url = button.getAttribute('data-url');
            var id = button.getAttribute('data-id'); // Keep specific cases if needed
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
