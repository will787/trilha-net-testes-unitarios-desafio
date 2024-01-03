using System;
using TestesUnitarios.Desafio.Console.Services;


ValidacoesString val1 = new ValidacoesString();
Console.WriteLine(val1.ContemCaractere("ola world ou hello", "ou"));
Console.WriteLine("O tamanho da string é : " + val1.RetornarQuantidadeCaracteres("olamundo"));
Console.WriteLine("Não deve conter: " + val1.ContemCaractere("olameunome", "www"));

Console.WriteLine("\n\n<------------------------>\n\n");

ValidacoesLista vallist = new ValidacoesLista();


var lista = new List<int> {4, -1, -8, 9, 10};
Console.WriteLine(vallist.RetornarMaiorNumeroLista(lista));
Console.WriteLine(vallist.ListaContemDeterminadoNumero(lista, 9));
Console.WriteLine("\n\n<------------>\n\n");
List<int> result = vallist.MultiplicarNumerosLista(lista, 2);

foreach (var item in result)
{
    Console.WriteLine(item);
}