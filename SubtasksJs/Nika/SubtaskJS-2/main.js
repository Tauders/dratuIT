const formInputWordID = 'input-word--form';
const formSortingWordID = 'sort-word--form';
const sortedListID = 'sort_results-list';
const outputListID = 'input_results-list';
const enteredValueID = 'form--input-data';
const itemSortedListClassName = '.sort_results-item';
const outputListItemClassName = '.input_results-item';
const radioDescendingOptionID = 'sort_descending';
const radioAscendingOptionID = 'sort_ascending';

document
  .getElementById(formInputWordID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    const sortedList = document.getElementById(sortedListID);
    const outputList = document.getElementById(outputListID);
    const collectionSortedListItems = document.querySelectorAll(
      itemSortedListClassName
    );
    if (collectionSortedListItems.length !== 0) {
      outputList.innerHTML = '';
      sortedList.innerHTML = '';
    }

    const enteredValue = document.getElementById(enteredValueID).value;
    const outputListItem = document.createElement('li');

    outputListItem.className = outputListItemClassName;
    outputListItem.innerHTML = enteredValue;
    outputList.append(outputListItem);
    document.getElementById(enteredValueID).value = '';
  });

document
  .getElementById(formSortingWordID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    const sortedList = document.getElementById(sortedListID);
    const collectionSortedListItems = document.querySelectorAll(
      itemSortedListClassName
    );
    const collectionOutputListItems = document.querySelectorAll(
      outputListItemClassName
    );

    const radioDescendingOption = document.getElementById(
      radioDescendingOptionID
    );
    const radioAscendingOption = document.getElementById(
      radioAscendingOptionID
    );

    if (collectionSortedListItems.length !== 0) {
      sortedList.innerHTML = '';
    }

    const itemsArrayOutputListItems = Array.from(collectionOutputListItems).map(
      t => t.innerText
    );

    if (radioAscendingOption.checked) {
      itemsArrayOutputListItems.sort();
    } else if (radioDescendingOption.checked) {
      itemsArrayOutputListItems.sort().reverse();
    }

    for (const result of itemsArrayOutputListItems) {
      const itemSortedList = document.createElement('li');
      itemSortedList.className = itemSortedListClassName;
      itemSortedList.innerHTML = result;
      sortedList.append(itemSortedList);
    }
  });
