using TestesUnitarios.Desafio.Console.Services;


ValidacoesLista lista = new ValidacoesLista();

List<int> numeros = new List<int> { 5, -1, -8, 9 };

List<int> listaSemNegativos = lista.RemoverNumerosNegativos(numeros);
List<int> listaMultiplicada = lista.MultiplicarNumerosLista(numeros, 2);

Console.WriteLine("VALIDANDO LISTAS");

Console.WriteLine("Remover Numeros Negativos:");
foreach(int item in listaSemNegativos)
{
    Console.WriteLine(item);
}

Console.WriteLine("Lista Contem Numero:");
Console.WriteLine(lista.ListaContemDeterminadoNumero(numeros, 9));

Console.WriteLine("Multiplicar Numeros Lista:");
foreach(int item in listaMultiplicada)
{
    Console.WriteLine(item);
}

Console.WriteLine("Retorna Maior Numero:");
Console.WriteLine(lista.RetornarMaiorNumeroLista(numeros));

Console.WriteLine("Retorna Menor Numero:");
Console.WriteLine(lista.RetornarMenorNumeroLista(numeros));


Console.WriteLine("VALIDANDO STRINGS");

ValidacoesString validacaoStrings = new ValidacoesString();

string quantChars = "Matrix";
string contemChars = "Esse é um texto qualquer";
string texto = "Começo, meio e fim do texto procurado";

Console.WriteLine("Retorna quantidade de caracteres:");
Console.WriteLine(validacaoStrings.RetornarQuantidadeCaracteres(quantChars));

Console.WriteLine("Retorna se contem a string dada no texto:");
Console.WriteLine(validacaoStrings.ContemCaractere(contemChars, "qualquer"));

Console.WriteLine("Retorna se NAO contem a string dada no texto:");
Console.WriteLine(validacaoStrings.ContemCaractere(contemChars, "teste"));

Console.WriteLine("Retorna se termina com texto dado:");
Console.WriteLine(validacaoStrings.TextoTerminaCom(texto, "procurado"));

