function createGroupRows(arrayStrings) {
  for (const subArrayEnteredStrings of arrayStrings) {
    const stringList = document.createElement('ul');
    stringList.className = stringListClassNameWithoutDot;

    for (const enteredString of subArrayEnteredStrings) {
      let stringListItem = document.createElement('li');
      stringListItem.className = stringListItemClassName;
      stringListItem.textContent = enteredString.trim();
      stringList.append(stringListItem);
    }
    resultsBlockDistribution.append(stringList);
  }
}
