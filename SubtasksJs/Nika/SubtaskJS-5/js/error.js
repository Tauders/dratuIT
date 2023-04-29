function createError(parentElement, errorText) {
  const errorBox = parentElement.querySelector(errorBoxClassName);
  if (!errorBox.firstChild) {
    const errorElement = document.createElement('span');
    errorElement.className = 'error';
    errorElement.innerText = errorText;
    errorBox.append(errorElement);
  }
}

function clearErrorbox(parentElement) {
  const errorBox = parentElement.querySelector(errorBoxClassName);
  if (errorBox.firstChild) {
    errorBox.innerText = '';
  }
}
