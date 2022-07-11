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
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

        }




        //  Addition 
      public double addition(double result, string expression)
        {
           
         
            string[] array = expression.Split();
            double numLeft = Convert.ToDouble(array[0]);
            string sign = Convert.ToString(array[1]);
            double numRight = Convert.ToDouble(array[2]);
           
             result = 0;

            if (sign == "+")
            {
                result =  numLeft + numRight;
            }
           
            Console.WriteLine("The result is {0}", result);
            return result;
        }

        //  Subtraction
        public double subtraction(double result, string expression)
        {
          
           
            string[] array =  expression.Split(); ;
     
            double numLeft = Convert.ToDouble(array[0]);
            string sign = Convert.ToString(array[1]);
            double numRight = Convert.ToDouble(array[2]);

            result = 0;

            if (sign == "-")
            {
          
                result = numLeft - numRight;
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
                Console.WriteLine(num1 / num2);


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
            string expression= "";
                



                if (action == 1)
                {
                    Console.WriteLine("Write an expression with two numbers and an operator with space in between, for example, 4 + 2");
                    expression = Convert.ToString(Console.ReadLine());

                }
                else if (action == 2)
                {
                    Console.WriteLine("Write an expression with two numbers and an operator with space in between, for example, 4 - 2");
                    expression = Convert.ToString(Console.ReadLine());
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
                          
                            calcul.addition(result, expression);
                                                   
                            break;

                        }

                    case 2:
                        {
                            calcul.subtraction(result, expression);
                         
                            break;

                        }

                    case 3:
                        {
                        calcul.multiplication(num1, num2, result);

                            break;

                        }

                    case 4:
                        {
                        calcul.division(num1, num2, result);

                            break;

                        }

                    default:
                        Console.WriteLine("Wrong action!! try again");

                        break;

                }


                Console.WriteLine("Press any key to continue or prees e  then enter to Shut Down...");


            }

            while (Console.ReadKey().Key != ConsoleKey.E);
            Console.ReadLine();

        

        
            }


        }


}
