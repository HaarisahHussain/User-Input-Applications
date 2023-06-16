Imports System

Module Program
    Sub Main(args As String())
        'setting syntax to decimal 
        Dim temp_fahrehnheight As Decimal
        Dim centigrade_form As Decimal
        'Asking user for input
        Console.WriteLine("Please enter the temperature in degrees F")
        temp_fahrehnheight = Console.ReadLine()
        'Input is inserted into the formula,where the output is then displayed 
        centigrade_form = (temp_fahrehnheight - 32) * (5 / 9)
        Console.WriteLine("Your temperature converted is" & "  " & centigrade_form)
        Console.ReadLine()





    End Sub
End Module
