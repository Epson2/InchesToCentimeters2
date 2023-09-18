using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter measurement in inches: ");
    var x = Convert.ToInt16(Console.ReadLine());
    var y = 2.54;

    //Console.WriteLine("{0} * {1} = {2}", x, y,(x * y));
    Console.WriteLine("{0} inches is {2} centimeters", x, y, (x * y));
  }
}