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
//Creacion de la calculadora
//calculadora version 2.0
Console.WriteLine("CALCULADORA 2.0");
Console.WriteLine("Ingrese un números");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Operaciones sobre el número "+x);
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
//calculadora version 1.0
Console.WriteLine("CALCULADORA 1.0");
int opc=10;
while(opc!=0){
    Console.WriteLine("Seleccione el tipo de operacion que desea realizar");
    Console.WriteLine("1-> SUMAR");
    Console.WriteLine("2-> RESTAR");
    Console.WriteLine("3-> MULTIPLICAR"); 
    Console.WriteLine("4-> DIVIDIR");
    opc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese dos números");
    x = Convert.ToDouble(Console.ReadLine());
    y = Convert.ToDouble(Console.ReadLine());
    double resultado;
    switch (opc)
    {
        case 1: 
            resultado = Sumar(x,y);
            Console.WriteLine("Resultado Suma: "+ resultado);
            break;
        case 2: 
            resultado = Restar(x,y);
            Console.WriteLine("Resultado Resta: "+ resultado);
            break;
        case 3: 
            resultado = Multiplicar(x,y);
            Console.WriteLine("Resultado Multiplicación: "+ resultado);
            break;
        case 4:
            if(y!=0){
                resultado = Dividir(x,y);
                Console.WriteLine("Resultado División: "+ Math.Round(resultado,2));
            }else{
                Console.WriteLine("ERROR");
            }            
            break;
    }
    Console.WriteLine("¿Desea realizar otro calculo?");
    Console.WriteLine("0-> NO");
    Console.WriteLine("1-> SI"); 
    opc = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("-----FIN-----");
//**************************definicion de funciones
double Sumar(double x, double y){
    return x + y;
}
double Restar(double x, double y){
    return x - y;
}
double Multiplicar(double x, double y){
    return x * y;
}
double Dividir(double x, double y){
        return x / y;    
}
