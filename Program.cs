// See https://aka.ms/new-console-template for more information
using System;

class Program
{      
 
 static void loop(int nr){ /* static (don't worry about it), void means the method does not return a value, loop is the name*/
        /* int nr, means we import a value (from the code that jumps here), and calls it nr, this is the number of loops we will execute */
        int sum = 0; /* the running sum to calculate */
        for (int i = 0; i < nr; i++)
        { /* For 0 to 'nr' (couting with the variable i) (i++ -> increment i by one) */
                Console.WriteLine($"i = {i}"); /* Print "i = x" and replace x by the value of i */
                if((i % 2) == 1) { /* Only executes when i is odd */
                        sum = sum + i; /* update the sum with the value of i, but only if i is odd */
                }
                Console.WriteLine($"sum = {sum}"); /* same as i = x, but with sum */
                if(sum == 3){ /* Execute the code below when sum equals 3 */
                        Console.WriteLine("We have now the magical sum of 3");
                }
               
        }
 }
 static void Main()
    {
        Console.WriteLine("Program begin");
        loop(11); /* Execute the loop-method with 11 as the parameter (named nr in the method) */
        Console.WriteLine("Program ends");
    }
}
 
 