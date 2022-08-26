const mainContainerID = 'container';
const formInputNumberID = 'input-number--form';
const formCountingNumberID = 'counting-number--form';
const enteredValuesID = 'form--input-data';
const checkboxListID = 'checkboxList';
const checkboxList = document.getElementById(checkboxListID);
const countingResultsID = 'counting-results';
const countingResults = document.getElementById(countingResultsID);
const radioAdditionOptionID = 'addition';
const radioSubtractionOptionID = 'subtraction';
const radioMultiplicationOptionID = 'multiplication';
const radioDivisionOptionID = 'division';
const errorBoxClassName = '.error--box';
const errorBox = document.querySelector(errorBoxClassName);
const checkboxItemClassName = 'checkbox';
const labelItemClassName = 'label';

function clearCheckboxSheet() {
  if (checkboxList.firstChild) {
    checkboxList.innerHTML = '';
  }
}
function clearErrorboxSheet() {
  if (errorBox.firstChild) {
    errorBox.innerHTML = '';
  }
}

function clearResultsBlock() {
  countingResults.innerHTML = '';
}

function createError(text) {
  if (!errorBox.firstChild) {
    const error = document.createElement('span');
    error.className = 'error';
    error.innerHTML = text;
    errorBox.append(error);
  }
}

document
  .getElementById(formInputNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    clearResultsBlock();
    clearCheckboxSheet();

    const enteredValues = document.getElementById(enteredValuesID).value;
    const arrayEnteredValues = enteredValues.split(' ');

    if (arrayEnteredValues.length >= 20) {
      createError(
        'Вы ввели недопустимое количество чисел! Введите не более 20 чисел.'
      );
    } else {
      function CheckEnteredValues() {
        for (const enteredValue of arrayEnteredValues) {
          if (enteredValue === '') {
            continue;
          } else if (isNaN(enteredValue)) {
            createError('Вы ввели нечисловое значение! Попробуйте снова.');
            break;
          } else if (enteredValue.length >= 20) {
            createError(
              'Вы ввели слишком длинное число! Максимально разрешенная  длина числа - 20 знаков.'
            );
            break;
          } else {
            clearErrorboxSheet();
            function createCheckboxItem() {
              const labelItem = document.createElement('label');
              const checkboxItem = document.createElement('input');

              checkboxItem.setAttribute('type', 'checkbox');
              checkboxItem.className = checkboxItemClassName;
              labelItem.className = labelItemClassName;
              checkboxItem.id = enteredValue;
              labelItem.setAttribute('for', enteredValue);
              checkboxList.append(labelItem);
              labelItem.append(checkboxItem);
              labelItem.append(enteredValue);
            }
            createCheckboxItem();
          }
        }
      }
      CheckEnteredValues();
    }

    document.getElementById(enteredValuesID).value = '';
  });

document
  .getElementById(formCountingNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();

    const checkboxElementsClassName = '#checkboxList label input';
    const checkboxElements = document.querySelectorAll(
      checkboxElementsClassName
    );
    const arrayEnteredValuesChecked = [];

    for (const checkboxElement of checkboxElements) {
      if (checkboxElement.checked) {
        arrayEnteredValuesChecked.push(+checkboxElement.id);
      }
    }

    const radioAdditionOption = document.getElementById(radioAdditionOptionID);
    const radioSubtractionOption = document.getElementById(
      radioSubtractionOptionID
    );
    const radioMultiplicationOption = document.getElementById(
      radioMultiplicationOptionID
    );
    const radioDivisionOption = document.getElementById(radioDivisionOptionID);

    function resetRadioButtons() {
      radioAdditionOption.checked = false;
      radioSubtractionOption.checked = false;
      radioMultiplicationOption.checked = false;
      radioDivisionOption.checked = false;
    }

    function performСalculationOperation(error) {
      if (radioAdditionOption.checked) {
        return arrayEnteredValuesChecked.reduce(function (addition, current) {
          return addition + current;
        });
      } else if (radioSubtractionOption.checked) {
        return arrayEnteredValuesChecked.reduce(function (
          subtraction,
          current
        ) {
          return subtraction - current;
        });
      } else if (radioMultiplicationOption.checked) {
        return arrayEnteredValuesChecked.reduce(function (
          multiplication,
          current
        ) {
          return multiplication * current;
        });
      } else if (radioDivisionOption.checked) {
        if (arrayEnteredValuesChecked.includes(0)) {
          createError('Делить на ноль нельзя!');
          return (error = '');
        }
        return arrayEnteredValuesChecked.reduce(function (division, current) {
          return division / current;
        });
      }
    }

    countingResults.innerHTML = performСalculationOperation();
    resetRadioButtons();
  });
