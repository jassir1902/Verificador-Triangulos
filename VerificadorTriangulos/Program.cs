int a;
int b;
int c;

Console.WriteLine("-----Verificador de Triangulos-----");
Console.WriteLine("Ingrese numeros enteros para cada lado de un triangulo.");
Console.Write("Ingrese el lado A del triangulo: ");
a = VerificarNumeroEntero();
Console.Write("Ingrese el lado B del triangulo: ");
b = VerificarNumeroEntero();
Console.Write("Ingrese el lado C del triangulo: ");
c = VerificarNumeroEntero();

string tipo = VerificarTriangulo(a,b,c);
Console.WriteLine($"El triangulo es {tipo}");

string VerificarTriangulo(int a, int b, int c)
{
    if(a == b && b == c)
    {
        return "Equilatero";
    }
    else if(a == b || a == c ||b == c)
    {
        return "Isoceles";
    }
    else
    {
        return "Escaleno";
    }
}

int VerificarNumeroEntero()
{
    int numero = 0;
    bool valido = false;

    while (!valido)
    {
        string entrada = Console.ReadLine();
        try
        {
            numero = Convert.ToInt32(entrada);
            valido = true;
            Console.WriteLine("Has ingresado el numero: " + numero);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingresa un numero entero valido.");
            Console.Write("Vuelva a intentarlo: ");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El numero ingresado es demasiado grande o demasiado pequeno.");
            Console.Write("Vuelva a intentarlo: ");
        }
    }
    return numero;
}


