using System;

public class Program{
	public static void Main(){
		Console.Write("Введите число n: ");
		int n = Convert.ToInt32(Console.ReadLine());

		Console.Write("Введите число x: ");
		int x = Convert.ToInt32(Console.ReadLine());
		double output = 0;

		if(n < 0) Console.WriteLine("Ошибка");
		else{
			for(int i = 0; i < n; i++){
			if(i % 2 == 0) output += myFunction(x, i);
			else output -= myFunction(x, i);
			Console.WriteLine("Аргумент: " + x + "\t" + "Значение функции: " + myFunction(x, i) + "\t" + "Просуммировано элементов: " + i);
		}
		Console.WriteLine("Ответ: " + output);
	}
}

	public static int factorial(int x){
		if(x < 1) return 1;
		else return x * factorial(x - 1);
	}

	public static double myFunction(double x, int i){
		return Math.Pow(x, i) / factorial(i);
	}
}