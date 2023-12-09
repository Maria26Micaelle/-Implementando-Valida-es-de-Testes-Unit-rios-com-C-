public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }

    public int Dividir(int dividendo, int divisor)
    {
        if (divisor == 0)
            throw new ArgumentException("Não é possível dividir por zero.");

        return dividendo / divisor;
    }
}
using System;
using Xunit;

public class CalculadoraTestes
{
    [Fact]
    public void TesteSomar()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Somar(3, 5);

        // Assert
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TesteSubtrair()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Subtrair(10, 4);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void TesteDividir()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Dividir(8, 2);

        // Assert
        Assert.Equal(4, resultado);
    }

    [Fact]
    public void TesteDividir_PorZero_DeveLancarExcecao()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act e Assert
        Assert.Throws<ArgumentException>(() => calculadora.Dividir(10, 0));
    }
}
