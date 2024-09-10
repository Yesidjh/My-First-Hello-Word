

public class Program
{
    private static void Main()
    {
        // Porfavor ingresa tres numeros
        Console.WriteLine("Por favor ingresa el numero uno:");
        int numero1 = int.Parse(s: Console.ReadLine());

        Console.WriteLine("Por favor ingresa el numero uno:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingresa el numero uno:");
        int numero3 = int.Parse(Console.ReadLine());

        //Evaluar el numero mayor, menor y el del medio
        int mayor, menor, delmedio;

        if (numero1 >= numero2 && numero1 >= numero3)

        {
            mayor = numero1;
            if (numero2 >= numero3)
            {
                delmedio = numero2;
                menor = numero3;
            }
            else
            {

                delmedio = numero3;
                menor = numero2;

            }

        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            mayor = numero2;
            if (numero1 >= numero3)

            {
                delmedio = numero1;
                menor = numero3;
            }
            else
            {
                delmedio = numero3;
                menor = numero1;
            }
        }
        else
        {
            mayor = numero3;
            if (numero1 >= numero2)
            {
                delmedio = numero1;
                menor = numero2;
            }
            else
            {
                delmedio = numero2;
                menor = numero1;
            }
        }

        // Mostrar los resultados
        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número del medio es: {delmedio}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}


    

    
    



