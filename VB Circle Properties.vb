Imports System

Module Program
    Sub Main(args As String())
        'setting the syntax to decimals & integers 
        Dim area_Circle As Decimal
        Dim circumference_Circle As Decimal
        Dim arc_length As Decimal
        Dim Diameter As Integer
        Dim Radius As Integer
        Dim Arc_Angle As Integer
        'asking the user to input text which will output a answer
        Console.WriteLine("Please enter the diameter of the circle to the nearest whole number")
        'setting the variable
        Diameter = Console.ReadLine()
        Console.WriteLine("Please enter the Arc Angle of the circle to the nearest whole number")
        Arc_Angle = Console.ReadLine()
        'Caculations which will be outputted onto the users screen, depending on what number is inputted
        Radius = Diameter / 2
        Console.WriteLine("The radius is" & "  " & Radius)
        area_Circle = 3.14 * Radius ^ 2
        Console.WriteLine("The area circle is" & "   " & area_Circle)
        circumference_Circle = 3.14 * Diameter
        Console.WriteLine("The circumference is" & " " & circumference_Circle)
        arc_length = circumference_Circle * Arc_Angle / 360
        Console.WriteLine("The arc length is" & "    " & arc_length)
        Console.ReadLine()











    End Sub
End Module
