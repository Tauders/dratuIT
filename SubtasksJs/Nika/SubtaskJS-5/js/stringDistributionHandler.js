const distributionStringsIntoFormID = 'distributionStringsIntoForm';
const distributionStringsIntoForm = document.getElementById(
  distributionStringsIntoFormID
);

distributionStringsIntoForm.addEventListener('submit', function (e) {
  e.preventDefault();
  clearStringList();
  clearErrorbox(distributionStringsIntoForm);

  const numberOfGroups = document.getElementById(numberOfGroupsID).value;

  if (
    numberOfGroups === '' ||
    +numberOfGroups <= 0 ||
    !Number.isInteger(+numberOfGroups)
  ) {
    createError(
      distributionStringsIntoForm,
      'Введите целое числовое значение > 0!'
    );
    return;
  }

  if (document.querySelector(resultsBoxClassName) === null) {
    createError(formInputString, 'Введите строки!');
    return;
  }

  const arrayEnteredStrings = document
    .querySelector(resultsBoxClassName)
    .textContent.split(',');

  const jumbledArrayEnteredStrings = getShuffledStrings(arrayEnteredStrings);

  const numberJumbledStrings = jumbledArrayEnteredStrings.length;

  const initialLengthOfSubarray = calculateInitialLengthOfSubarray(
    numberJumbledStrings,
    numberOfGroups
  );

  const arrayIntoSubarrays = splitAnArrayIntoSubarrays(
    jumbledArrayEnteredStrings,
    initialLengthOfSubarray,
    numberOfGroups
  );

  const numbeOfFormedGroups = arrayIntoSubarrays.length;

  createInputsForHeaders(numbeOfFormedGroups);

  createGroupRows(arrayIntoSubarrays);

  document.getElementById(numberOfGroupsID).value = '';
});
