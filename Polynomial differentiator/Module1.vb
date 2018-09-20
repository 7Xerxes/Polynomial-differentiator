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
        Console.ReadLine()
    End Sub

End Module