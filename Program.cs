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


        //En C#, existen dos tipos de conversión:

        /*Conversión implícita (automáticamente): conversión de un tipo más pequeño a un tamaño de tipo más grande
        char-> int-> long-> float->double

        Conversión explícita (manualmente): convertir un tipo más grande en un tipo de tamaño más pequeño
        double-> float-> long-> int->char*/

        //Implicita

        int myInt = 92;
        double myDouble = myInt;      

        Console.WriteLine(myInt);      
        Console.WriteLine(myDouble);   

        //Explicita
        double myDouble2 = 9.78;
        int myInt2 = (int) myDouble2;    

        Console.WriteLine(myDouble2);   
        Console.WriteLine(myInt2);    


        int myInt3 = 10;
        double myDouble3 = 5.25;
        bool myBool3 = true;

        Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool3));   // convert bool to string  

        string myString = "Hello";
        Console.WriteLine(myString[0]);  // Outputs "H"

    }
  
}
