using System;
using Fraction_operation; 

 namespace Program 
{ 
    class Main_Program 
    { 
        public static void Main(){ 
            Console.WriteLine("Enter the numerator : ");     
                    int numerator = Convert.ToInt32(Console.ReadLine());        
                         Console.WriteLine("Enter the denominator : ");    
                                  int denominator = Convert.ToInt32(Console.ReadLine()); 
              
            Fraction F = new Fraction(numerator,denominator); 
             
            Console.WriteLine($"Floating point division result = {F.FloatingDivision()}"); 
	         	F.IntegerDivison(); 
	         	F.ReduceFraction(); 
        } 
    } 
     
} 
