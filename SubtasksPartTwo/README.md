# Упражнения на понимание базовых вещей, продолжение

Задачи, в виду своей простоты, описаны в виде того, что нужно сделать пользователю и что пользователь получит.

`->` будет обозначать ввод от пользователя.
`<-` будет обозначать вывод от программы.

## Упражнение 1

1. Пользователь вводит полный путь до файла с данными.

    Файл содержит колонки вида:

    group|song|genres|duration

    Содержимое файл выглядит примерно так:

    ```txt
    Queen|Bohemian Rhapsody|Progressive rock, hard rock, progressive pop|5:55
    Guns N' Roses|Paradise City|Glam metal, hard rock, heavy metal|6:48
    Imagine Dragons|Radioactive|Electronic rock, alternative rock|3:07
    Queen|We Will Rock You|Arena rock|2:59
    Led Zeppelin|Good Times Bad Times|Hard rock|2:43
    Imagine Dragons|Enemy|Pop rock, rock|2:53
    ```

2. Пользователь вводит колонку, по которой собирается делать выборку и получать дополнительную информацию.

    У каждой колонки свои правила. У `group` -> фильтровать по названию. У `song` -> фильтровать по названию. У `genres` -> фильтровать по названию жанра. У `duration` -> сортировка (`asc` или `desc`). Результатом должны быть отфильтрованные, либо сортированные записи.

3. Пользователь вводит строку с дополнительной информацией.
4. Сохранить обработанные записи в файл `output.txt` во входном формате.

### Пример упражнения 1

```plain

<- Введите полный путь до файла
-> C:/temp/input.txt
<- Введите название колонки, по которой производить действия
-> genres
<- Введите название жанра
-> Hard rock
<- Результаты сохранены

```

input.txt

```txt
Queen|Bohemian Rhapsody|Progressive rock, hard rock, progressive pop|5:55
Guns N' Roses|Paradise City|Glam metal, hard rock, heavy metal|6:48
Imagine Dragons|Radioactive|Electronic rock, alternative rock|3:07
Queen|We Will Rock You|Arena rock|2:59
Led Zeppelin|Good Times Bad Times|Hard rock|2:43
Imagine Dragons|Enemy|Pop rock, rock|2:53
```

output.txt

```txt
Queen|Bohemian Rhapsody|Progressive rock, hard rock, progressive pop|5:55
Guns N' Roses|Paradise City|Glam metal, hard rock, heavy metal|6:48
Led Zeppelin|Good Times Bad Times|Hard rock|2:43
```
