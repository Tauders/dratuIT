const mainContainerID = 'container';
const formInputNumberID = 'input-number--form';
const formCountingNumberID = 'counting-number--form';
const enteredValuesID = 'form--input-data';
const checkboxListID = 'checkboxList';
const checkboxList = document.getElementById(checkboxListID);
const countingResultsID = 'counting-results';
const countingResults = document.getElementById(countingResultsID);

document
  .getElementById(formInputNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    countingResults.innerHTML = '';
    if (checkboxList.firstChild) {
      checkboxList.innerHTML = '';
    }

    const errorBoxClassName = '.error--box';
    const errorBox = document.querySelector(errorBoxClassName);

    const enteredValues = document.getElementById(enteredValuesID).value;
    const arrayEnteredValues = enteredValues.split(' ');

    if (arrayEnteredValues.length >= 20) {
      const error = document.createElement('span');
      error.className = 'error';
      error.innerHTML =
        'Вы ввели недопустимое количество чисел! Введите не более 20 чисел.';
      errorBox.append(error);
    } else {
      for (let enteredValue of arrayEnteredValues) {
        if (isNaN(enteredValue)) {
          if (!errorBox.firstChild) {
            const error = document.createElement('span');
            error.className = 'error';
            error.innerHTML = 'Вы ввели нечисловое значение! Попробуйте снова.';
            errorBox.append(error);
            checkboxList.innerHTML = '';
            break;
          }
        } else if (enteredValue.length >= 20) {
          const error = document.createElement('span');
          error.className = 'error';
          error.innerHTML =
            'Вы ввели слишком длинное число! Максимально разрешенная  длина числа - 20 знаков.';
          errorBox.append(error);
          checkboxList.innerHTML = '';
          break;
        } else if (enteredValue === '') {
          continue;
        } else {
          if (errorBox.firstChild) {
            errorBox.innerHTML = '';
          }

          const labelItem = document.createElement('label');
          const checkboxItem = document.createElement('input');

          checkboxItem.setAttribute('type', 'checkbox');
          checkboxItem.className = 'checkbox';
          checkboxItem.id = enteredValue;
          labelItem.setAttribute('for', enteredValue);
          checkboxList.append(labelItem);
          labelItem.append(checkboxItem);
          labelItem.append(enteredValue);
        }
      }
    }

    document.getElementById(enteredValuesID).value = '';
  });

document
  .getElementById(formCountingNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();

    const radioAdditionOption = document.getElementById('addition');
    const radioSubtractionOption = document.getElementById('subtraction');
    const radioMultiplicationOption = document.getElementById('multiplication');
    const radioDivisionOption = document.getElementById('division');
    const checkboxElementsClassName = '#checkboxList label input';
    const checkboxElements = document.querySelectorAll(
      checkboxElementsClassName
    );
    const arrayEnteredValuesChecked = [];
    for (let i = 0; i < checkboxElements.length; i++) {
      if (checkboxElements[i].checked) {
        arrayEnteredValuesChecked.push(+checkboxElements[i].id);
      }
    }

    if (radioAdditionOption.checked) {
      countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
        (addition, current) => addition + current
      );

      radioAdditionOption.checked = false;
    } else if (radioSubtractionOption.checked) {
      countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
        (subtraction, current) => subtraction - current
      );
      radioSubtractionOption.checked = false;
    } else if (radioMultiplicationOption.checked) {
      countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
        (multiplication, current) => multiplication * current
      );
      radioMultiplicationOption.checked = false;
    } else if (radioDivisionOption.checked) {
      countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
        (division, current) => division / current
      );
      radioDivisionOption.checked = false;
    }
  });
