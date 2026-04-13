//Inicio de tudo
Console.WriteLine("Hello, World!\n");
Console.WriteLine("Classes, Objetos, Construtores e Sintaxe\n");
//---------------------------------------
Console.WriteLine("Olá a todos, esse é o inicio de minha Habituação com a linguagem C#," +
    " nome engraçado até, vamos ver do que ela é capaz.\n");
//---------------------------------------
Console.WriteLine("Vamos começar com o básico, a sintaxe, que é a forma como escrevemos o código para que ele seja compreendido pelo computador." +
    " Em C#, a sintaxe é baseada em blocos de código delimitados por chaves {}. \n" +
    "Cada bloco de código pode conter declarações de variáveis, instruções e outras estruturas de controle.\n");
//---------------------------------------
Console.WriteLine("Maravilha, nosso print seria o comando Console.WriteLine() \n");
Console.WriteLine("Ao menos podemos deixar linhas em branco, diferente do Python\n");
//Declaração de Variáveis
//Nome do tipo string, que é uma sequência de caracteres, ou seja, texto. 
Console.WriteLine("Vamos escrever um código simples de um problema que preciso resolver, segue o enunciado:\n");
Console.WriteLine("Você deve ler 3 notas do aluno, calcular\r\na média e exibir o status final.\n");

//nota1 = float.Parse(Console.ReadLine());
//nota2 = float.Parse(Console.ReadLine());
//nota3 = float.Parse(Console.ReadLine());
//eu particularmente achei muito estranho ter que usar o float.Parse() para converter a entrada do usuário, mas tudo bem, é uma forma de garantir que o valor seja do tipo correto.
//porém eu li a documentação e li sobre uma forma mais segura de fazer isso , usando o float.TryParse(), que retorna um booleano indicando se a conversão foi bem-sucedida ou não, e armazena o valor convertido em uma variável de saída
Console.WriteLine("============================================");
Console.WriteLine("      SISTEMA DE VERIFICAÇÃO DE MÉDIA");
Console.WriteLine("============================================");
Console.WriteLine("Problema:");
Console.WriteLine("Você deve ler 3 notas do aluno, calcular");
Console.WriteLine("a média e exibir o status final.");
Console.WriteLine("Regras:");
Console.WriteLine("- Média >= 7,0  → Aprovado");
Console.WriteLine("- Média >= 5,0  → Recuperação");
Console.WriteLine("- Média <  5,0  → Reprovado");
Console.WriteLine("--------------------------------------------");
//Declaração das variáveis para armazenar as notas do aluno
double nota1;
double nota2;
double nota3;
//Leitura das notas do aluno com validação de entrada usando o método TryParse para garantir que o valor seja numérico e esteja dentro do intervalo permitido (0-10)
Console.Write("Digite a nota 1: ");
// Loop que repete enquanto o valor for inválido (não numérico ou fora do intervalo 0-10)
while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 10)
    Console.Write("Nota inválida! Digite um valor entre 0 e 10: "); // Mensagem de erro

Console.Write("Digite a nota 2: ");
// Loop que repete enquanto o valor for inválido (não numérico ou fora do intervalo 0-10)
while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 10)
    Console.Write("Nota inválida! Digite um valor entre 0 e 10: "); // Mensagem de erro

Console.Write("Digite a nota 3: ");
// Loop que repete enquanto o valor for inválido (não numérico ou fora do intervalo 0-10)
while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 10)
    Console.Write("Nota inválida! Digite um valor entre 0 e 10: "); // Mensagem de erro


//Cálculo da média das notas
double media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine("--------------------------------------------");
Console.WriteLine($"Média: {media}");
//Determinação do status do aluno com base na média usando o operador ternário
String status = media >= 7.0 ? "Aprovado" : media >= 5.0 ? "Recuperação" : "Reprovado";
//Exibição do status final do aluno
Console.WriteLine($"Status: {status}");
Console.WriteLine("============================================");

//Beleza, conseguimos resolver o problema usando a sintaxe básica do C#, com leitura de entrada, validação, cálculo e exibição de resultados. Agora podemos avançar para conceitos mais avançados como classes, objetos e construtores!
//Amanhã continuaremos nossa jornada de aprendizado em C#, explorando esses conceitos fundamentais para a programação orientada a objetos. Até lá!