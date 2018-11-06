//O random é um gerador de numeros, pseudo aleatorio.
//Ele precisa de alguns acompanhamentos.
//Nesse exemplo irei usar o next, que cria numeros aleatorios.
 

// 1# Dentro da sua classe principal você instancia o random.
Random (Nome qualquer) = new Random();


// 2# Em seguida você cria um array, sendo 'n' o tamanho do array.
int[] (Nome do array) = new Int[n];


// 3# Depois você chama o next dentro do random, para criar os numeros aleatorios.
// Sendo 'min' o menor numero e 'max' o maior numero.
random.Next(min, max);
// OBS: Para salver esses numeros gerados dentro de uma variavel e manda-los para
// Dentro do array, continue lendo.


// 4# Agora você cria um 'for' para salvar os numeros aleatorios dentro do vetor.
// Explicando o for: Cria int i, define i = 0, enquanto i for menor que o tamanho do vetor.
// Faça i++ que seria i + i.
for (int i = 0; i < (tamanho do vetor); i++)
{
  
}


// 5# Dentro do 'for' você define o valor do array.
// Primeiro você define uma variavel pros numeros aleatorios criados.
// Em seguida chama o vetor e no lugar do indice coloca 'i'
// Depois você define o valor da posição desse vetor, igual ao numero aleatorio.
int (nome qualquer pros numeros aleatorios) = random.Next(min, max);
(nome do vetor)[i] = (nome da variavel criada acima);


// Pronto, você definiu numeros aleatorios para um vetor.
// Caso queira escreve-los acrescente 'Console.WriteLine((nome do vetor)[i])'
// No final do for (Mas ainda dentro dele).



// EXEMPLO

public void RandomNumeros()
{

  Random random = new Random();
  
  int[] array = new int[10];
  
  for (int i = 0; i < 10; i++)
  {
    int randons = random.Next(0, 10);
    array[i] = randons;
    Console.Write(vetor[i]);
  }
  
}
