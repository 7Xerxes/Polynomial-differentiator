Module Module1
    'Checks if a string represents a whole integer
    Function stringIsInteger(inp As String)

        'Empty strings ain't numbers
        If inp = "" Then
            Return False
        End If

        'Only acceptable characters in an integer-string
        Dim characters() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

        For Each character In inp
            'If the character isn't one of the permissable characters, the string can't represent an integer
            If Not characters.Contains(character) Then
                Return False
            End If
        Next

        'If the string passes through the loop without returning false, it's true by default
        Return True
    End Function

    Function getIntegerFromUser()
        Dim inp As String = "holder"

        'Continually asks for an input until the input represents an integer
        While Not stringIsInteger(inp)
            Console.Write("...")
            inp = Console.ReadLine()
        End While

        Return CInt(inp)
    End Function

    Sub Main()
        Console.WriteLine("Polynomial Differentiator" & vbCrLf & "Please input the degree of your polynomial:" & vbCrLf)

        Dim degree As Integer = getIntegerFromUser()
        Console.WriteLine("So your polynomial is of degree " & degree)

        Dim terms(degree) As Integer

        For i = 0 To degree - 1
            Console.Write("Input the coefficient of x^" & degree - i)
            terms(i) = getIntegerFromUser()
            terms(i) = terms(i) * (degree - i)
        Next

        'Now 2.0% more commented
        For i = 0 To degree - 1
            If degree - (i + 1) > 0 Then
                Console.Write(terms(i) & "x^" & degree - (i + 1) & " + ")
            Else
                Console.Write(terms(i))
            End If
        Next

        Console.ReadLine()
    End Sub

End Module