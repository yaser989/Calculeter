using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class Calcul
    {

        public void info()
        {

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Array Addition");
            Console.WriteLine("Press 4 for Array Subtraction");
            Console.WriteLine("Press 5 for Multiplication");
            Console.WriteLine("Press 6 for Division \n");

        }


        //  Addition 
        public double addition(double num1, double num2, double result)
        {
            result = num1 + num2;
            Console.WriteLine("The result is {0}", result);
            return result;
        }




      public double addition(double [] input, double result)
        {
            result = 0;

            foreach (double i in input)
            {
                result += i;
            }
           
           
            Console.WriteLine("The result is {0}", result);
            return result;
        }

        //  Subtraction
        public double subtraction(double num1, double num2, double result)
        {
            result = num1 - num2;
            Console.WriteLine("The result is {0}", result);
            return result;
        }




        public double subtraction(double[] input, double result)
        {
            result = 0;

            foreach (double i in input)
            {
               
                if(i > result)
                {
                    result = i;
                }
                else
                {
                    result -= i;
                }

                  
            
               
            }


            Console.WriteLine("The result is {0}", result);
            return result;
        }

        //  Multiplication
        public double multiplication(double num1, double num2, double result)
    {

        result = num1 * num2;
        Console.WriteLine("The result is {0}", result);
        return result;

    }

    // Division
    public double division(double num1, double num2, double result)
    {

        try
        {
            result = num1 / num2;
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Division is not accepted by zero ");

            }

            else
            {
                Console.WriteLine("The result is {0}", num1 / num2);
                    

                }
        }
        catch (Exception ex)
        {
            string message = "Division is not accepted by zero ";

            Console.WriteLine(message);
          
        }
        return result;
    }


        public static void calculeter()
        {
          
            
            Calcul calcul = new Calcul();

            do
            {
            calcul.info();

           int action = Convert.ToInt32(Console.ReadLine());
        

            double num1 = 0;
            double num2 = 0;
            double result = 0;

             double[] input = new double[4];

              

                if (action == 3 || action == 4 )
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] = Convert.ToInt32(Console.ReadLine());
                    }


                }
                else if (action > 6)
                {
                     Console.WriteLine("Wrong action!! try again");
                }
                else
                {
                    Console.WriteLine("Enter 1st num");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter 2nd num");
                    num2 = Convert.ToDouble(Console.ReadLine());
                   

                }




                switch (action)
                {

                    case 1:
                        {
                  
                            
                            calcul.addition(num1,  num2,  result);
                           
                            break;

                        }

                    case 2:
                        {
                            calcul.subtraction(num1, num2, result);       
                            break;

                        }
                    case 3:
                        {


                            calcul.addition(input, result);

                            break;

                        }

                    case 4:
                        {
                            calcul.subtraction(input, result);
                            break;

                        }

                    case 5:
                        {

                        calcul.multiplication(num1, num2, result);
                            break;

                        }

                    case 6:
                        {

                        calcul.division(num1, num2, result);
                            break;

                        }
                }


                Console.WriteLine("Press any key to continue or prees e  then enter to Shut Down...");


            }

            while (Console.ReadKey().Key != ConsoleKey.E);
            Console.ReadLine();

        

        
            }


        }


}
