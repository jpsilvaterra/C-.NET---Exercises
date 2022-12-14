using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine("Percorrendo o Array com o FOR");
for(int contador = 0; contador < listaString.Count; contador++) //count - length, retorna a quant de elementos
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N° {cotadorForeach} - {item}");
    contadorForeach ++;
}