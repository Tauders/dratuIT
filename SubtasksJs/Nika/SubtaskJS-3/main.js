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

    function createCheckboxItem(enteredValue) {
      const labelItem = document.createElement('label');
      const checkboxItem = document.createElement('input');

      checkboxItem.setAttribute('type', 'checkbox');
      checkboxItem.className = checkboxItemClassName;
      labelItem.className = labelItemClassName;
      checkboxItem.value = enteredValue;
      checkboxList.append(labelItem);
      labelItem.append(checkboxItem);
      labelItem.append(enteredValue);
    }
    function checkEnteredValue(enteredValue) {
      if (enteredValue === '') {
        return;
      }
      if (isNaN(enteredValue)) {
        clearCheckboxSheet();
        createError('Вы ввели нечисловое значение! Попробуйте снова.');
        return;
      }
      if (enteredValue.length >= 20) {
        clearCheckboxSheet();
        createError(
          'Вы ввели слишком длинное число! Максимально разрешенная  длина числа - 20 знаков.'
        );
        return;
      }
      return true;
    }
    function checkEnteredValues() {
      if (arrayEnteredValues.length >= 20) {
        createError(
          'Вы ввели недопустимое количество чисел! Введите не более 20 чисел.'
        );
        return;
      }
      for (const enteredValue of arrayEnteredValues) {
        if (checkEnteredValue(enteredValue)) {
          clearErrorboxSheet();
          createCheckboxItem(enteredValue);
        } else return;
      }
    }
    checkEnteredValues();

    document.getElementById(enteredValuesID).value = '';
  });

function resetRadioButtons() {
  const radioAdditionOption = document.getElementById(radioAdditionOptionID);
  const radioSubtractionOption = document.getElementById(
    radioSubtractionOptionID
  );
  const radioMultiplicationOption = document.getElementById(
    radioMultiplicationOptionID
  );
  const radioDivisionOption = document.getElementById(radioDivisionOptionID);
  radioAdditionOption.checked = false;
  radioSubtractionOption.checked = false;
  radioMultiplicationOption.checked = false;
  radioDivisionOption.checked = false;
}

function getNeededAction() {
  const controlRadioOptionCollections =
    document.querySelectorAll(controlRadioOptionID);
  let i = 0;
  for (i; i < controlRadioOptionCollections.length; i++) {
    if (controlRadioOptionCollections[i].checked) {
      break;
    }
  }
  const neededAction =
    i === 0
      ? 'addition'
      : i === 1
      ? 'subtraction'
      : i === 2
      ? 'multiplication'
      : i === 3
      ? 'division'
      : 'error';
  return neededAction;
}

function addition(arrayEnteredValuesChecked) {
  countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
    (addition, current) => addition + current
  );
}
function subtraction(arrayEnteredValuesChecked) {
  countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
    (subtraction, current) => subtraction - current
  );
}
function multiplication(arrayEnteredValuesChecked) {
  countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
    (multiplication, current) => multiplication * current
  );
}
function division(arrayEnteredValuesChecked) {
  if (arrayEnteredValuesChecked.includes(0)) {
    createError('Делить на ноль нельзя!');
    clearResultsBlock();
  } else {
    countingResults.innerHTML = arrayEnteredValuesChecked.reduce(
      (division, current) => division / current
    );
  }
}

function performСalculationOperation() {
  const arrayEnteredValuesChecked = [];
  const checkboxElements = document.querySelectorAll(checkboxElementClassName);

  for (const checkboxElement of checkboxElements) {
    if (checkboxElement.checked) {
      arrayEnteredValuesChecked.push(+checkboxElement.value);
    }
  }

  if (arrayEnteredValuesChecked.length === 0) {
    clearResultsBlock();
    return createError('Для выполнения операций выберите числа!');
  }

  clearErrorboxSheet();
  const action = getNeededAction();

  switch (action) {
    case 'addition':
      addition(arrayEnteredValuesChecked);
      break;
    case 'subtraction':
      subtraction(arrayEnteredValuesChecked);
      break;
    case 'multiplication':
      multiplication(arrayEnteredValuesChecked);
      break;
    case 'division':
      division(arrayEnteredValuesChecked);
      break;
    case 'error':
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
