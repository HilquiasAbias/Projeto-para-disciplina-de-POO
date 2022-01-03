using System;

class Program {
  public static void Main (string[] args) {
    Cliente c = new Cliente(5, "705-778-004.42", "Hilquias", DateTime.Parse("2021-12-30"));

    Console.WriteLine(c);
  }
}

