string nomeDigitado;
string sobrenome;
string nomeMaiusculas;
string nomeLeet;



// Console.WriteLine("Pressione uyma tecla para continuar...");
// Console.ReadKey(true);
// Comandos para leitura de mensagens

Console.Clear();



Console.Write("Nome.......: ");
nomeDigitado = Console.ReadLine()!;

nomeMaiusculas = nomeDigitado.ToUpper();
nomeLeet = nomeDigitado.Replace("A", "4");


Console.Write("Sobrenome..:");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Boa noite, {nomeMaiusculas} {sobrenome}!");
