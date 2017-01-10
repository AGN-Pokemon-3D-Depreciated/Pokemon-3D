Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Sub Main(ByVal args As String())
        Debug.Print(" ")
        Debug.Print("PROGRAM EXECUTION STARTED")
        Debug.Print("STACK TRACE ENTRY                   | MESSAGE")
        Debug.Print("------------------------------------|------------------------------------")

        CommandLineArgHandler.Initialize(args)

        Logger.Debug("---Start game---")

        Using Game As New GameController()
            Try
                Game.Run()
            Catch ex As Exception When GameController.IS_DEBUG_ACTIVE = False OrElse Debugger.IsAttached = False
                Dim informationItem As New Logger.ErrorInformation(ex)
                Logger.LogCrash(ex)
                Logger.Log(Logger.LogTypes.ErrorMessage, "The game crashed with error ID: " & informationItem.ErrorIDString & " (" & ex.Message & ")")
            Catch ex As Exception When GameController.IS_DEBUG_ACTIVE = True AndAlso Debugger.IsAttached = True
                Throw ex
            End Try
        End Using
    End Sub

End Module
