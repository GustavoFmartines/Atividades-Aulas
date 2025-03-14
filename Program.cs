string nome;
string sobrenome;

// Console.WriteLine("Pressione uyma tecla para continuar...");
// Console.ReadKey(true);
// Comandos para leitura de mensagens

Console.Clear();

Console.Write("Nome.......: ");
nome = Console.ReadLine()!;

Console.Write("Sobrenome..:");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Boa noite, {nome} {sobrenome}!");
