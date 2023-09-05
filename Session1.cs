/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World"); //Привет мир выводит
    
    string name = "Maximka";  // определяем переменную и инициализируем ее
  
    Console.WriteLine(name);    // Maximka
    
    const string NAME = "Серега";  // определяем константу
    
     Console.WriteLine(NAME); //Серега
     
    //Целочисленные литералы
    Console.WriteLine(-11);
    Console.WriteLine(5);
    Console.WriteLine(505);
    
    //Для записи числа в шестнадцатеричной форме применяются символы 0x, после которых идет набор символов от 0 до 9 и от A до F
    Console.WriteLine(0x0A);    // 10
    Console.WriteLine(0xFF);    // 255
    Console.WriteLine(0xA1);    // 161

    //Строковые литералы
    Console.WriteLine("hello");
    Console.WriteLine("фыва");
    Console.WriteLine("hello word");
    
    // '\n' - перевод строки

    // '\t' - табуляция

    // '\\' - слеш
    
    Console.WriteLine("Привет \nмир");
    
    // bool: хранит значение true или false
    
    bool alive = true;
    bool isDead = false;
    
    //byte: хранит целое число от 0 до 255 и занимает 1 байт.
    byte bit1 = 1;
    byte bit2 = 102;
    
    //sbyte: хранит целое число от -128 до 127 и занимает 1 байт.
    sbyte bit1 = -101;
    sbyte bit2 = 102;
    
    //short: хранит целое число от -32768 до 32767 и занимает 2 байта.
    short n1 = 1;
    short n2 = 102;
    
    //ushort: хранит целое число от 0 до 65535 и занимает 2 байта.
    ushort n1 = 1;
    ushort n2 = 102;
    
    //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
    int a = 10;
    int b = 0b101;  // бинарная форма b =5
    int c = 0xFF;   // шестнадцатеричная форма c = 255
    
    //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. 
    uint a = 10;
    uint b = 0b101;
    uint c = 0xFF;
    
    //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
    long a = -10;
    long b = 0b101;
    long c = 0xFF;
    
    //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
    ulong a = 10;
    ulong b = 0b101;
    ulong c = 0xFF;
    
    //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
    char a = 'A';
    char b = '\x5A';
    char c = '\u0420';

    //string: хранит набор символов Unicode. Представлен системным типом System
    string hello = "Hello";
    string word = "world";
    
    //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
    object a = 22;
    object b = 3.14;
    object c = "hello code";
    
    string name = "Tom";
    int age = 33;
    bool isEmployed = false;
    double weight = 78.65;
 
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Weight: {weight}");
    Console.WriteLine($"Employed: {isEmployed}");
    
    /* 
    Имя: Tom
    Возраст: 33
    Вес: 78,65
    Работает: False */
    
    //Использование суффиксов
    float a = 3.14F;
    float b = 30.6f;
 
    decimal c = 1005.8M;
    decimal d = 334.8m;
    
    
    uint a = 10U;
    long b = 20L;
    ulong c = 30UL;
    
    //Использование системных типов
    int a = 4;
    System.Int32 b = 4;
    
    //Неявная типизация
    var hello = "Hell to World";
    var c = 20;
    
    // этот код работает
    int a;
    a = 20;
 
    // этот код не работает
    var c;
    c= 20;
    
    // этот код не работает
    var c=null;
    
    //Консольный вывод
    string hello = "Привет мир";
    Console.WriteLine(hello);
    Console.WriteLine("Добро пожаловать в C#!");
    Console.WriteLine("Пока мир...");
    Console.WriteLine(24.5);
    
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
    
    "Имя: {0}  Возраст: {2}  Рост: {1}м"
    "Имя: Tom  Возраст: 34  Рост: 1,7м"
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    //Консольный ввод
    Console.Write("Введите свое имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}");
    
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
 
    Console.Write("Введите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Введите рост: ");
    double height = Convert.ToDouble(Console.ReadLine());
 
    Console.Write("Введите размер зарплаты: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());
 
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
    
    //Арифметические операции языка C#
    //Операция сложения двух чисел:
    int x = 10;
    int z = x + 12; // 22
    
    //Операция вычитания двух чисел:
    int x = 10;
    int z = x - 6; // 4
    
    //Операция умножения двух чисел:
    /******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World"); //Привет мир выводит
    
    string name = "Maximka";  // определяем переменную и инициализируем ее
  
    Console.WriteLine(name);    // Maximka
    
    const string NAME = "Серега";  // определяем константу
    
     Console.WriteLine(NAME); //Серега
     
    //Целочисленные литералы
    Console.WriteLine(-11);
    Console.WriteLine(5);
    Console.WriteLine(505);
    
    //Для записи числа в шестнадцатеричной форме применяются символы 0x, после которых идет набор символов от 0 до 9 и от A до F
    Console.WriteLine(0x0A);    // 10
    Console.WriteLine(0xFF);    // 255
    Console.WriteLine(0xA1);    // 161

    //Строковые литералы
    Console.WriteLine("hello");
    Console.WriteLine("фыва");
    Console.WriteLine("hello word");
    
    // '\n' - перевод строки

    // '\t' - табуляция

    // '\\' - слеш
    
    Console.WriteLine("Привет \nмир");
    
    // bool: хранит значение true или false
    
    bool alive = true;
    bool isDead = false;
    
    //byte: хранит целое число от 0 до 255 и занимает 1 байт.
    byte bit1 = 1;
    byte bit2 = 102;
    
    //sbyte: хранит целое число от -128 до 127 и занимает 1 байт.
    sbyte bit1 = -101;
    sbyte bit2 = 102;
    
    //short: хранит целое число от -32768 до 32767 и занимает 2 байта.
    short n1 = 1;
    short n2 = 102;
    
    //ushort: хранит целое число от 0 до 65535 и занимает 2 байта.
    ushort n1 = 1;
    ushort n2 = 102;
    
    //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
    int a = 10;
    int b = 0b101;  // бинарная форма b =5
    int c = 0xFF;   // шестнадцатеричная форма c = 255
    
    //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. 
    uint a = 10;
    uint b = 0b101;
    uint c = 0xFF;
    
    //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
    long a = -10;
    long b = 0b101;
    long c = 0xFF;
    
    //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
    ulong a = 10;
    ulong b = 0b101;
    ulong c = 0xFF;
    
    //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
    char a = 'A';
    char b = '\x5A';
    char c = '\u0420';

    //string: хранит набор символов Unicode. Представлен системным типом System
    string hello = "Hello";
    string word = "world";
    
    //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
    object a = 22;
    object b = 3.14;
    object c = "hello code";
    
    string name = "Tom";
    int age = 33;
    bool isEmployed = false;
    double weight = 78.65;
 
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Weight: {weight}");
    Console.WriteLine($"Employed: {isEmployed}");
    
    /* 
    Имя: Tom
    Возраст: 33
    Вес: 78,65
    Работает: False */
    
    //Использование суффиксов
    float a = 3.14F;
    float b = 30.6f;
 
    decimal c = 1005.8M;
    decimal d = 334.8m;
    
    
    uint a = 10U;
    long b = 20L;
    ulong c = 30UL;
    
    //Использование системных типов
    int a = 4;
    System.Int32 b = 4;
    
    //Неявная типизация
    var hello = "Hell to World";
    var c = 20;
    
    // этот код работает
    int a;
    a = 20;
 
    // этот код не работает
    var c;
    c= 20;
    
    // этот код не работает
    var c=null;
    
    //Консольный вывод
    string hello = "Привет мир";
    Console.WriteLine(hello);
    Console.WriteLine("Добро пожаловать в C#!");
    Console.WriteLine("Пока мир...");
    Console.WriteLine(24.5);
    
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
    
    "Имя: {0}  Возраст: {2}  Рост: {1}м"
    "Имя: Tom  Возраст: 34  Рост: 1,7м"
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    //Консольный ввод
    Console.Write("Введите свое имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}");
    
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
 
    Console.Write("Введите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Введите рост: ");
    double height = Convert.ToDouble(Console.ReadLine());
 
    Console.Write("Введите размер зарплаты: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());
 
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
    
    //Арифметические операции языка C#
    //Операция сложения двух чисел:
    int x = 10;
    int z = x + 12; // 22
    
    //Операция вычитания двух чисел:
    int x = 10;
    int z = x - 6; // 4
    
    //Операция умножения двух чисел:
    int x = 10;
    int z = x * 5; // 50
    
    //Операция деления двух чисел:
    int x = 10;
    int z = x / 5; // 2
 
    double a = 10;
    double b = 3;
    double c = a / b; // 3.33333333

    double z = 10 /  4; //результат равен 2

    double z = 10.0 /  4.0; //результат равен 2.5

    double x = 10.0;
    double z = x % 4.0; //результат равен 2
    
    // ++
    int x1 = 5;
    int z1 = ++x1; // z1=6; x1=6
    Console.WriteLine($"{x1} - {z1}");
 
    int x2 = 5;
    int z2 = x2++; // z2=5; x2=6
    Console.WriteLine($"{x2} - {z2}");
    
    
    
  }
}

    
    
  }
}
