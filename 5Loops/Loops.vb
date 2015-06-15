Module Loops
Sub Main()

        ' 1.Select Case 
        'SelectCaseLoop()

        ' 2.For Next
        'ForNextLoop()
        'ForNextWithStepOperator()

        ' 3.LoopExit
        'ContinueExitForLoop()

        '4.Do Untill and While loops
        'DoUntillLoop()
        'DoWhileLoop()
        'DoLoopUntill()

        Console.ReadLine()      'Wait for user 

    End Sub
    Private Sub DoLoopUntill()
        Dim isTrue As Boolean
        Do
            Console.WriteLine("My  name is Brian")
            isTrue = False
        Loop Until isTrue = False
    End Sub
    Private Sub DoWhileLoop()
        Dim age As Integer
        Do While age < 10
            Console.WriteLine("Hello Young One")
            age += 1
        Loop
    End Sub
    Private Sub DoUntillLoop()
        Dim i As Integer
        Do Until i = 24
            Console.WriteLine("Not yet 24")
            i += 1
        Loop
    End Sub
    Private Sub ContinueExitForLoop()
        Dim i As Integer
        For i = 30 To 0 Step -3

            If i = 15 Then
                Console.WriteLine("Exited For Loop Before Reaching Zero")
                Exit For

            End If
            If (i Mod 2) = 0 Then
                Console.WriteLine("Am going to continue because " + i.ToString + " is even")
                Continue For
            End If

            Console.WriteLine(" i is " + i.ToString)

        Next
    End Sub
    Private Sub ForNextLoop()
        Dim i As Integer
        For i = 1 To 20
            Console.WriteLine(i)
        Next

    End Sub
    Private Sub ForNextWithStepOperator()
        Dim i As Integer
        For i = 0 To 100 Step 5     'you can also step by a -ve to count backwards
            Console.WriteLine(i)
        Next
    End Sub
    Private Sub SelectCaseLoop()
        Console.WriteLine("How old are you: ??")
        Dim age As Integer = Console.ReadLine()
        Select Case age
            Case 0
                Console.WriteLine("You cant be 0 years old")
            Case 2
                Console.WriteLine("You are too young")
            Case Else
                Console.WriteLine("Whats that!!")
        End Select
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
