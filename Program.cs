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
