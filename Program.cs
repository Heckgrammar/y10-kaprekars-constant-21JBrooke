namespace Y10_Challenge_Kaprikars_Constant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Programming_practice__Arrays__Array_Funtions__Casting
    {
        internal class Program
        {
            static void Main(string[] args)
            { //Kaprekar's Constant is 6174
              //1. take a 4 digit start number using at least two different digits...e.g. 9218
              //2. order the digits descending 4321, then ascending to get two 4 digit numbers (add leading zeros if needed)
              //3. subtract smaller number from bigger number e.g. 9821-1289=8532
              //4. Go back to step 2 replacing start number with result of step 3, repeat until numbers converge to 6174

                //Task: Write a program to compute Kaprekar's constant using any four digit start number
                //Ext: Display the number of iterations needed until 6174 is reached

                Console.WriteLine("Hello, Type a four digit number:"); //starter code for students
                int x = Convert.ToInt32(Console.ReadLine()); //starter for students
                string number = Convert.ToString(x);
                int[] x_digits = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    x_digits[i] = Convert.ToInt32(number.Substring(i, 1));
                }

                int counter = 0;
                
                while (x != 6174)
                {
                    counter = counter + 1;
                    number = Convert.ToString(x);

                    for (int i = 0; i < 4; i++)
                    {
                        x_digits[i] = Convert.ToInt32(number.Substring(i, 1));
                    }

                    int[] acending = x_digits;
                    int[] decending = x_digits;

                    string acendingOrder = SortAecend(acending);
                    string decendingOrder = SortDecend(decending);
                    x = Convert.ToInt32(decendingOrder) - Convert.ToInt32(acendingOrder);
                }
                Console.WriteLine(x);
                Console.WriteLine("that required " + counter + " iterations to converge to Kaprekar's Constant");





            }

            static string SortAecend(int[] acending)
            {
                bool anyswaps = true;
                while (anyswaps == true)//runs through the list repeatedly until no swaps are made
                {
                    anyswaps = false; //establishes that initially no swaps havebeen made
                    for (int i = 0; i < 3; i++)//runs through each pair in the list
                    {
                        if (acending[i] > acending[i + 1]) //checks if a swap is needed
                        {
                            anyswaps = true;//establishes that a swap will been made
                                            //swaps the two elements of the list
                            int temp = acending[i];
                            acending[i] = acending[i + 1];
                            acending[i + 1] = temp;
                        }
                    }

                }
                string acendingOutput = "";
                for (int i = 0; i < 4; i++)
                {
                    acendingOutput = acendingOutput + Convert.ToString(acending[i]);
                }
               
                return acendingOutput;
            }

            static string SortDecend(int[] acending)
            {
                bool anyswaps = true;
                while (anyswaps == true)//runs through the list repeatedly until no swaps are made
                {
                    anyswaps = false; //establishes that initially no swaps havebeen made
                    for (int i = 0; i < 3; i++)//runs through each pair in the list
                    {
                        if (acending[i] > acending[i + 1]) //checks if a swap is needed
                        {
                            anyswaps = true;//establishes that a swap will been made
                                            //swaps the two elements of the list
                            int temp = acending[i];
                            acending[i] = acending[i + 1];
                            acending[i + 1] = temp;
                        }
                    }

                }
                string acendingOutput = "";
                for (int i = 0; i < 4; i++)
                {
                    acendingOutput = Convert.ToString(acending[i] + acendingOutput);
                }
               
                return acendingOutput;
            }
        }
    }
}