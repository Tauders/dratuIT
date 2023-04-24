function getShuffledStrings(strings) {
  const newArray = [...strings];
  for (let i = newArray.length - 1; i > 0; i--) {
    const randomIndexEnteredString = Math.floor(Math.random() * (i + 1));
    const randomEnteredString = newArray[randomIndexEnteredString];
    newArray[randomIndexEnteredString] = newArray[i];
    newArray[i] = randomEnteredString;
  }
  return newArray;
}

function distributeStringsToGroups(
  jumbledArrayEnteredStringsCopy,
  arrayWithSubarraysEnteredStrings
) {
  const numberOfRemainingString = jumbledArrayEnteredStringsCopy.length;

  const arrNumbers = [];
  for (let i = 0; i < arrayWithSubarraysEnteredStrings.length; i++) {
    arrNumbers.push(i);
  }
  const newArr = getShuffledStrings(arrNumbers);

  for (let i = 0; i < numberOfRemainingString; i++) {
    arrayWithSubarraysEnteredStrings[newArr[i]].push(
      jumbledArrayEnteredStringsCopy[i]
    );
  }
}

function splitAnArrayIntoSubarrays(
  jumbledArrayEnteredStrings,
  initialLengthOfSubarray,
  numberOfGroups
) {
  clearErrorbox(distributionStringsIntoForm);
  const jumbledArrayEnteredStringsForChange =
    jumbledArrayEnteredStrings.slice();
  const arrayWithSubarraysEnteredStrings = [];
  if (jumbledArrayEnteredStringsForChange.length % numberOfGroups === 0) {
    while (jumbledArrayEnteredStringsForChange.length > 0) {
      const subArrayEnteredStrings = jumbledArrayEnteredStringsForChange.splice(
        0,
        initialLengthOfSubarray
      );
      arrayWithSubarraysEnteredStrings.push(subArrayEnteredStrings);
    }

    return arrayWithSubarraysEnteredStrings;
  }

  if (numberOfGroups > jumbledArrayEnteredStringsForChange.length) {
    numberOfGroups = jumbledArrayEnteredStringsForChange.length;
    createError(
      distributionStringsIntoForm,
      `Кол-во групп, которое Вы ввели, превышает кол-во элементов, было сформировано максимальное кол-во групп: ${numberOfGroups}`
    );
  }
  for (let i = 0; i < numberOfGroups; i++) {
    const subArrayEnteredStrings = jumbledArrayEnteredStringsForChange.splice(
      0,
      initialLengthOfSubarray
    );

    arrayWithSubarraysEnteredStrings.push(subArrayEnteredStrings);
  }

  distributeStringsToGroups(
    jumbledArrayEnteredStringsForChange,
    arrayWithSubarraysEnteredStrings
  );

  return arrayWithSubarraysEnteredStrings;
}

function calculateInitialLengthOfSubarray(
  numberJumbledStrings,
  numberOfGroups
) {
  return Math.floor(numberJumbledStrings / numberOfGroups);
}

