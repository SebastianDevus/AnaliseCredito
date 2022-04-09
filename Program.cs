double rendaMensal, valorEmprestimo, valorParcela;
int parcelas;

// Espacamento
Console.WriteLine();

Console.WriteLine("--------Empréstimo--------");

// Espacamento
Console.WriteLine();


Console.Write("Insira o valor do empréstimo (R$)..: ");
valorEmprestimo = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira a quantidade de parcelas....: ");
parcelas = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira a sua renda mensal (R$).....: ");
rendaMensal = Convert.ToDouble(Console.ReadLine());


valorParcela = valorEmprestimo / parcelas;


// Espacamento
Console.WriteLine();


if (valorParcela > (rendaMensal * 30) / 100)
{
    // Só será executado se a parcela do empréstimo for muito alta
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Empréstimo não autorizado.");
    Console.WriteLine("A parcela do empréstimo é muito alta.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Empréstimo autorizado.");
}

Console.ResetColor();

// Espacamento
Console.WriteLine();