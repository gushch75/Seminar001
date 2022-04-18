// Задача №2

Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
 if (numberA > numberB)
   {
     Console.WriteLine ($"Большим числом является {numberA}"); 
    }
    else 
   Console.WriteLine ($"Большим числом является {numberB}");

// Задача №4
Console.WriteLine("Введите три числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
 if (numberA > numberB)
   {
      max = numberA;
    }
 else 
  max = numberB;
     if  (max > numberC)
     {
       Console.WriteLine ($"Большим числом является {max}");
      }
   else 
   Console.WriteLine($"Большим числом является {numberC}");

// Задача №6
   int numberX = Convert.ToInt32(Console.ReadLine());
   if ((numberX % 2)==0)
    Console.WriteLine ($"Число {numberX}четное");
    else 
    Console.WriteLine ($"Число {numberX} нечетное");

// Задача №8
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели  число {numberA}");
int count =0;
   if ((numberA % 2)==0)
   {
      // count = count;
    }
   numberA=numberA-1;
   while (count < numberA)
   {count= count+2;
      Console.WriteLine($"Следующее четное  число {count}");
   }