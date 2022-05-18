using System;
Console.WriteLine("Hola mundo");
Console.WriteLine("Invertiendo un numero");
Console.WriteLine("Ingrese un numero entero para ser invertido");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El número ingresado es: " + num);
Console.Write("Su número invertido es: ");
while(num!=0){
    Console.Write(num%10);
    num=num/10;
}
Console.WriteLine();
Console.WriteLine("-----FIN-----");
//Creacion de la calculadora
Console.WriteLine("CALCULADORA 2.0");
Console.WriteLine("Ingrese un números");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Operaciones sobre el numero");
Console.WriteLine("Valor Absoluto = " + Math.Abs(x));
Console.WriteLine("Cuadrado = " + Math.Pow(x,2));
Console.WriteLine("Raiz Cuadrada = " + Math.Sqrt(x));
Console.WriteLine("Seno = " + Math.Sin(x));
Console.WriteLine("Coseno = " + Math.Cos(x));
Console.WriteLine("Parte entera = " + Math.Round(x));
Console.WriteLine("Ingrese dos números");
double z = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("El número mayor es: " + Math.Max(z,y));
Console.WriteLine("El número menor es: " + Math.Min(z,y));
Console.WriteLine("-----FIN-----");