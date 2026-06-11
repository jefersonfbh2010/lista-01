Console.Write("Informe a idade do visitante: ");

int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

if (variavelQueSalvaUmNumero >= 16)
{
    Console.WriteLine("Entrada liberada.");
}
else
{
    Console.WriteLine("Entrada permitida somente com responsável.");
}

Console.WriteLine ("solicitar nota do aluno")