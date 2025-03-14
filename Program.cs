string nomeDigitado;
string sobrenome;
string nomeMaiusculas;


// Console.WriteLine("Pressione uyma tecla para continuar...");
// Console.ReadKey(true);
// Comandos para leitura de mensagens

Console.Clear();



Console.Write("Nome.......: ");
nomeDigitado = Console.ReadLine()!;

nomeMaiusculas = nomeDigitado.ToUpper();

Console.Write("Sobrenome..:");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Boa noite, {nomeMaiusculas} {sobrenome}!");
