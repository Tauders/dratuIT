const formInputNumberID = 'input-number--form';
const formInputNumber = document.getElementById(formInputNumberID);
const enteredValueID = 'form--input-data';
const inputResultBlockID = 'results--input';
const randomNumberGenerationResultBlockID = 'results--generation';
const resultCalculatingArithmeticMeanBlockID =
  'result--calculating-arithmetic-mean';
const resultCalculationsMinimumBlockID = 'result--calculations-minimum';
const resultCalculationsMaximumBlockID = 'result--calculations-maximum';
const arrayRandomlyGeneratedNumbers = [];
const errorBoxID = 'errorBox';
const errorBox = document.getElementById(errorBoxID);
const inputResultBlock = document.getElementById(inputResultBlockID);

const randomNumberGenerationResultBlock = document.getElementById(
  randomNumberGenerationResultBlockID
);
const resultCalculatingArithmeticMeanBlock = document.getElementById(
  resultCalculatingArithmeticMeanBlockID
);
const resultCalculationsMinimumBlock = document.getElementById(
  resultCalculationsMinimumBlockID
);
const resultCalculationsMaximumBlock = document.getElementById(
  resultCalculationsMaximumBlockID
);

function createError(text) {
  if (!errorBox.firstChild) {
    const error = document.createElement('span');
    error.className = 'error';
    error.innerHTML = text;
    errorBox.append(error);
  }
}

function clearErrorboxSheet() {
  if (errorBox.firstChild) {
    errorBox.innerHTML = '';
  }
}

function clearBlocksResults() {
  randomNumberGenerationResultBlock.innerHTML = '';
  resultCalculatingArithmeticMeanBlock.innerHTML = '';
  resultCalculationsMinimumBlock.innerHTML = '';
  resultCalculationsMaximumBlock.innerHTML = '';
  inputResultBlock.innerHTML = '';
}

function createArrayRandomlyGeneratedNumbers(enteredValue) {
  for (let i = 0; i < enteredValue; i++) {
    arrayRandomlyGeneratedNumbers.push(generateRandomInteger());
  }
}

function clearArrayRandomlyGeneratedNumbers() {
  arrayRandomlyGeneratedNumbers.length = 0;
}

function outputRandomlyGeneratedNumbers() {
  randomNumberGenerationResultBlock.innerHTML =
    arrayRandomlyGeneratedNumbers.join(' ');
}

function generateRandomInteger() {
  return Math.ceil(100 * Math.random());
}

function calculateArithmeticMeanNumbers() {
  const additionRandomlyGeneratedNumbers = arrayRandomlyGeneratedNumbers.reduce(
    (sum, current) => sum + current
  );
  return additionRandomlyGeneratedNumbers / 2;
}

function calculateMinimumNumbers() {
  return Math.min(...arrayRandomlyGeneratedNumbers);
}

function calculateMaximumNumbers() {
  return Math.max(...arrayRandomlyGeneratedNumbers);
}

function outputResultCalculatingArithmeticMean() {
  resultCalculatingArithmeticMeanBlock.innerHTML =
    calculateArithmeticMeanNumbers();
}

function outputResultCalculationsMinimum() {
  resultCalculationsMinimumBlock.innerHTML = calculateMinimumNumbers();
}

function outputResultCalculationsMaximum() {
  resultCalculationsMaximumBlock.innerHTML = calculateMaximumNumbers();
}

function checkEnteredValue(enteredValue) {
  if (!isFinite(enteredValue)) {
    createError('Необходимо ввести одно число!');
    clearBlocksResults();
  } else if (enteredValue < 10 || enteredValue > 1000) {
    createError('Необходимо ввести число в диапазоне [10; 1000]');
    clearBlocksResults();
  } else {
    return true;
  }
}

formInputNumber.addEventListener('submit', function (e) {
  e.preventDefault();
  const enteredValue = document.getElementById(enteredValueID).value;

  if (checkEnteredValue(enteredValue) != true) {
    return;
  }

  inputResultBlock.innerHTML = enteredValue;

  clearErrorboxSheet();
  createArrayRandomlyGeneratedNumbers(enteredValue);
  outputRandomlyGeneratedNumbers();
  outputResultCalculatingArithmeticMean();
  outputResultCalculationsMinimum();
  outputResultCalculationsMaximum();

  document.getElementById(enteredValueID).value = '';
  clearArrayRandomlyGeneratedNumbers();
});
