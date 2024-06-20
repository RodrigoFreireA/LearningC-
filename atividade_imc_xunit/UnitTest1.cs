namespace atividade_imc_xunit;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        Assert.Equal(imc_previsto, i.imc);
    }

    [Theory]
    [InlineData(50, 1.80, "Abaixo do peso")]
    [InlineData(70, 1.75, "Peso normal")]
    [InlineData(85, 1.75, "Sobrepeso")]
    [InlineData(95, 1.70, "Obesidade Grau I")]
    [InlineData(110, 1.70, "Obesidade Grau II")]
    [InlineData(130, 1.70, "Obesidade Grau III")]
    public void Teste_Categoria_IMC(double peso, double altura, string categoriaEsperada)
    {
        IMC i = new IMC();
        i.peso = peso;
        i.altura = altura;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal(categoriaEsperada, i.categoria);
    }
}
