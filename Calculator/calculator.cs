using System;
using System.Linq;
using System.Collections.Generic;


namespace CSharpShell;

public class Calculator
{
	static void Main(string[] args)
	{

		bool run = false;
		while (!run)
		{
			Console.WriteLine("Press (C) if you want to calculate and press (Q) to quit.:");
			string toDo = Console.ReadLine().ToUpper();
			
			if (toDo == "Q") {	
				break;
			
			}
			else if (toDo == "C") {	

				Console.WriteLine("Enter the 1st number:");
				string firstNum = Console.ReadLine();
				Console.WriteLine("Enter the 2nd number:");
				string secondNum = Console.ReadLine();
				Console.WriteLine("Enter the 3rd number:");
				string thirdNum = Console.ReadLine();
				Console.WriteLine("Enter the 4rth number:");
				string fourthNum = Console.ReadLine();
				Console.WriteLine("Enter the 5th number:");
				string fifthNum = Console.ReadLine();
				
				try {
					double Num1 = Double.Parse(firstNum);
					double Num2 = Double.Parse(secondNum);
					double Num3 = Double.Parse(thirdNum);
					double Num4 = Double.Parse(fourthNum);
					double Num5 = Double.Parse(fifthNum);
				
					double[] realNums = {Num1,Num2,Num3,Num4,Num5};
					
					while (true) {
						
						Console.WriteLine("Press (S) to get the Sum of real numbers, press (A) to the average, press (P) to get the product, press (SS) to get the sum of square, and press (Q) to quit.:");
						string calculate = Console.ReadLine().ToLower();
						
						if (calculate == "q") {
							break;
						}
						else if (calculate == "s") {
							double sum = realNums.Sum();
							
							Console.WriteLine($"Sum is {sum}.");
						}
						else if (calculate == "a") {
							
							int realNumsAmount = realNums.Length;
							
							double average = realNums.Sum() / realNumsAmount;
							Console.WriteLine($"Average is {average}.");
						
						}
						else if (calculate == "p") {
							
							double product = Num1 * Num2 * Num3 * Num4 * Num5;
							Console.WriteLine($"Product is {product}");
						
						}
						else if (calculate == "ss") {
						
							List<double> squares = new List<double>();
							
							foreach (double number in realNums) {
								squares.Add(number*number);
							}
							double sumOfSquares = squares.Sum();
							
							Console.WriteLine($"Sum of Squares is {sumOfSquares}.");
						}
						
					}
				}
				catch {
					Console.WriteLine("Invalid character! please enter an integer");
				}
				finally {
					Console.WriteLine("Thank you!\n");
				}
				
			}
			else {
				
				continue;
			}
		}

	}

}
