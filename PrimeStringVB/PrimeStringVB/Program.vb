Imports System

Module Program
    Sub Main(args As String())
        Messages(GetID(GetUserInput(), GetPrimeString()))
    End Sub

    Function GetUserInput()
        Dim inpt = 0

        Console.WriteLine("Prime String Finder")
        Console.WriteLine("Please enter a number between 1 and 1,000")

        For i As Integer = 0 To 1000
            If Integer.TryParse(Console.ReadLine(), result:=inpt) Then
                If (inpt > 1000 Or inpt < 1) Then
                    Console.WriteLine("Invalid input, please enter a number between 1 and 1,000")
                Else
                    ' Value is good break loop
                    Exit For
                End If
            Else
                Console.WriteLine("Invalid input, please enter a number between 1 and 1,000")
            End If
        Next

        Return inpt
    End Function

    Function GetPrimeString()
        Dim primeString = ""
        Dim isPrime

        For i As Integer = 2 To 1993
            isPrime = 0

            For j As Integer = 2 To i - 1
                If (i Mod j = 0) Then
                    isPrime += 1
                End If
            Next

            If isPrime = 0 Then
                primeString = primeString & i
            End If
        Next

        Return primeString
    End Function

    Function GetID(input As Integer, primeString As String)
        Dim idInt = 0
        input -= 1

        Integer.TryParse(primeString.Substring(input, 5), idInt)

        Return idInt
    End Function

    Sub Messages(id As Integer)

        Console.WriteLine("Your ID is: " & id)
        Console.ReadKey()

    End Sub
End Module