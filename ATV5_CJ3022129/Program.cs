//Exercício 1
int n;
Console.WriteLine("Digite um número interio: \n");
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