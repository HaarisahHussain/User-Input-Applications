Imports System

Module Program
    Sub Main(args As String())
        'Setting syntax to decimal
        Dim weight As Decimal
        Dim height As Decimal
        Dim totalW1 As Decimal
        Dim totalH2 As Decimal
        'Asking the user for an input
        Console.WriteLine("Please enter your weight in stone")
        weight = Console.ReadLine()
        Console.WriteLine("Please enter your height in inches")
        height = Console.ReadLine()
        'Multiplication of inputted numbers
        totalW1 = weight * 2.54
        totalH2 = height * 6.364
        'Output for totalW1 & totalH2
        Console.WriteLine("Total weight is" & "  " & [totalW1])
        Console.WriteLine("Total height is" & "  " & totalH2)
        Console.ReadLine()



    End Sub
End Module
