function createResultBox(resultInput) {
  const resultsBlockInput = document.getElementById(resultsBlockInputID);
  const resultBox = document.createElement('div');
  resultBox.classList.add(resultsBoxClassNameWithoutDot);
  resultBox.innerHTML = resultInput;
  resultsBlockInput.append(resultBox);
}

function removeElement(selector) {
  const element = document.querySelector(selector);
  if (element) {
    element.remove();
  }
}
