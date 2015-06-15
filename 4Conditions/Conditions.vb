Module Conditions

    Sub Main()
    
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
        ' 1. If Statements		
        Dim isTrue As Boolean = False
        Dim name As String = "Brian"

        If isTrue Then
             DoSomething() 				                        'Code to be executed if Condition is true
        ElseIf name = "Brian" Then		                        'Strings can also be compared using- name.Equals("Brian")  
           DoSomethingElse()
        Else
            DoSomethingDefault()
        End If
        'Nested If statements contain one or more If statements in an If statement


        'Conditional Operators        
        If isTrue <> True Then			                         '   <>  Not equal, same as '!' in other languages
			DoSomething()                                        '   =   Equals To
        End If              			                         '   >=  Greater Than or Equal To
                                                                 '   <=   
        
        'Logical Operators
        
        If name.Equals("Brian") Or name.Equals("Danley") Then	' Or     or operator, same as || in other languages
																' And    and operator, same as && in other languages
            DoSomething()
        End If
        Console.ReadLine()
'-----------------------------------------------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub DoSomething()
        Throw New NotImplementedException
    End Sub

    Private Sub DoSomethingElse()
        Throw New NotImplementedException
    End Sub

    Private Sub DoSomethingDefault()
        Throw New NotImplementedException
    End Sub
End Module