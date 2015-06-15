Module StringOperations

    Sub main()
        'String Declaration
        Dim s1 As String = "firstString"
        Dim s2 As String = "secondString"

        'String concatenation
        Dim s1s2 As String = s1 + s2
        Dim newString As String = "This is the " + s1 + " concatenated to the " + s2
		
		'Another concatenation way
        Console.WriteLine(s1s2)
		
		'Get String length
		Console.WriteLine("The length of " +s1+ "is " + s1.Length)
		
		'Substring
		Dim subString As String = s2.Substring(0, 6)	'start and stop indeces
		Dim subString As String = s2.Substring(3) 		'The given only index is taken as the start
		
		'String Formating
		Dim d1 As Double = 458.89666
		
		Console.WriteLine(String.Format("{0:n3}", d1))	'limits the output to  only three d.p
        s2.ToLower()									'to Lower Case
        s2.ToUpper()									'to Upper Case
		
		'Modifying string Content
        Dim repStr As String = s2.Replace("second", "last") 'replace substrings first string is replaced with the second
        Dim repChar As String = s2.Replace("s", "n")        'replace chars, first char is replaced with the second
		
		'String compare
        Console.WriteLine(String.Compare(s1, s2))       'Compares s1 and s2 and returns an integer, It just looks like it compares the
														'length to me 
        Console.WriteLine(String.Compare(s1, s2, True)) 'Third param sets Case comparison Off

		
        Console.ReadLine()

    End Sub



End Module
