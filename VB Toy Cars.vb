Imports System

Module Program
    Sub Main(args As String())
        'Setting the syntax as multiple different variables
        Dim hours As Integer
        Dim Train_Toy As Decimal
        Dim Sum1 As Decimal
        Dim Sum2 As Decimal
        Dim total As Decimal
        'Asks the user to input how many hours and trains were made/done
        Console.WriteLine("How many hours have you worked today?")
        hours = Console.ReadLine()
        Console.WriteLine("how many trains were made today?")
        'assinging the varible
        Train_Toy = Console.ReadLine()
        'calculations that should output the final result
        Sum1 = 9 * hours
        Sum2 = 0.6 * Train_Toy
        total = Sum1 + Sum2
        Console.WriteLine("You get paid this much" & "  " & total)
        Console.ReadLine()

    End Sub
End Module
