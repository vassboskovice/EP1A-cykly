Imports System

Module Program
  Sub Main(args As String())
    Dim cislo As Integer
    Dim soucet As Integer = 0

    Console.Write("Zadej ��slo: ")
    cislo = Console.ReadLine

    For i = 1 To cislo
      soucet = soucet + i
    Next

    Console.WriteLine($"Sou�et od 1 do {cislo} je {soucet}")

  End Sub
End Module
