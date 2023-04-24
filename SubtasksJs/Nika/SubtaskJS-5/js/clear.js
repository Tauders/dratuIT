const clearButtonID = 'clear';
const clearButton = document.getElementById(clearButtonID);

function clearStringList() {
  document.querySelectorAll(stringListClassName).forEach(item => item.remove());
}
clearButton.addEventListener('click', function (e) {
  e.preventDefault();
  removeElement(resultsBoxClassName);
  clearStringList();
  removeElement(headingSheetClassName);
  clearErrorbox(distributionStringsIntoForm);
  clearErrorbox(formInputString);
  clearButton.disabled = true;
});
