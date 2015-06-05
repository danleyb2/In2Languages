Module LoopsAndConditions

    Sub Main()
    
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    
        ' 1. If Statements
		
		
        Dim isTrue As Boolean = False
        Dim name As String = "Brian"

        If isTrue Then
            
            DoSomething() 				                        'Code to be executed if Condition is true

        ElseIf name = "Brian" Then		                        'Strings can also be compared using
            							                        '   name.Equals("Brian")
            DoSomethingElse()

        Else
            DoSomethingDefault()

        End If
        'Nested If statements contain one or more If statements in an If statement

        'Conditional Operators

         
        If isTrue <> True Then			                         '   <>   Not equal
			DoSomething()				                         '   >=  Greater Than or Equal To
            
        End If
        
        

        'Logical Operators
		
        
        
        If name.Equals("Brian") Or name.Equals("Danley") Then	' Or     or operator, same as || in other languages
																' And    and operator, same as && in other languages
            DoSomething()

        End If
        
'-----------------------------------------------------------------------------------------------------------------------------------------------
' 2.Select Case 
  Console.WriteLine("How old are you: ??")
  Dim age As Integer = Console.Readline()
  

        
        
        
        Console.Readline()      'Wait for user 



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
