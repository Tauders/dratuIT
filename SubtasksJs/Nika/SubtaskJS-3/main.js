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
const MAXIMUM_ALLOWED_NUMBER = 20;
const MAXIMUM_ALLOWED_LENGTH_NUMBER = 20;

function clearCheckboxList() {
  if (checkboxList.firstChild) {
    checkboxList.innerHTML = '';
  }
}

function clearErrorBox() {
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

function validateEnteredValue(enteredValue) {
  if (enteredValue === '') {
    return false;
  }
  if (isNaN(enteredValue)) {
    createError('Вы ввели нечисловое значение! Попробуйте снова.');
    return false;
  }
  if (enteredValue.length >= MAXIMUM_ALLOWED_LENGTH_NUMBER) {
    createError(
      'Вы ввели слишком длинное число! Максимально разрешенная длина числа - 20 знаков.'
    );
    return false;
  }
  return true;
}

function checkEnteredValues(arrayEnteredValues) {
  if (arrayEnteredValues.length >= MAXIMUM_ALLOWED_NUMBER) {
    createError(
      'Вы ввели недопустимое количество чисел! Введите не более 20 чисел.'
    );
    return false;
  }

  for (const enteredValue of arrayEnteredValues) {
    if (!validateEnteredValue(enteredValue)) {
      clearCheckboxList();
      return false;
    }
    createCheckboxItem(enteredValue);
  }

  return true;
}

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

function getValueSelectedRadioOption() {
  const controlRadioOptionCollections =
    document.querySelectorAll(controlRadioOptionID);
  for (const controlRadioOption of controlRadioOptionCollections) {
    if (controlRadioOption.checked) {
      return controlRadioOption.value;
    }
  }
  return 'error';
}

function createArrayEnteredValuesChecked() {
  const checkboxElements = document.querySelectorAll(checkboxElementClassName);
  const arrayEnteredValuesChecked = [];
  for (const checkboxElement of checkboxElements) {
    if (checkboxElement.checked) {
      arrayEnteredValuesChecked.push(+checkboxElement.value);
    }
  }

  return arrayEnteredValuesChecked;
}

function checkLengthArrayEnteredValuesChecked(arrayEnteredValuesChecked) {
  if (arrayEnteredValuesChecked.length === 0) {
    createError('Для выполнения операций выберите числа!');
  }
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
  return arrayEnteredValuesChecked.reduce(
    (division, current) => division / current
  );
}

function checkImproverValue(arrayEnteredValuesChecked) {
  return arrayEnteredValuesChecked.includes(0);
}
function performSelectedAction(arrayEnteredValuesChecked) {
  const action = getValueSelectedRadioOption();
  let calculationResults;
  switch (action) {
    case 'addition':
      calculationResults = addition(arrayEnteredValuesChecked);
      break;
    case 'subtraction':
      calculationResults = subtraction(arrayEnteredValuesChecked);
      break;
    case 'multiplication':
      calculationResults = multiplication(arrayEnteredValuesChecked);
      break;
    case 'division':
      if (checkImproverValue(arrayEnteredValuesChecked)) {
        calculationResults = undefined;
        createError('Делить на ноль нельзя!');
      } else {
        calculationResults = division(arrayEnteredValuesChecked);
      }
      break;
    case 'error':
      createError('Выберите операцию!');
      calculationResults = undefined;
  }
  return calculationResults;
}

document
  .getElementById(formInputNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    clearResultsBlock();
    clearCheckboxList();
    clearErrorBox();

    const enteredValues = document.getElementById(enteredValuesID).value;
    const arrayEnteredValues = enteredValues.split(' ');

    checkEnteredValues(arrayEnteredValues);

    document.getElementById(enteredValuesID).value = '';
  });

document
  .getElementById(formCountingNumberID)
  .addEventListener('submit', function (e) {
    e.preventDefault();
    clearResultsBlock();
    clearErrorBox();

    const arrayEnteredValuesChecked = createArrayEnteredValuesChecked();
    checkLengthArrayEnteredValuesChecked(arrayEnteredValuesChecked);

    if (performSelectedAction(arrayEnteredValuesChecked) != undefined) {
      countingResults.innerHTML = performSelectedAction(
        arrayEnteredValuesChecked
      );
    }

    resetRadioButtons();
  });
