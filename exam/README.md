    1. Создать консольное консольное приложение, в котором объявить класс, содержащий конструктор, принимающий 2 параметра (целочисленный и строковый). Значения передаваемых в конструктор параметров записать в автоматически реализуемые свойства. Создать массив элементов созданного класса, размерность массива ввести с клавиатуры. Заполнить массив произвольными значениями (в автоматическом режиме) и вывести на консоль значения элементов массива.

    2. Создать консольное приложение, в котором объявить класс с приватным методом, выводящим на консоль сообщение, переданное в данном методе. Вызвать приватный метод из вне класса, в котором он объявлен.

    3. Создать консольное приложение, в котором объявить метод расчета медианного значения в целочисленном массиве, который передается в виде параметра в метод. Размерность массива задается пользователем с клавиатуры, массив заполняется случайными числами от 0 до значения размерности массива.

    4. Создать консольное приложение, в котором объявить класс, содержащий конструктор, принимающий 2 параметра (строковый и логический (bool)). Значения передаваемых в конструктор параметров записать в автоматически реализуемые свойства. Объявить класс, который является наследником данного класса. Создать два массива элементов класса наследника, размерность массива ввести с клавиатуры (размерность массивов одинаковая). Массивы заполнить произвольными значениями (в автоматическом режиме) и вывести на консоль информацию о том, в каком из массивов чаще встречается значение false.

    5. Создать консольное приложение, в котором объявить класс, содержащий в себе виртуальный и абстрактный методы. Создать класс наследник от базового класса и переопределить в нем виртуальный и абстрактный методы. Используя представителя класса наследника вызвать переопределенные методы.

    6. Создать консольное приложение, в котором объявить класс, содержащий в себе два целочисленных автоматически реализуемых свойства. Внутри класса переопределить оператор «+», который позволит складывать элементы данного класса между собой.

    7. Создать консольное приложение, в котором объявить класс, использующий обобщенный тип данных. Внутри класса объявить метод, который выводит на консоль название типа данных, который был использован в качестве обобщенного при создании элемента класса.

    8. Создать консольное приложение, в котором объявить класс, использующий обобщенный тип данных. Дополнительно создать класс, внутри которого объявить конструктор, принимающий 2 параметра (целочисленный и строковый) и записывающий значения в автоматически реализуемые свойства. Наложить ограничения на обобщенный тип данных, что он может принимать только описанный класс и классы наследники.

    9. Создать консольное приложение, в котором объявить два делегата для хранения ссылок на методы, обладающие следующими сигнатурами:
        a. void (int, string, bool)
        b. int (int[], double)
        Реализовать методы, подходящие, описанным выше сигнатурам. Сохранить ссылки на данные в описанных делегатах. Вызвать методы используя созданные делегаты.

    10. Создать консольное приложение, в котором объявить интерфейс, содержащий 3 произвольных метода. Создать класс, являющийся наследником объявленного интерфейса и реализующий данный интерфейс. Вызвать объявленные методы используя интерфейсную ссылку.

    11. Создать консольное приложение, в котором объявить класс, внутри которого содержится событие, событие может хранить ссылку на метод, обладающий заданной сигнатурой: void (int). Реализовать метод, подходящий данной сигнатуре и подписать его на событие. В событии реализовать вывод на консоль информации каждый раз, когда какой-либо метод подписывается на данное событие или отписывается от него. Вызвать событие.

    12. Создать консольное приложение, с помощью которого осуществить подключение к базе данных с использованием фреймворка EF Core (используя подход CodeFirst). Создать 1 класс для отображения в виде таблицы в БД, обладающий 2 полями: ключ (целочисленный тип) и значение (строковый тип). Создать в БД одну запись.

    13. Создать консольное приложение, с помощью которого осуществить подключение к базе данных с использованием фреймворка EF Core (используя подход CodeFirst). Создать 1 класс для отображения в виде таблицы в БД, обладающий 2 полями: ключ (целочисленный тип) и значение (строковый тип). Создать в БД 1 млн записей. Посчитать среднее время поиска (на примере 1000 операций поиска) любой конкретной записи по ключу и по значению.

    14. Создать консольное приложение, с помощью которого осуществить подключение к базе данных, испльзуя фреймворк EF Core (использовать подход CodeFirst). Создать две связанные сущности, реализуя связь один-много. Наполнить БД значениями и вывести на консоль список всех элементов в БД с загрузкой связанных сущностей используя подход Lazy Loading (ленивая загрузка)

    15. Создать консольное приложение, в котором объявить метод генерирующих массив из случайных чисел (0 - 1000). Размерность массива задается случайно (10 млн – 15 млн записей). Массив необходимо отсортировать по возрастанию и найти в массиве количество элементов, равных Х (значение Х передается в виде параметра в метод). Запустить данный метод в 10 одновременно выполняющихся потоках (из пула потоков) и посчитать минимальное, максимальное и среднее время выполнения метода.

    16. Создать консольное приложение, в котором объявить метод генерирующих массив из случайных чисел (0 - 1000). Размерность массива задается случайно (10 млн – 15 млн записей). Массив необходимо отсортировать по возрастанию и найти в массиве количество элементов, равных Х (значение Х передается в виде параметра в метод). Блок поиска количества элементов, равных Х выделить в критическую секцию (доступ в эту секцию возможет только из одного потока в один момент времени). Запустить данный метод в 10 одновременно выполняющихся потоках (из пула потоков) и посчитать минимальное, максимальное и среднее время ожидания захода в критическую секцию (ожидание равное 0 в расчетах не учитывать).

    17. Создать консольное приложение, в котором объявить метод (и запустить его в отдельном потоке (из пула потоков)) внутри которого запустить бесконечный цикл, который выводит на консоль сообщение каждый раз, когда пользователь нажимает Enter. Между нажатиями на Enter поток с бесконечным циклом замирает в ожидании действия пользователя.
    18. Реализовать Web приложение, в котором организовать 1 контроллер с 4 методами (GET, POST, PUT, DELETE). Параметры в методы передавать как через адресную строку (FromQuery), так и в теле запроса (FromBody). Продемонстрировать работу приложения либо с помощью Swagger, либо с помощью PostMan.

    19.  Реализовать Web приложение, в котором организовать 1 контроллер с методом POST. Метод POST получает параметры в теле запроса (FromBody). Дополнительно создать класс (менеджер), в котором реализовать 1 метод, зарегистрировать менеджер в DI-контейнере и вызвать данный метод в POST-методе контроллера. Продемонстрировать работу приложения либо с помощью Swagger, либо с помощью PostMan.

    20. Реализовать 2 Web-приложения, которые общаются между собой используя HTTP запросы. В первом приложении реализовать метод GET (без параметров), который возвращает коллекцию объектов (id (целочисленный), name (строковый), description (строковый)). Во втором приложении реализовать метод GET, который получает значения из первого приложения. Продемонстрировать работу приложения либо с помощью Swagger, либо с помощью PostMan.