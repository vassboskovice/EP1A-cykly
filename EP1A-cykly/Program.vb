Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer

    For i = 1 To 5
      Console.Write("Zadej ��slo: ")
      cislo = Console.ReadLine
      Console.WriteLine($"{i}. zadan� ��slo je {cislo}")
    Next

  End Sub
End Module
