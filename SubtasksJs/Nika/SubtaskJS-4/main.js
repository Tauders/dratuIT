const formInputNumberID = 'input-number--form';
const formInputNumber = document.getElementById(formInputNumberID);

const enteredValueID = 'form--input-data';
const inputResultBlockID = 'results--input';
const inputResultBlock = document.getElementById(inputResultBlockID);

const randomNumberGenerationResultBlockID = 'results--generation';
const resultCalculatingArithmeticMeanBlockID =
  'result--calculating-arithmetic-mean';
const resultCalculationsMinimumBlockID = 'result--calculating-minimum';
const resultCalculationsMaximumBlockID = 'result--calculating-maximum';

const errorBoxID = 'errorBox';
const errorBox = document.getElementById(errorBoxID);

const resultCalculationsMaximumBlock = document.getElementById(
  resultCalculationsMaximumBlockID
);
const randomNumberGenerationResultBlock = document.getElementById(
  randomNumberGenerationResultBlockID
);
const resultCalculatingArithmeticMeanBlock = document.getElementById(
  resultCalculatingArithmeticMeanBlockID
);
const resultCalculationsMinimumBlock = document.getElementById(
  resultCalculationsMinimumBlockID
);

function createError(text) {
  if (!errorBox.firstChild) {
    const error = document.createElement('span');
    error.className = 'error';
    error.innerHTML = text;
    errorBox.append(error);
  }
}

function clearErrorbox() {
  if (errorBox.firstChild) {
    errorBox.innerHTML = '';
  }
}

function validateEnteredValue(enteredValue) {
  clearErrorbox();
  if (!isFinite(enteredValue)) {
    createError('Необходимо ввести одно число!');
    return false;
  }
  if (enteredValue % 1 != 0) {
    createError('Необходимо ввести целое число!');
    return false;
  }
  if (enteredValue < 10 || enteredValue > 1000) {
    createError('Необходимо ввести число в диапазоне [10; 1000]');
    return false;
  }
  return true;
}

function generateRandomInteger() {
  return Math.ceil(100 * Math.random());
}

function createArrayRandomlyGeneratedNumbers(enteredValue) {
  const arrayRandomlyGeneratedNumbers = [];
  for (let i = 0; i < enteredValue; i++) {
    arrayRandomlyGeneratedNumbers.push(generateRandomInteger());
  }
  return arrayRandomlyGeneratedNumbers;
}

function clearArrayRandomlyGeneratedNumbers(arrayRandomlyGeneratedNumbers) {
  arrayRandomlyGeneratedNumbers.length = 0;
}

function createStringOfArrayElementsWithDelimiter(
  arrayRandomlyGeneratedNumbers
) {
  return arrayRandomlyGeneratedNumbers.join(' ');
}

function outputRandomlyGeneratedNumbers(arrayRandomlyGeneratedNumbers) {
  randomNumberGenerationResultBlock.innerHTML =
    createStringOfArrayElementsWithDelimiter(arrayRandomlyGeneratedNumbers);
}

function additionRandomlyGeneratedNumbers(arrayRandomlyGeneratedNumbers) {
  return arrayRandomlyGeneratedNumbers.reduce((sum, current) => sum + current);
}
function calculateArithmeticMeanNumbers(arrayRandomlyGeneratedNumbers) {
  return additionRandomlyGeneratedNumbers(arrayRandomlyGeneratedNumbers) / 2;
}

function outputResultCalculatingArithmeticMean(arrayRandomlyGeneratedNumbers) {
  resultCalculatingArithmeticMeanBlock.innerHTML =
    calculateArithmeticMeanNumbers(arrayRandomlyGeneratedNumbers);
}

function calculateMinimumNumbers(arrayRandomlyGeneratedNumbers) {
  return Math.min(...arrayRandomlyGeneratedNumbers);
}

function calculateMaximumNumbers(arrayRandomlyGeneratedNumbers) {
  return Math.max(...arrayRandomlyGeneratedNumbers);
}

function outputResultCalculationsMinimum(arrayRandomlyGeneratedNumbers) {
  resultCalculationsMinimumBlock.innerHTML = calculateMinimumNumbers(
    arrayRandomlyGeneratedNumbers
  );
}

function outputResultCalculationsMaximum(arrayRandomlyGeneratedNumbers) {
  resultCalculationsMaximumBlock.innerHTML = calculateMaximumNumbers(
    arrayRandomlyGeneratedNumbers
  );
}

function clearBlocksResults() {
  randomNumberGenerationResultBlock.innerHTML = '';
  resultCalculatingArithmeticMeanBlock.innerHTML = '';
  resultCalculationsMinimumBlock.innerHTML = '';
  resultCalculationsMaximumBlock.innerHTML = '';
  inputResultBlock.innerHTML = '';
}

function outputInputResult(enteredValue) {
  inputResultBlock.innerHTML = enteredValue;
}

formInputNumber.addEventListener('submit', function (e) {
  e.preventDefault();
  const enteredValue = document.getElementById(enteredValueID).value;

  if (!validateEnteredValue(enteredValue)) {
    clearBlocksResults();
    document.getElementById(enteredValueID).value = '';
    return false;
  }

  clearErrorbox();
  outputInputResult(enteredValue);

  createArrayRandomlyGeneratedNumbers(enteredValue);

  const arrayRandomlyGeneratedNumbers =
    createArrayRandomlyGeneratedNumbers(enteredValue);

  outputRandomlyGeneratedNumbers(arrayRandomlyGeneratedNumbers);
  outputResultCalculatingArithmeticMean(arrayRandomlyGeneratedNumbers);
  outputResultCalculationsMinimum(arrayRandomlyGeneratedNumbers);
  outputResultCalculationsMaximum(arrayRandomlyGeneratedNumbers);

  document.getElementById(enteredValueID).value = '';
  clearArrayRandomlyGeneratedNumbers(arrayRandomlyGeneratedNumbers);
});
