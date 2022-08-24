//EXERCÍCIOS ❤ LOVED// 

// 1 – Elabore um algoritmo que calcule a idade média de 5 alunos.
 Double media=0;
 Double idade1=0;
 Double idade2=0;
 Double idade3=0;
 Double idade4=0;
 Double idade5=0;
 Console.WriteLine("Programa que calcula a idade media de cinco alunos");
 Console.Write("Informe a idade do 1° alunos : ");
 idade1 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Informe a idade do 2° alunos : ");
 idade2 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Informe a idade do 3° alunos : ");
 idade3 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Informe a idade do 4° alunos : ");
 idade4 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Informe a idade do 5° alunos : ");
 idade5 = Convert.ToDouble(Console.ReadLine());
 media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
 Console.WriteLine("A ídade média dos alunos é " + media);
 Console.ReadKey();

//2 – Crie um algoritmo que verifique se um número informado é par ou impar
 int n = 0;
 int r = 0;
 Console.WriteLine("Determina se o número é par ou impar");
 Console.Write("Informe um número: ");
 n = Convert.ToInt32(Console.ReadLine());
 r = n % 2;
 if (r == 1)
 {
 Console.WriteLine("O número informado é impar");
 }
 else
 {
 Console.WriteLine("O número informado é par");
 }
 Console.ReadKey();


// 3 – Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
 int qtde = 0;
 int idade = 0;
 Console.WriteLine("Exercício 2 - Verifica maior idade");
 int i = 0;
 while (i < 10)
 {
 i = i + 1;
 Console.Write("Informe a idade da pessoa: ");
 idade = Convert.ToInt32(Console.ReadLine());
 if (idade >= 18)
 {
 qtde = qtde + 1;
 }
 }
 Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
 Console.ReadKey();


//4 – Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
 Double salario = 0;
 Double salarioNovo = 0;
 Console.WriteLine("Efetua o reajuste salarial");
 for (int i = 0; i < 3; i++)
 {
 Console.Write("Informe o salário: ");
 salario = Convert.ToDouble(Console.ReadLine());
 if (salario <= 300)
 { //50%
 salarioNovo = salario * 1.50;
 }
 else
 { //30%
 salarioNovo = salario + ((salario * 30) / 100);
 }
 Console.WriteLine("Salário reajustado: " + salarioNovo);
 }
 Console.ReadKey();

//5 – Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a matricula do aluno mais alto e do aluno mais baixo.
 String maMatricula;
 Double maAltura;

 String meMatricula;
 Double meAltura;

 String Matricula;
 Double Altura;

 Console.WriteLine("Determina o maior aluno e o menor aluno");
 Console.Write("Informe a matricula do aluno: ");
 Matricula = Console.ReadLine();
 Console.Write("Informe a altura do aluno: ");
 Altura = Convert.ToDouble(Console.ReadLine());

 maAltura = Altura;
 meAltura = Altura;
 maMatricula = Matricula;
 meMatricula = Matricula;
 int i = 1;
 while (i < 5)
 {
 Console.Write("Informe a matricula do aluno: ");
 Matricula = Console.ReadLine();
 Console.Write("Informe a altura do aluno: ");
 Altura = Convert.ToDouble(Console.ReadLine());
 if(maAltura < Altura)
 {
 maMatricula = Matricula;
 maAltura = Altura;
 }

 if (meAltura > Altura)
 {
 meMatricula = Matricula;
 meAltura = Altura;
 }
 i++;
 }
 Console.WriteLine("Maior aluno");
 Console.WriteLine("Matricula: {0}, Altura: {1}", maMatricula, maAltura);
 Console.WriteLine("Menor aluno");
 Console.WriteLine("Matricula: {0}, Altura: {1}", meMatricula, meAltura);
 Console.ReadKey();
