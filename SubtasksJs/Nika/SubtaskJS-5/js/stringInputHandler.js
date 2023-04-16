formInputString.addEventListener('submit', function (e) {
  e.preventDefault();
  clearErrorbox(formInputString);

  const enteredValuesString = document
    .getElementById(enteredValuesStringID)
    .value.trim();

  if (enteredValuesString === '') {
    createError(formInputString, 'Введите не пустое значение!');
    return;
  }

  const arrayEnteredStrings = enteredValuesString.split(',');

  for (const string of arrayEnteredStrings) {
    if (string === '') {
      createError(formInputString, 'Введите не пустые строки!');
      document.getElementById(enteredValuesStringID).value = '';
      return;
    }
  }

  const resultsBox = document.querySelector(resultsBoxClassName);

  if (!resultsBox) {
    createResultBox(enteredValuesString);
  } else {
    resultsBox.insertAdjacentHTML('beforeend', `, ${enteredValuesString}`);
  }

  document.getElementById(enteredValuesStringID).value = '';
  clearButton.disabled = false;
});
