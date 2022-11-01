using System.Diagnostics.Metrics;

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Deseja contar de zero ou a partir de um número?");
    Console.WriteLine("1 - A partir de um número");
    Console.WriteLine("2 - A partir de zero");
    Console.WriteLine("0 - Sair");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 0:
            System.Environment.Exit(0);
            break;
        case 1:
            FromNumberCounter();
            break;
        case 2: 
            FromZeroCounter();
            break;
        
        default:
            Console.WriteLine("Por favor escolha uma opção válida");
            break;
    }
    
}

static void FromNumberCounter()
{
    Console.Clear();
    Console.WriteLine("Digite o tempo que quer contar no seguinte formato: 10s (10 segundos) / 10m (10 minutos)");
    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;
    if (type == 'm')
    {
        multiplier = 60;
    }

    if (time == 0)
    {
        System.Environment.Exit(0);
    }

    ReverseCountStart(time * multiplier);
}

static void ReverseCountStart(int time)
{
    int currentTime = time;

    while (currentTime != 0)
    {
        Console.Clear();
        currentTime--;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado, retornando para o menu");
    Thread.Sleep(2500);
    Menu();
}

static void FromZeroCounter()
{
    Console.Clear();
    Console.WriteLine("Digite o tempo que quer contar no seguinte formato: 10s (10 segundos) / 10m (10 minutos)");
    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;
    if (type == 'm')
    {
        multiplier = 60;
    }

    if (time == 0)
    {
        System.Environment.Exit(0);
    }

    CountStart(time * multiplier);
}

static void CountStart(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado, retornando para o menu");
    Thread.Sleep(2500);
    Menu();
}


Menu();