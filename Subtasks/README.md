# Упражнения на понимание базовых вещей

Задачи, в виду своей простоты, описаны в виде того, что нужно сделать пользователю и что пользователь получит.

`->` будет обозначать ввод от пользователя.
`<-` будет обозначать вывод от программы.

## Упражнение 1

1. Пользователь вводит то, сколько строк будет вводить. (здесь будет называть это число N, допустимые значения от 0 до N)
2. Пользователь вводит столько строк, сколько ввёл на предыдущем шаге. (каждая строка на новой строке ввода)
3. После этого выводится "Все строки введены, выберите строку для отображения"
4. Пользователь вводит число, для получения строки, или `X` для прекращения работы.
5. Если это валидное число, то выводим строку. Если это `X`, то выводим "Работа завершена". Если ввод не валидный, то "Ошибка".

### Пример упражнения 1

```plain

<- Введите количество строк, которые хотите использовать
-> 3 
-> Sun
-> Moon
-> Star
<- Все строки введены, выберите строку для отображения
-> 2
<- Star
-> 1
<- Moon
-> 4
<- Ошибка
-> X
<- Работа завершена

```

## Упражнение 2

1. Программа генерирует случайно целое число от 3 до 7.
2. Пользователь через пробел вводит столько чисел, сколько было получено в предыдущем шаге.
3. Пользователь выбирает любые числа (по порядку их ввода), от 0 до всех доступных (каждое число на новой строке). Остановка выбора через ввод `X`.
4. Пользователь вводит, что сделать с числами (допустимые значения `+`, `-`, `/`, `*`)
5. Вывод результата выполнения команды с прошлого шага на экран.

### Пример упражнения 2

```plain
<- Программа сгенерировала 3
-> 4 5 6
<- Числа введены, выберите доступные. X - выход
-> 0
-> 1
-> X
<- Числа выбраны, введите необходимое действие
-> +
<- Действие выбрано, результат - 9

```

## Упражнение 3

1. Пользователь вводит любое количество слов (построчно). Остановка ввода через ввод `X`.
2. Пользователь выбирает способ сортировки (допустимые значения `asc`, `desc`).
3. Вывести результат сортировки.

### Пример упражнения 3

```plain
<- Введите любое количество слов, для остановки введите X
-> Watermelon
-> Apple
-> Pineapple
-> Banana
-> X
<- Данные введены, выберите способ сортировки (asc, desc)
-> asc
<- Apple
<- Banana
<- Pineapple
<- Watermelon
<- Все значения выведены
```

## Упражнение 4

1. Пользователь вводит данные в формате "имя группа", при этом имя и группа - одно слово, группа может повторяться.
2. Пользователь выбирает направление сортировки (допустимые значения `asc`, `desc`).
3. Вывести сгруппированные по "группе" данные, отсортировав их по указанному направлению, сортировка касается только имён.

### Пример упражнения 4

```plain
<- Введите данные в формате "имя группа", имя и группа  - одно слово
-> Степан Баскетбол
-> Аксений Футбол
-> Ярослав Баскетбол
-> Анна Поло
-> X
<- Данные введены, выберите способ сортировки
-> desc
<- Группа Баскетбол
<- Ярослав
<- Степан
<- Группа Футбол
<- Аксений
<- Группа Поло
<- Анна
<- Все значения выведены
```

## Упражнение 5

1. Пользоветель вводит число от 10 до 1000 (это будет N).
2. Сгенерировать случайным образом N чисел от 1 до 100.
3. Вывести все уникальные числа, самое большое, маленькое, среднее.

### Пример упражнения 5

```plain
<- Введите количество чисел (от 10 до 1000)
-> 30
<- Количество чисел получено
<- Уникальные значения:
<- 64 11 69 85 20 42 8 90 12 83 9 13 30 82 98 65 22 88 19 39 93 66 91 78 24
<- Минимально значение = 8
<- Максимальное значение = 98
<- Среднее значение = 52,04
```

## Упражнение 6

1. Пользователь вводит произвольное число строк (построчно, конец ввода - `X`).
2. Пользователь вводит количество групп.
3. Вывести случайно разбитые на нужное количество групп строки. (Примерно одинаково количество строк в группах)
4. Пользовательно может заново разбивать группы, пока не выйдет из программы. 
Для этого в конце вывода результата надо задать вопрос "Ещё раз? y/n" и обработать "y" - ещё раз, "n" - выход.

### Пример упражнения 6

```plain
<- Введите строки
-> Дима
-> Саша
-> Женя
-> Вова
-> Вася
-> Кудря
-> X
<- Строки получены, введите количество групп
-> 2
<- Группа 1
<- Женя
<- Вова
<- Кудря
<- Группа 2
<- Дима
<- Вася
<- Саша
<- Ещё раз? y/n
-> y
<- Группа 1
<- Женя
<- Вова
<- Дима
<- Группа 2
<- Вася
<- Саша
<- Кудря
<- Ещё раз? y/n
-> n
```
