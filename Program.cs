/* 
Conceitos básicos de C# 
Write: escreve algo
WriteLine: escreve algo e pula uma linha
Read: ler  
ReadLine: ler uma linha 

*/
    
    static void Menu(){
        
        Console.Clear(); 

        Console.WriteLine("Seja bem vindo, o que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");
        
        Console.WriteLine("---------------");
        Console.WriteLine("Selecione uma opção: "); 
        short res = short.Parse(Console.ReadLine());

        //Utilizando switch para chamar os comandos

        switch(res){
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break; 
            case 5: Exit(); break;
            default: Error(); break; 
        }
    
    }

    static void Soma(){
    
        //Para limpar a tela; 
        Console.Clear(); 

         // Iniciando o programa - pedindo primeiro valor para usuário e realizando conversao para string com Parse
        Console.WriteLine("Digite o primeiro valor: "); 
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Digite o segundo valor: "); 
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        // Imprimindo resultado
        Console.WriteLine("");
        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey(); 

        /* 
        Outra maneiras de imprimir os resultados na tela: 
        Console.WriteLine($"O resultado da soma é: {resultado}"); 
        Console.WriteLine($"O resultado da soma é: {v1 + v2}"); 
        Console.WriteLine("O resultado da soma é: " + (v1 + v2)); 
        */

        // Chamando o menu novamente para um novo cálculo;
        Menu();


    }

    static void Subtracao(){
        
        Console.Clear(); 

        Console.WriteLine("Digite o primeiro valor: "); 
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        Console.WriteLine("Digite o segundo valor: "); 
        float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é: {resultado}"); 
        Console.ReadKey(); 

        Menu();

    }

    static void Divisao(){

        Console.Clear(); 

        Console.WriteLine("Digite o primeiro valor: "); 
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        Console.WriteLine("Digite o segundo valor: "); 
        float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão é: {resultado}"); 
        Console.ReadKey(); 

        Menu();

    }

    static void Multiplicacao(){

        Console.Clear(); 

        Console.WriteLine("Digite o primeiro valor: "); 
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        Console.WriteLine("Digite o segundo valor: "); 
        float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação é: {resultado}"); 
        Console.ReadKey(); 

        Menu();


    }

    static void Exit(){

        Console.Clear(); 
        
        Console.WriteLine("Obrigado pela preferência.");
    }

    static void Error(){
        Console.Clear();

        Console.WriteLine("Comando inválido, selecione uma opção válida.");
        Console.ReadKey(); 
        Menu();
    }
   
    Menu();

