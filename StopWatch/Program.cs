
using System.Runtime.Intrinsics.Arm;

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Segundo");
    Console.WriteLine("M - Minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1)) ;
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
    Start(time * multiplier);
}

static void Start(int time)
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

