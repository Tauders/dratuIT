const inputList = document.getElementById('input_results-list');
const sortList = document.getElementById('sort_results-list');

document.querySelector('#input-word--form').addEventListener('submit', function (e) {
    e.preventDefault();

    const sortCollectionItems = document.querySelectorAll('.sort_results-item');

    if(sortCollectionItems.length !== 0){
        inputList.innerHTML = '';
        sortList.innerHTML = '';
    }

    const passValue = document.querySelector('.form_data').value;
    const inputItem = document.createElement('li');
    const inputItemClassName = 'input_results-item';

    inputItem.className = inputItemClassName;
    inputItem.innerHTML = passValue;
    inputList.append(inputItem);
    document.querySelector('.form_data').value = '';
});

document.querySelector('#sort-word--form').addEventListener('submit', function (e) {
    e.preventDefault();

    const radioDescending = document.getElementById('sort_descending');
    const radioAscending = document.getElementById('sort_ascending');
    const sortCollectionItems = document.querySelectorAll('.sort_results-item');
    const inputCollectionItems = document.querySelectorAll('.input_results-item');

    if(sortCollectionItems.length !== 0){
        sortList.innerHTML = '';
    }

    let inputArrayItems = Array.from(inputCollectionItems).map(t=>t.innerText);

    if(radioAscending.checked) {
        inputArrayItems.sort();
    } else if (radioDescending.checked) {
        inputArrayItems.sort().reverse();
    } 
    
    for (let result of inputArrayItems) {
        const sortItem  = document.createElement('li');
        const sortItemClassName = 'sort_results-item';
        
        sortItem.className = sortItemClassName;
        sortItem.innerHTML = result;
        sortList.append(sortItem);
    }
});