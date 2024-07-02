using System;

class Program {
  public static void Main (string[] args) {
    //write here
    string input = Console.ReadLine();
    for(int i = 0; i<3 ; i++ )
    {
      string temp = input.Substring(input.IndexOf("."));
      Console.WriteLine(temp);
      
    }
  }
}