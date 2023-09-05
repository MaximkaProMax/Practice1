using System;
class HelloWorld {
    static void SwitchFinger(int fingers){
        switch (fingers)
        {
            case 1:
            Console.WriteLine("Большой мафиозный палец!");
            break;
            
            case 2:
            Console.WriteLine("Указательный корявый палец!");
            break;
            
            case 3:
            Console.WriteLine("Средний фак палец!");
            break;
            
            case 4:
            Console.WriteLine("Noname палец!");
            break;
            
            case 5:
            Console.WriteLine("Мизинец лединец!");
            break;
            
            default:
            Console.WriteLine("Введите число от 1 до 5");
            break;
        }
    }
  static void Main() {
    
    Console.Write("Введите число для определения:");
    int fingers = Convert.ToInt32(Console.ReadLine());
    
    int finger1 = fingers % 10;
    int finger2 = fingers / 10;
    
    
    HelloWorld.SwitchFinger(finger1);
    HelloWorld.SwitchFinger(finger2);
  }
}
