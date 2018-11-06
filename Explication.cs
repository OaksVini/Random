//Random is a pseudo-random generator.
//It need any complements.
//This test I'll use the 'next', that create random numbers.
 

// 1# In your class you need instance the random.
Random (Name) = new Random();


// 2# Next, you create a array, being 'n' the size of array.
int[] (Name) = new Int[n];


// 3# Next you call the next, inside of random, for create random numbers.
// Being 'min' the smaller number and 'max' the biggest.
random.Next(min, max);
// P.S.: To salve this numbers generated, you need of a variable.
// after you need save they in a array.
// Continue reading to know this.


// 4# Now you create a 'for' to save the random numbers, inside a array.
// Explain the for: Create int i, i = 0, if i is small than the vetor size
// do i++, that was i + i
for (int i = 0; i < (Size of vetor); i++)
{
  
}


// #5 Inside of the 'for' you define the value of array.
// First you need a variable for the random numbers createds.
// Next you call the array and in the place of indice you place 'i'
// Next you define the value of position this array, equals random number
int (Name) = random.Next(min, max);
(Name of vetor)[i] = (Name of the variable upper);



// Rigt, you created random numbers for a vetor.
// If you want to write, place 'Console.WriteLine( (Name of vetor)[i] );
// In the end of the for (Inside the for).


// EXAMPLE

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
