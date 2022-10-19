# Описание решения

### Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Решение задачи

## Ввод массива из строк:
По условию задачи, первоначальный массив вводися с клавиатуры или задаётся на старте. Я реализовал это методом ввода с клавиатуры Да или Нет.

При вводе Да предлагается ввести количество элементов массива.
При вводе Нет первоначальный массив имеет значение: ["hello", "2", "world", ":-)"]
Переменная **limit** - по заданию равна 3

### *CheckArray* - Метод подсчёта количества элементов, размер которых меньше limit

Подсчёт осуществляется перебором элементов массива array и сравнением количества элементов с переменной **limit**.
Результат выводится в переменную numbersItems.
Инициализируется новый массив **newArray**, размером, равным переменной **numbersItems**.

### *FillNewArray* - Метод формирования нового массива

Формирование осуществляется перебором элементов массива **array**, сравнением количества элементов с переменной **limit** и добавлением в массив **newArray** элемента, удовлетворяющего условию.

На выходе метода получается заполненный массив  **newArray**, удовлетворяющий условию.

Для наглядности выводим его на экран с помощью метода **PrintArray**.