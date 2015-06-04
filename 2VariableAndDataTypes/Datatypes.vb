Module DataTypes

    Sub Main()
    
    
        'Variable declaration Without Assignment
        Dim i1 As Integer
        Dim name As String
        
        
        
        'Variable declarations with Assignment
        
        Dim int As Integer = 12         'integer
        Dim dble As Double = 4.5        'Double
        Dim str As String = "Brian"     'String
        Dim character As Char = "h"     'Character
        Dim booln As Boolean = False    'Boolean
        
        
        'Null variable declaration
        int = Nothing
        str = Nothing
        booln = Nothing
       
        'Calling a sub/Method
        MathOperators()


        'outputing variables
        Console.WriteLine(dble & " is a double Variable")
        'getting user Input As a specified Variable
        Dim name As String = Console.ReadLine()
        '


    End Sub
    


End Module
