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
const checkboxElementClassName = '.checkbox';
const controlRadioOptionID = '.control--radio-input';

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
    clearErrorboxSheet();

    const enteredValues = document.getElementById(enteredValuesID).value;
    const arrayEnteredValues = enteredValues.split(' ');

    function CheckEnteredValues() {
      for (const enteredValue of arrayEnteredValues) {
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

        if (enteredValue === '') {
          continue;
        }
        if (isNaN(enteredValue)) {
          clearCheckboxSheet();
          createError('Вы ввели нечисловое значение! Попробуйте снова.');
          break;
        }
        if (enteredValue.length >= 20) {
          createError(
            'Вы ввели слишком длинное число! Максимально разрешенная  длина числа - 20 знаков.'
          );
          break;
        }

        clearErrorboxSheet();
        createCheckboxItem();
      }
    }

    if (arrayEnteredValues.length >= 20) {
      createError(
        'Вы ввели недопустимое количество чисел! Введите не более 20 чисел.'
      );
    } else {
      CheckEnteredValues();
    }

    document.getElementById(enteredValuesID).value = '';
  });

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

function defineIndex() {
  const controlRadioOptionCollections =
    document.querySelectorAll(controlRadioOptionID);
  for (let i = 0; i < controlRadioOptionCollections.length; i++) {
    if (controlRadioOptionCollections[i].checked) {
      return i;
    }
  }
}

function performСalculationOperation() {
  const arrayEnteredValuesChecked = [];
  const checkboxElements = document.querySelectorAll(checkboxElementClassName);

  for (const checkboxElement of checkboxElements) {
    if (checkboxElement.checked) {
      arrayEnteredValuesChecked.push(+checkboxElement.id);
    }
  }

  if (arrayEnteredValuesChecked.length === 0) {
    clearResultsBlock();
    return createError('Для выполнения операций выберите числа!');
  }

  function addition() {
    countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
      (addition, current) => addition + current
    );
  }
  function subtraction() {
    countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
      (subtraction, current) => subtraction - current
    );
  }
  function multiplication() {
    countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
      (multiplication, current) => multiplication * current
    );
  }
  function division() {
    if (arrayEnteredValuesChecked.includes(0)) {
      createError('Делить на ноль нельзя!');
      clearResultsBlock();
    } else {
      countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
        (division, current) => division / current
      );
    }
  }

  clearErrorboxSheet();

  const controlRadioOptionIndex = defineIndex();

  switch (controlRadioOptionIndex) {
    case 0:
      addition();
      break;
    case 1:
      subtraction();
      break;
    case 2:
      multiplication();
      break;
    case 3:
      division();
      break;
    default:
      createError('Выберите операцию!');
      clearResultsBlock();
  }
}

document
  .getElementById(formCountingNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    performСalculationOperation();
    resetRadioButtons();
  });
