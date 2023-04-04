namespace Clase1.Logica;
public class Calculadora{
    public static int Sumar(int nro1, int nro2)
    {
        return nro1 + nro2;
    }

    public static int Sumar(string valor1, string valor2)
    {
        return Sumar(int.Parse(valor1), int.Parse(valor2));
    }
}
