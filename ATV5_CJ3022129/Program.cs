using System;
using System.Linq;

namespace ATV5_CJ3022129;

public static class Program
{
	public static void Main()
	{

		

int n;

Console.WriteLine("Digite um número inteiro: \n");

n = int.Parse(Console.ReadLine()); 

for (int a = 0; a < n; a++)

{

    

    Console.WriteLine(a);

}

//Exercício 2

int n1;

Console.WriteLine("Digite um número inteiro: \n");

n1 = int.Parse(Console.ReadLine());

for (int a = 0; a <= n1; a++)

{

        if (a % 2 == 0)

    {

        Console.WriteLine(a);

    }

}

//Exercício 3

int z;

Console.WriteLine("Digite um número inteiro: \n");

    z = int.Parse(Console.ReadLine());

 if (z < 1000)

{

    for (int a = 0; a <= z; a++){

        if (a %2 ==0)

        {

            Console.WriteLine(a);

        }

    }

}

//Exercício 4

int n2 = 0;

for (int i = 0; n2 < 200; i++)

{

    Console.WriteLine("Digite um valor");

     int n3 = int.Parse(Console.ReadLine());

       if (n3 >0)

    {

       Console.WriteLine(n3);

        n2 += n3;

    }

    Console.WriteLine("A soma dos números é {0}", n2);

}

//exercício 5
		Console.WriteLine("Digite um número inteiro:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Os divisores de " + numero + " são:");

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
	

//exercício 6

int maior;
int menor;

        Console.WriteLine("Digite o 1º número: ");
        int numero1 = int.Parse(Console.ReadLine());
        maior = numero1;
        menor = numero1;

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine($"Digite o {i}° número: ");
            numero1 = int.Parse(Console.ReadLine());

            if (numero1 > maior)
            {
                maior = numero1;
            }

            if (numero1 < menor)
            {
                menor = numero1;
            }
        }

        Console.WriteLine($"O maior número digitado foi: {maior}");
		
		
        Console.WriteLine($"O menor número digitado foi: {menor}\n");
		
//exercício 7

int somaPares = 0;
        int somaImpares = 0;

        Console.WriteLine("Digite uma sequência de números (digite 0 para parar):");

        while (true)
        {
            Console.Write("Digite um número: ");
            int n9 = Convert.ToInt32(Console.ReadLine());

            if (n9 == 0)
            {
                break; //
            }

            if (n9 % 2 == 0)
            {
                somaPares += n9;
				}
            
            else
            {
                somaImpares += n9; 
            }
        }

        Console.WriteLine($"A soma dos números pares é: {somaPares}");
        Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");		
}
}
