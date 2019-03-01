Module Module1

    Dim candidates(3) As String
    Dim voteRecord(3) As Integer
    Dim count As Integer = 0
    Dim vote As Integer

    Sub getcands()
        Dim numCands As Integer
        While numCands < 2 Or numCands > 4

            Console.WriteLine("How many candidates are standing?")
            numCands = Console.ReadLine()
        End While

        For i = 0 To numCands - 1
            Console.WriteLine("What is the name of candidate number " & i + 1)
            candidates(i) = Console.ReadLine()
        Next

    End Sub

    Sub getVotes()



        While count < 30

            vote = 0

            While vote < 1 Or vote > 4
                Console.WriteLine("PLease Enter your vote: 1: for candidate 1, 2: for candidate 2, 3: for candidate 3, 4: for candidate 4, -1 to stop voting")
                vote = Console.ReadLine()


                Select Case vote
                Case = 1
                    voteRecord(0) = voteRecord(0) + 1
                Case = 2
                    voteRecord(1) = voteRecord(1) + 1
                Case = 3
                    voteRecord(2) = voteRecord(2) + 1
                Case = 4
                    voteRecord(3) = voteRecord(3) + 1
                Case = -1
                    Exit Sub
                Case Else
                    Console.WriteLine("Vote Invalid")
            End Select

            End While


            count = count + 1


        End While


    End Sub
    Sub OutputRecords()
        For i = 0 To 3
            Console.WriteLine(candidates(i) & "  " & voteRecord(i))
        Next

    End Sub

    Sub getresults()
        If voteRecord(0) > voteRecord(1) And voteRecord(0) > voteRecord(2) And voteRecord(0) > voteRecord(3) Then
            Console.WriteLine(candidates(0) & "is the Winner with " & voteRecord(0) & " votes")
        ElseIf voteRecord(1) > voteRecord(0) And voteRecord(1) > voteRecord(2) And voteRecord(1) > voteRecord(3) Then
            Console.WriteLine(candidates(1) & "is the Winner with " & voteRecord(1) & " votes")
        ElseIf voteRecord(2) > voteRecord(0) And voteRecord(2) > voteRecord(1) And voteRecord(2) > voteRecord(3) Then
            Console.WriteLine(candidates(2) & "is the Winner with " & voteRecord(2) & " votes")
        ElseIf voteRecord(3) > voteRecord(0) And voteRecord(3) > voteRecord(1) And voteRecord(3) > voteRecord(2) Then
            Console.WriteLine(candidates(3) & "is the Winner with " & voteRecord(3) & " votes")
        Else
            Console.WriteLine("No Overall Winner")
        End If
    End Sub

    Sub Main()

        getcands()

        getVotes()

        OutputRecords()

        getresults()




        Console.ReadKey()



    End Sub

End Module
