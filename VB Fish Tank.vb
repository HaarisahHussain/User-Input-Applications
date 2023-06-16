Imports System

Module Program
    Sub Main(args As String())
        'Assining syntax of every variable to decimal
        Dim length As Decimal
        Dim depth As Decimal
        Dim height As Decimal
        Dim Total_Vol
        Dim UK_Gallons As Decimal
        'Asking the user to input the length, depth & height
        Console.WriteLine("Please enter the length in cm")
        length = Console.ReadLine()
        Console.WriteLine("Please enter the depth in cm")
        depth = Console.ReadLine()
        Console.WriteLine("Please enter the height in cm")
        'Assinging the variable to the text
        height = Console.ReadLine()
        'Calculation to find the total volume
        Total_Vol = length * depth * height / 1000
        'Calculation to find Uk gallons from voulme 
        UK_Gallons = Total_Vol / 4.546
        'Outputs the answer from the calculations
        Console.WriteLine("Your volume is" & "  " & Total_Vol)
        Console.WriteLine("Youe gallons are" & "  " & UK_Gallons)
        Console.ReadLine()
                          


    End Sub
End Module
