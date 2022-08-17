document.querySelector(".form").addEventListener('submit', function(e) {
    let passValue = document.querySelector('.form_data').value;
    console.log("Тюлень ввёл : ", passValue);
    document.querySelector('.form_data').value = '';
});