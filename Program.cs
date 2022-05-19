using System;
Console.WriteLine("Hola mundo");
Console.WriteLine("Invertiendo un numero");
Console.WriteLine("Ingrese un numero entero para ser invertido");
//int num = Convert.ToInt32(Console.ReadLine());
int num = 123456789;
Console.WriteLine("El número ingresado es: " + num);
Console.Write("Su número invertido es: ");
while(num!=0){
    Console.Write(num%10);
    num=num/10;
}
Console.WriteLine();
Console.WriteLine("-----FIN-----");
//*************************cadena de caracteres
Console.WriteLine("Trabajando con Cadena de Texto.");
Console.WriteLine("Ingrese un texto cualquiera");
//string texto = Console.ReadLine();
string texto = "Hola mi nombre es Jorge Juan Gudiño.";//para prueba
Console.WriteLine(texto);
// Obtener algunas letras que forman parte de una cadena
Console.WriteLine("Obteniendo letras de la cadena.");
string[] obtener = texto.Split(' ');
foreach (var sub in obtener)
{
    Console.WriteLine($"Letra: {sub}");
}
// Obtener subcadena que forman parte de una cadena
Console.WriteLine("Obteniendo una subcadena.");
int encontrado = 0;
encontrado = texto.IndexOf("es ");
Console.WriteLine("   {0}", texto.Substring(encontrado + 2));
//Obtener la longitud de la cadena y muestre por pantalla
//primera forma
Console.WriteLine("[V1]La longitud del texto [{0}] es: '{1}'", texto, texto.Length);
//segunda forma
int longitud = texto.Length;
Console.WriteLine("[V2]La longitud del texto [{0}] es: '{1}'", texto, longitud);
//Concatenar (Unir) dos cadenas distintas
//con operador
string texto2 = "Estoy aprendiendo C#";
string dateString = DateTime.Today.ToShortDateString();
string strUnido = texto +" "+ texto2 +" hoy "+ dateString + ".";
Console.WriteLine("Uniendo cadenas'");
Console.WriteLine("Con operador +");
Console.WriteLine(strUnido);
//con interpolacion
Console.WriteLine("Con interpolacion");
string strUnido2 = $"{texto} {texto2} hoy {dateString}.";
Console.WriteLine(strUnido2);
//fin primera parte