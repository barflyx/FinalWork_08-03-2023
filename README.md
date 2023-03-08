
# Требуется написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.

# 1. Определить длину нового массива.
Так как в C# при создании массива требуется строго указывать длину, то в первую очередь необходимо определить сколько потребуется ячеек в новом массиве. Для этого, в отдельном методе с помощью цикла for, определим сколько элементов в имеющемся массиве подходят условию.

# 2. Проверить наличие требуемых элементов.
Если метод поиска длины массива не найдет требуемых элементов и вернет 0, то вывести пользоателю, что нет элементов подходящих под условие.

# 3. Создание нового массива с требуемыми значениями.
Если метод поиска длины массива вернет значиение больше 0, то создаем новый массив с полученным значением длины. Далее, в отдельном методе наполняем массив значениями, подходящими под условие.

# 4. Вывод результата.
Далее, после получения нового массива из метода наполнения требуемыми элементами, выводим его пользователю.