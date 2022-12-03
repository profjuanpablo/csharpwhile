
int i = 1;
while (i<=10)
{
    Console.WriteLine($"o valor de i é: {i} - Me chamo: Juan");
    i +=1; //incremento(aumento em 1) do valor de i
}

Console.WriteLine(new string('-', 50));
int num = 1000;
while (num <=5000)
{
    Console.WriteLine("Num: " + num);
        num += 1000;
}
Console.WriteLine(new string('-', 50));


//crie um programa que receba o valor inicial e valor final de uma repetição
Console.Write("Digite o valor inicial: ");
int inicial = Convert.ToInt16(Console.ReadLine());

Console.Write("Digite o valor Final: ");
int final = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"O valor inicial informado foi: {inicial}");
Console.WriteLine($"O valor final informado foi: {final}");
while (inicial<=final)
{
    Console.WriteLine(inicial);
    inicial += 1;
}

Console.Write("Novo COnteúdo inserido no código");