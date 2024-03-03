// See https://aka.ms/new-console-template for more information
using System;


class HelloWord{

    static void Main(String[] arg){

        //Imprimir
      /*  Console.WriteLine("Hello, World!"); 

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

       /* int myInt = 92;
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


        //Bucles
        int i = 0;
        while (i < 5) 
        {
        Console.WriteLine(i);
        i++;
        }

        for (int i2 = 0; i2 < 5; i2++) 
        {
        Console.WriteLine(i2);
        }

        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i3 in cars) 
        {
        Console.WriteLine(i3);
        }


        for (int i4 = 0; i4 < 10; i4++) 
        {
        if (i4 == 4) 
        {
            break;
        }
        Console.WriteLine(i4);
        }

        int[] myArray2 = { 1, 2, 3, 4, 5 };

        string[] cars2 = {"Volvo", "BMW", "Ford", "Mazda"};
        for (int i4 = 0; i4 < cars.Length; i++) 
        {
        Console.WriteLine(cars[i]);
        }

        string[] cars5 = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i5 in cars) 
        {
        Console.WriteLine(i5);
        }


        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
        numbers[0, 0] = 5;  // Change value to 5
        Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

        try
        {
            // código que puede lanzar una excepción
        }
        catch (Exception ex)
        {
            // código para manejar la excepción
        }*/

          //Instanciamos la clase de ejercicios basicos
          Ejercicios miInstancia = new Ejercicios(); 
          miInstancia.EjerciciosBasicos();

    }
  
}


//Instanciamos la clase
var sale = new Sale(15);
var menssage = sale.GetInfo();

Console.WriteLine(menssage);
class Sale
{
    public decimal Total { get; set; }


    //_Sirve para variables privadass
    private decimal _some;

    //El contructor nos va a permitir que cuando se instancie la clase se pueda definir valores requeridos
    public Sale(decimal total)
    {
        Total = total;
    }


    public string GetInfo()
    {
        return "El total es" + Total;
    }
}
