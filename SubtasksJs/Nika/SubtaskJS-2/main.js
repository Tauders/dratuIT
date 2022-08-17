let inputList = document.getElementById('input_results-list');
let sortList = document.getElementById('sort_results-list');

document.querySelector(".form1").addEventListener('submit', function (e) {
    e.preventDefault();
    if(document.querySelectorAll('.sort_results-item').length != 0){
        inputList.innerHTML = '';
        sortList.innerHTML = '';
    }

    let passValue = document.querySelector('.form_data').value;
    let inputItem = document.createElement('li');
    inputItem.className = 'input_results-item';
    inputItem.innerHTML = passValue;
    inputList.append(inputItem);
    document.querySelector('.form_data').value = '';
});

let radioDescending = document.getElementById('sort_descending');
let radioAscending = document.getElementById('sort_ascending');

document.querySelector(".form2").addEventListener('submit', function (e) {
    e.preventDefault();
    if(document.querySelectorAll('.sort_results-item').length != 0){
        sortList.innerHTML = '';
    }
    let inputItem = document.querySelectorAll('.input_results-item');
    let resultsArray = Array.from(inputItem);

    resultsArray = resultsArray.map(t => { return t.innerText })

    if(radioAscending.checked) {
        resultsArray.sort();
    } if (radioDescending.checked) {
        resultsArray.sort().reverse();
    } 
    
    resultsArray.forEach(function(item) {
        let sortItem  = document.createElement('li');
        sortItem.innerHTML = item;
        sortItem.className = 'sort_results-item';
        sortList.append(sortItem);
      });
});