using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition

{

    class Addition

    {

        static void Main()

        {

            int? number1 = null; //declare number 1 as an int? so that we can set it to null for while loop

            int? number2 = null; //declare number 2 as an int? so that we can set it to null for while loop

            int? sum = null; // declare sum of number1 and number2 as an int? so that we can set it to null for while loop





            while (sum == null) //while loop that will keep going until sum is no longer null, meaning that the user has entered integer values for number1 and number2

            {

                while (number1 == null)  //while loop that will keep going until number1 is no longer null, meaning that the user has entered an integer rather than a decimal or character

                {

                    Console.Write("Enter first integer: "); //prompt user

                    //read first number from user

                    if (!int.TryParse(Console.ReadLine(), out int input1)) //check whether the first input is an integer and assign it as int input1

                    {

                        Console.WriteLine("The first input is not an integer"); //let user know that the first input is not an integer and go back to asking for a first integer

                    }

                    else

                    {

                        number1 = input1; //set input1 equal to number2 so number1 is no longer null to leave while loop

                    }

                }

                while (number2 == null) //while loop that will keep going until number2 is no longer null, meaning that the user has entered an integer rather than a decimal or character

                {

                    Console.Write("Enter second integer: "); //prompt user

                    //read first number from user

                    if (!int.TryParse(Console.ReadLine(), out int input2)) //check whether the first input is an integer and assign it as int input2

                    {

                        Console.WriteLine("The second input is not an integer"); //let user know that the second input is not an integer and go back to asking for a second integer

                    }

                    else

                    {

                        number2 = input2; //set input2 equal to number2 so number2 is no longer null to leave while loop

                    }

                }

                sum = number1 + number2; //add numbers

            }

            Console.WriteLine(sum); //print out sum

        }

    }

}

