document.querySelector('.forma_btn').addEventListener('click', dataBtn);

function start(e) {
    e = e || window.event;
    if (e.keyCode === 13) { document.getElementById('submitData').click() }
    return false;
}

function dataBtn() {
    let nerpa = document.querySelector('.forma_data').value;
    console.log("Тюлень ввёл : ", nerpa);
    document.getElementById('forData').value = '';
}