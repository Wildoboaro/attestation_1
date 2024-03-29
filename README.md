# Контрольная работа
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

### Для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

### Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

_Примеры:_

>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

## Решение задачи.

1. Предполагаем, что максиальное количество элементов исходной массива, соответствующих заданному параметру(длинна менее или равня трем символам) совмадает с количеством элементов. Соответвенно, задаем размер итогового архива равным размеру исходного. Иницируем счетчик позиции для итогового массива(resCount) и присваиваем ему нулевое значение. 
2. Поочередно проверяем каждый элемент исходного массива из строк на длинну(строки). В случае, если условие(длинна менее или ровна трем) выполняется, присавиваем значение этого элемента , элементу итогового массива с номером resCount и увеличиваем номер resCount на единцу.
3. После того как провернны все элементы исходного массива, уменьшаем размер итогового массива до resCount. 
4. Выводим резльтат.    


Аннотация: [README.md](https://github.com/Wildoboaro/attestation_1/blob/98452d1b301d133c794e0909d9ebbc64ed6ced01/README.md)   
Блок-схема: [Attestation.jpg](https://github.com/Wildoboaro/attestation_1/blob/98452d1b301d133c794e0909d9ebbc64ed6ced01/Attestation.jpg)   
Программа: [Program.cs](https://github.com/Wildoboaro/attestation_1/blob/98452d1b301d133c794e0909d9ebbc64ed6ced01/code/Program.cs)