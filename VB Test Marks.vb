Imports System

Module Program
    Sub Main(args As String())
        'Setting Syntax to accept integers 
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim total As Integer
        'User inputs a answer to the question
        Console.WriteLine("Please enter your first test score out of 100")
        'Assining a variable 
        num1 = Console.ReadLine()
        Console.WriteLine("Please enter your second test score out of 100")
        num2 = Console.ReadLine
        Console.WriteLine("Please enter your third test score out of 100")
        num3 = Console.ReadLine()
        'Addition to get total score and average
        total = num1 + num2 + num3 / 3
        Console.WriteLine("Your total test marks are" & "   " & total)
        Console.ReadLine()


    End Sub
End Module
