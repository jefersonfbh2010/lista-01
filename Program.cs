Console.WriteLine("solicitar nota do estudante:");
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

if (variavelQueSalvaUmNumero >= 7) 
{
    Console.Write("aprovado");
}
else if (variavelQueSalvaUmNumero >= 5 && variavelQueSalvaUmNumero <= 6) 
{
    Console.Write("recuperação");
}
else if (variavelQueSalvaUmNumero < 5) 
{
    Console.Write("reprovado");
}