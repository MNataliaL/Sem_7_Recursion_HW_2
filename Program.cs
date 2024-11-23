// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 29



//Проверка натуральности
 bool Control (int num)
 {
    if (num < 0 || num % 1 > 0) 
    {
        Console.WriteLine("Некорректный ввод");  
        return false;               
    }
    return true;    
 }


// функция Аккермана
int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}


int[] numbers = new int [2];

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Введите натуральное {i+1}-е число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    //numbers[i] = Control(numbers[i]);
    if (!Control(numbers[i]))
    {
        break;
    }
}

if (numbers[0] >= 0 && numbers[1] >= 0)
{
    int resAkkerman = Akk(numbers[0], numbers[1]); 
    Console.WriteLine(resAkkerman);
}