function createInputsForHeaders(numbeOfFormedGroups) {
  removeElement(headingSheetClassName);
  const headingSheet = document.createElement('div');
  headingSheet.classList.add(headingSheetClassNameWithoutDot);
  distributionStringsIntoForm.append(headingSheet);

  for (let i = 0; i < numbeOfFormedGroups; i++) {
    const headingItem = document.createElement('input');
    headingItem.classList.add(headingItemClassName, 'form--data');
    headingItem.placeholder = `заголовок для группы ${i + 1}`;
    headingSheet.append(headingItem);
  }

  const buttonHeadersEntry = document.createElement('button');
  buttonHeadersEntry.classList.add(
    buttonHeadersEntryClassNameWithoutDot,
    formBtnClassName
  );
  buttonHeadersEntry.innerHTML = 'Добавить заголовки';
  headingSheet.append(buttonHeadersEntry);

  document
    .querySelector(buttonHeadersEntryClassName)
    .addEventListener('click', e => {
      e.preventDefault();
      setGroupHeaders();
    });
}

function setGroupHeaders() {
  clearErrorbox(distributionStringsIntoForm);
  const headingItems = document.querySelectorAll(
    `${headingSheetClassName} input`
  );
  let groupsArr = [];
  const groups = document.querySelectorAll(stringListClassName);
  for (let i = 0; i < headingItems.length; i++) {
    if (headingItems[i].value == '') {
      groupsArr = [];
      createError(
        distributionStringsIntoForm,
        'Введите не пустые значения заголовков!'
      );
      return;
    }
    const headerBox = document.createElement('h4');
    headerBox.classList.add(headerBoxClassName);
    headerBox.textContent = headingItems[i].value;
    groupsArr.push(headerBox);
  }
  for (let i = 0; i < groups.length; i++) {
    groups[i].prepend(groupsArr[i]);
  }
  removeElement(headingSheetClassName);
}
