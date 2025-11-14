using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_delegate_calculadora;

public class Calculadora
{
    public static float Somar(float num1, float num2)
    {
        return num1 + num2;
    }

    public static float Subtrair(float num1, float num2)
    {
        return num1 - num2;
    }

    public static float Multiplicar(float num1, float num2)
    {
        return num1 * num2;
    }

    public static float Dividir(float num1, float num2)
    {
        return num1 / num2;
    }
}