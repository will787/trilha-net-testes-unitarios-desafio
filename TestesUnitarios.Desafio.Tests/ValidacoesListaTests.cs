using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9};
        var numeroParaProcurar = 9;

        // Act
        bool resultadoEsperadoSendo9 = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultadoEsperadoSendo9);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste {OK}

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        bool NaoDeveraConter = _validacoes.ListaContemDeterminadoNumero(lista, 10);
        // Assert
        Assert.False(NaoDeveraConter);
    }

    //TODO: Corrigir a anotação [Fact] {OK}
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste {OK}

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var Multiplcadorpor2 = _validacoes.MultiplicarNumerosLista(lista, 2);
        // Assert

        Assert.Equal(resultadoEsperado, Multiplcadorpor2);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste {OK}

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var ParametroEsperado = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método {OK}
        Assert.Equal(9, ParametroEsperado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste {OK}

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var ResultadoMenorSendo8 = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método {OK}
        Assert.Equal(-8, ResultadoMenorSendo8);
    }
}
