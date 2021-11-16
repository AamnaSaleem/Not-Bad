Module Module1

    Sub Main()
        Dim NotPos, BadPos As Integer
        Dim FP, SP, str1 As String

        Console.Write("Enter line to be processed: ")
        str1 = Console.ReadLine

        NotPos = InStr(str1, "not")
        BadPos = InStr(str1, "bad")

        FP = Left(str1, NotPos - 1)
        SP = Right(str1, (Len(str1) - BadPos - 4))

        Console.WriteLine(FP & " good " & SP)
        Console.ReadKey()
    End Sub

End Module
