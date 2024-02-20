// See https://aka.ms/new-console-template for more information
using System;


class HelloWord{

    static void Main(String[] arg){

        //Imprimir
        Console.WriteLine("Hello, World!"); 

        //C# tiene varios tipos de datos, el cual se le debe especificar el tipo de datos
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String
        
        Console.WriteLine(myLetter);

        //Constantes, esta va a permitir que cuando se defina una variable no se le pueda reasignar su valors
        const int ages = 15;
        //myNum = 20;
    }
  
}
