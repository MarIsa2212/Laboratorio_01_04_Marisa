namespace Laboratorio_01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: Operaciones artimeticas");
            Console.Write("Ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine()); //5

            Console.Write("Ingrese un otro numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine()); //3

            int suma = n1 + n2; // el + es un operador matemático
            Console.WriteLine(n1 + "+" + n2 + "=" + suma); // tiene operadores no numericos
            int resta = n1 - n2;
            Console.WriteLine(n1 + "-" + n2 + "=" + resta);
            int mul = n1 * n2;
            Console.WriteLine(n1 + "*" + n2 + "=" + mul);
            int div = n1 / n2;
            Console.WriteLine(n1 + "/" + n2 + "=" + div);
            int mod = n1 % n2;
            Console.WriteLine(n1 + "%" + n2 + "=" + mod);
            
            
            //Conversion implicita 
            double n1d = n1;
            double n2d = n2; 
            double division = n1d / n2d;
            Console.WriteLine(n1d + "/" + n2d + "=" + division);

            // Conversion explicita 
            // double division = (double)n1/n2

            //Casteo: cambiar de valor, que estan relacionados entre ellos mismos 

            // Ejemplo: double x = 3.999
            // int y = (int)x
            // como hace el casteo a int el resultado será 3, no 4 porque simplemente quita los decimales

            //Ejercicios de tarea
            //Marisa Martínez y Deborah Hernandez 
            Console.WriteLine("Ejercicio 2: Operaciones booleanas");

            Console.WriteLine(n1 > n2);
            Console.WriteLine(n1 < n2);
            Console.WriteLine(n1 == n2);
            //fin de ejercicio 2


            Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");
            Console.Write("Ingrese un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un tercer numero: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ecuación 1");
            int mul1 = a * b;
            int sum1 = mul1 + c;
            Console.WriteLine(a + "*" + b + "+" + c + "=" + sum1);

            Console.WriteLine("Ecuación 2");
            int par2 = b + c;
            int mul2 = a * par2;
            Console.WriteLine(a + "*" + "(" + b + "+" + c + ")" + "=" + mul2);

            Console.WriteLine("Ecuación 3");
            int mul3 = b * c;
            int division3 = a / mul3;
            Console.WriteLine(a + "/" + b + "*" + c + "=" + division3);

            Console.WriteLine("Ecuación 4");
            int mul41 = 3 * a;
            int mul42 = 2 * b;
            int sum4 = mul41 + mul42;
            int exp = c * c;
            int division4 = sum4 / exp;
            Console.WriteLine("(3*" + a + "+ 2*" + b + ")/" + c + "^2" + "=" + division4);

            //fin del ejercicio 3

            Console.WriteLine("Ejercicio 4: resultado de una expresion cuadratica");
            double raiz = Math.Sqrt((b * b) - 4 * a * c);
            double x = -b + raiz / (2 * a);
            double x2 = -b - raiz / (2 * a);
            Console.WriteLine("x1 es igual a " + x);
            Console.WriteLine("x2 es igual a " + x2);

            //Condiciones 
            
        }
    }
}