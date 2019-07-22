/**************************************

Solution class

**************************************/

using System;

public class Solution {

  // Builds method.
  // Takes one parameter,
  // array A in the main class.
  public int solution(int[] A) {

    var presence = new bool[A.Length + 1];

    // Builds foreach loop.
    foreach(var value in A) {

      // Builds if statement.
      if (value > 0 && value < presence.Length) {

        presence[value] = true;

      }

      // Builds for loop.
      for(int i = 1; i < presence.Length; i++) {

          // Builds if statement.
          if(!presence[i]) {

            return i;

          }


      }

    }

    // Returns smallest integer in the array.
    return presence.Length;

  }

}
