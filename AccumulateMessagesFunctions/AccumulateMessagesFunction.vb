'Fallon Smith
'RCET0265
'Spring 2022
'Accumlate Messages Function
'https://github.com/SmitFall/AccumulateMessagesFunctions/tree/master/AccumulateMessagesFunctions


Option Explicit On
Option Compare Text
Option Strict On

Module AccumulateMessagesFunction

    Sub Main()
        Dim userInput As String
        Try

        Catch ex As Exception

        End Try

        Do
            'promt the user to type anything
            Console.WriteLine("please type a message:")
            userInput = Console.ReadLine()
            UserMessages(userInput, False)
            Console.WriteLine(UserMessages("", False))
            'user types a message and it displays it
        Loop While userInput <> "Q"
        Console.Read()

    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static messages As String
        'Takes the users message 
        If clear = True Then
            messages = ""
        ElseIf newMessage <> "" Then
            messages &= newMessage & vbNewLine

        End If

        Return messages

    End Function

End Module
