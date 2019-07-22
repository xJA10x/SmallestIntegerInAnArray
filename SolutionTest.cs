/*********************************

SolutionTest class

*********************************/

using System;

public class SolutionTest {

  public static void Main(String[] args) {

    // Outputs empty line.
    Console.WriteLine("");
    // Outputs to the console.
    Console.WriteLine("#################### Running Program ######################");
    // Outputs empty line.
    Console.WriteLine("");

    // Builds object from the Solution class.
    // Constructor takes no parameters.
    Solution sObj = new Solution();

    // Initializes array.
    int[] A = {-6, -91, 1011, -100, 84, -22, 0, 1, 473};

    // Method call
    // using object name.
    // Takes one parameter.
    Console.WriteLine("Smallest integer: " + sObj.solution(A));

    // Outputs empty line.
    Console.WriteLine("");
    // Outputs to the console.
    Console.WriteLine("################### Exiting Program #########################");
    // Outputs empty line.
    Console.WriteLine("");

    // Allows user to enter any key to exit program.
    Console.ReadKey();

  }

}
