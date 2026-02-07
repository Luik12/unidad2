using System;
using System.Collections.Generic;

public delegate decimal Operacion(decimal a, decimal b);

public class CalculadoraGenerica<T>
{
    private List<T> numeros = new List<T>();

    public void AgregarNumero(T numero)
    {
        numeros.Add(numero);
    }

    private decimal Convertir(T valor)
    {
        return Convert.ToDecimal(valor);
    }

    public decimal EjecutarOperacion(Operacion operacion)
    {
        if (numeros.Count < 2)
            throw new InvalidOperationException("Debe haber al menos dos números.");

        decimal resultado = Convertir(numeros[0]);

        for (int i = 1; i < numeros.Count; i++)
        {
            decimal actual = Convertir(numeros[i]);

            if (operacion == Dividir && actual == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");

            resultado = operacion(resultado, actual);
        }

        return resultado;
    }


    public static decimal Sumar(decimal a, decimal b) => a + b;
    public static decimal Restar(decimal a, decimal b) => a - b;
    public static decimal Multiplicar(decimal a, decimal b) => a * b;
    public static decimal Dividir(decimal a, decimal b) => a / b;
}

class Program
{
    static void Main()
    {
        bool salirPrograma = false;

        while (!salirPrograma)
        {
            Console.WriteLine("\nSeleccione el tipo de dato:");
            Console.WriteLine("1 - int");
            Console.WriteLine("2 - double");
            Console.WriteLine("3 - decimal");
            Console.WriteLine("4 - Salir");

            string opcionTipo = Console.ReadLine();

            switch (opcionTipo)
            {
                case "1":
                    Ejecutar<int>();
                    break;
                case "2":
                    Ejecutar<double>();
                    break;
                case "3":
                    Ejecutar<decimal>();
                    break;
                case "4":
                    salirPrograma = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    static void Ejecutar<T>()
    {
        var calc = new CalculadoraGenerica<T>();
        bool volver = false;

        while (!volver)
        {
            Console.WriteLine("\n1. Agregar número");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Restar");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Dividir");
            Console.WriteLine("6. Cambiar tipo de dato");

            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el número: ");
                        string entrada = Console.ReadLine();

                        T numero = (T)Convert.ChangeType(entrada, typeof(T));
                        calc.AgregarNumero(numero);
                        break;

                    case "2":
                        Console.WriteLine("Resultado: " +
                            calc.EjecutarOperacion(CalculadoraGenerica<T>.Sumar));
                        break;

                    case "3":
                        Console.WriteLine("Resultado: " +
                            calc.EjecutarOperacion(CalculadoraGenerica<T>.Restar));
                        break;

                    case "4":
                        Console.WriteLine("Resultado: " +
                            calc.EjecutarOperacion(CalculadoraGenerica<T>.Multiplicar));
                        break;

                    case "5":
                        Console.WriteLine("Resultado: " +
                            calc.EjecutarOperacion(CalculadoraGenerica<T>.Dividir));
                        break;

                    case "6":
                        volver = true; 
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
