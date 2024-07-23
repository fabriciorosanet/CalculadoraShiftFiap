double n1, n2, res;
Console.WriteLine("Digite o primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digitte o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());

res = n1+n2;
Console.WriteLine("Soma: {0}", res.ToString());

res = n1 - n2;
Console.WriteLine("Subtração: {0}", res);

res = n1 * n2;
Console.WriteLine("Multiplicação: {0}", res);

if (n2 != 0)
{
    res = n1 / n2;
    Console.WriteLine("Divisão: {0}", res);
}
else
{
    Console.WriteLine("Divisão: Não é possível dividir por zero.");
}