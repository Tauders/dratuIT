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
    return false;
  }
  if (isNaN(enteredValue)) {
    clearCheckboxSheet();
    createError('Вы ввели нечисловое значение! Попробуйте снова.');
    return false;
  }
  if (enteredValue.length >= 20) {
    clearCheckboxSheet();
    createError(
      'Вы ввели слишком длинное число! Максимально разрешенная  длина числа - 20 знаков.'
    );
    return false;
  }
  return true;
}
function checkEnteredValues(arrayEnteredValues) {
  if (arrayEnteredValues.length >= 20) {
    createError(
      'Вы ввели недопустимое количество чисел! Введите не более 20 чисел.'
    );
    return false;
  }

  clearErrorboxSheet();

  for (const enteredValue of arrayEnteredValues) {
    if (checkEnteredValue(enteredValue)) {
      createCheckboxItem(enteredValue);
    } else {
      return false;
    }
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

    checkEnteredValues(arrayEnteredValues);

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

function determineValueSelectedRadioOption() {
  const controlRadioOptionCollections =
    document.querySelectorAll(controlRadioOptionID);
  for (let i = 0; i < controlRadioOptionCollections.length; i++) {
    if (controlRadioOptionCollections[i].checked) {
      return controlRadioOptionCollections[i].value;
    }
  }
  return 'error';
}

function addition(arrayEnteredValuesChecked) {
  return arrayEnteredValuesChecked.reduce(
    (addition, current) => addition + current
  );
}
function subtraction(arrayEnteredValuesChecked) {
  return arrayEnteredValuesChecked.reduce(
    (subtraction, current) => subtraction - current
  );
}
function multiplication(arrayEnteredValuesChecked) {
  return arrayEnteredValuesChecked.reduce(
    (multiplication, current) => multiplication * current
  );
}
function division(arrayEnteredValuesChecked) {
  if (arrayEnteredValuesChecked.includes(0)) {
    createError('Делить на ноль нельзя!');
    clearResultsBlock();
  } else {
    return arrayEnteredValuesChecked.reduce(
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

  const action = determineValueSelectedRadioOption();

  switch (action) {
    case 'addition':
      countingResults.innerHTML = addition(arrayEnteredValuesChecked);
      break;
    case 'subtraction':
      countingResults.innerHTML = subtraction(arrayEnteredValuesChecked);
      break;
    case 'multiplication':
      countingResults.innerHTML = multiplication(arrayEnteredValuesChecked);
      break;
    case 'division':
      countingResults.innerHTML = division(arrayEnteredValuesChecked);
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
